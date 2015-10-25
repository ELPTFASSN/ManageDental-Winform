using ManagerPartient.CustomControl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ManagerPartient.Core
{
    public class ExcelWriter
    {
        public ExcelWriter() { }

        private static string GetConnectionString(string extensionFile, string filePath, bool header)
        {
            string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            string conStr = String.Empty;
            switch (extensionFile)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            return conStr;
        }

        private string DataTypeTable(Type type)
        {
            if (type.ToString().Contains("Int"))
                return "INT";
            if (type.ToString().Contains("String"))
                return "VARCHAR";
            if (type.ToString().Contains("Date"))
                return "DATE";
            if (type.ToString().Contains("Double"))
                return "FLOAT";
            if (type.ToString().Contains("Bool"))
                return "BIT";
            else return "VARCHAR";
        }

        public static void WriteExcelFile<T>(string filePath, IEnumerable<T> collection, bool openAfter)
        {
            string connectionString = GetConnectionString(".xls", filePath, true);

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                StringBuilder sb = new StringBuilder();
                int i = 0;

                Type impliedType = typeof(T);
                PropertyInfo[] _propInfo = impliedType.GetProperties();
                foreach (PropertyInfo pi in _propInfo)
                {
                    sb.Append(pi.Name.ToUpper().Equals("NOTE") ? ("_" + pi.Name.ToUpper()) : pi.Name.ToUpper());
                    sb.Append(" VARCHAR");
                    //sb.Append(new ExcelWriter().DataTypeTable(Nullable.GetUnderlyingType(pi.PropertyType) ?? pi.PropertyType));
                    if(i != _propInfo.Length-1)
                        sb.Append(", ");
                    i++;
                }

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                Console.WriteLine(sb.ToString());
                cmd.CommandText = "CREATE TABLE [patient] (" + sb.ToString() + ");";
                cmd.ExecuteNonQuery();
                sb.Clear();

                foreach (T item in collection)
                {
                    i = 0;
                    foreach (PropertyInfo pi in _propInfo)
                    {
                        object obj = string.Empty;
                        if (Nullable.GetUnderlyingType(pi.PropertyType) != null)
                            obj = pi.GetValue(item, null) ?? DBNull.Value;
                        if (pi.GetValue(item, null) != null)
                            obj = pi.GetValue(item, null);
                        sb.Append("'" + obj + " '");
                        if (i != _propInfo.Length - 1)
                            sb.Append(", ");
                        i++;
                    }
                    cmd.CommandText = "INSERT INTO [patient] VALUES(" + sb.ToString() + ");";
                    cmd.ExecuteNonQuery();
                    sb.Clear();
                }
                conn.Close();
            }
            if (openAfter)
            {
                FileInfo fi = new FileInfo(filePath);
                if (fi.Exists)
                    System.Diagnostics.Process.Start(@filePath);
            }
        }

        public static DataTable ImportExcel(String filePath)
        {
            string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

            if (filePath != null && !filePath.Equals(""))
            {
                string extension = System.IO.Path.GetExtension(filePath);
                string header = "YES";
                string connectionString, sheetName;

                connectionString = string.Empty;
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        connectionString = string.Format(Excel03ConString, filePath, header);
                        break;

                    case ".xlsx": //Excel 07
                        connectionString = string.Format(Excel07ConString, filePath, header);
                        break;

                    default:
                        {
                            MessageBoxEX.DialogMessageBox("Thông báo", "File chọn không hợp lệ. Vui lòng chọn file Excel", "Bạn hãy kiểm tra lại file chọn cho phù hợp");
                            return null;
                        }
                }

                //Get the name of the First Sheet.
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }

                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();

                            return dt;
                        }
                    }
                }
            }
            else
            {
                MessageBoxEX.DialogMessageBox("Thông báo", " Vui lòng chọn file Excel", "Bạn hãy kiểm tra lại file chọn cho phù hợp");
                return null;
            }
        }
    }
}

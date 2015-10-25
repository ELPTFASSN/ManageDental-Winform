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
    public class ExcelWriter : IDisposable
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

        public static void WriteExcelFile<T>(string extensionFile, string filePath, IEnumerable<T> collection)
        {
            string connectionString = GetConnectionString(extensionFile, filePath, true);

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                StringBuilder sb = new StringBuilder();
                int i = 0;

                Type impliedType = typeof(T);
                PropertyInfo[] _propInfo = impliedType.GetProperties();
                foreach (PropertyInfo pi in _propInfo)
                {
                    sb.Append(pi.Name);
                    sb.Append(" ");
                    sb.Append(new ExcelWriter().DataTypeTable(Nullable.GetUnderlyingType(pi.PropertyType) ?? pi.PropertyType));
                    if(i != _propInfo.Length-1)
                        sb.Append(", ");
                    i++;
                }

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                Console.WriteLine(sb.ToString());
                cmd.CommandText = "CREATE TABLE [table1] (ID INT, PatientID VARCHAR, NickName VARCHAR, FullName VARCHAR, Birthday DATE, Marital VARCHAR, Gender VARCHAR, ProfessionID INT, Address VARCHAR, Tel VARCHAR, MobilePhone VARCHAR, Email VARCHAR, Picture VARCHAR, Note VARCHAR, tb_profession VARCHAR );";
                //cmd.CommandText = "CREATE TABLE [patient] (" + sb.ToString() + " );";
                cmd.ExecuteNonQuery();

                //cmd.CommandText = "INSERT INTO [table1](id,name,datecol) VALUES(1,'AAAA','2014-01-01');";
                //cmd.ExecuteNonQuery();

                //cmd.CommandText = "INSERT INTO [table1](id,name,datecol) VALUES(2, 'BBBB','2014-01-03');";
                //cmd.ExecuteNonQuery();

                //cmd.CommandText = "INSERT INTO [table1](id,name,datecol) VALUES(3, 'CCCC','2014-01-03');";
                //cmd.ExecuteNonQuery();

                //cmd.CommandText = "UPDATE [table1] SET name = 'DDDD' WHERE id = 3;";
                //cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        private XmlWriter _writer;

        public enum CellStyle { General, Number, Currency, DateTime, ShortDate };

        public void WriteStartDocument()
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteProcessingInstruction("mso-application", "progid=\"Excel.Sheet\"");
            _writer.WriteStartElement("ss", "Workbook", "urn:schemas-microsoft-com:office:spreadsheet");
            WriteExcelStyles();
        }

        public void WriteEndDocument()
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteEndElement();
        }

        private void WriteExcelStyleElement(CellStyle style)
        {
            _writer.WriteStartElement("Style", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteAttributeString("ID", "urn:schemas-microsoft-com:office:spreadsheet", style.ToString());
            _writer.WriteEndElement();
        }

        private void WriteExcelStyleElement(CellStyle style, string NumberFormat)
        {
            _writer.WriteStartElement("Style", "urn:schemas-microsoft-com:office:spreadsheet");

            _writer.WriteAttributeString("ID", "urn:schemas-microsoft-com:office:spreadsheet", style.ToString());
            _writer.WriteStartElement("NumberFormat", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteAttributeString("Format", "urn:schemas-microsoft-com:office:spreadsheet", NumberFormat);
            _writer.WriteEndElement();

            _writer.WriteEndElement();

        }

        private void WriteExcelStyles()
        {
            _writer.WriteStartElement("Styles", "urn:schemas-microsoft-com:office:spreadsheet");

            WriteExcelStyleElement(CellStyle.General);
            WriteExcelStyleElement(CellStyle.Number, "General Number");
            WriteExcelStyleElement(CellStyle.DateTime, "General Date");
            WriteExcelStyleElement(CellStyle.Currency, "Currency");
            WriteExcelStyleElement(CellStyle.ShortDate, "Short Date");

            _writer.WriteEndElement();
        }

        public void WriteStartWorksheet(string name)
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteStartElement("Worksheet", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteAttributeString("Name", "urn:schemas-microsoft-com:office:spreadsheet", name);
            _writer.WriteStartElement("Table", "urn:schemas-microsoft-com:office:spreadsheet");
        }

        public void WriteEndWorksheet()
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteEndElement();
            _writer.WriteEndElement();
        }

        public ExcelWriter(string outputFileName)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            _writer = XmlWriter.Create(outputFileName, settings);
        }

        public void Close()
        {
            if (_writer == null) throw new InvalidOperationException("Already closed.");

            _writer.Close();
            _writer = null;
        }

        public void WriteExcelColumnDefinition(int columnWidth)
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteStartElement("Column", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteStartAttribute("Width", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteValue(columnWidth);
            _writer.WriteEndAttribute();
            _writer.WriteEndElement();
        }

        public void WriteExcelUnstyledCell(string value)
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteStartElement("Cell", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteStartElement("Data", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteAttributeString("Type", "urn:schemas-microsoft-com:office:spreadsheet", "String");
            _writer.WriteValue(value);
            _writer.WriteEndElement();
            _writer.WriteEndElement();
        }

        public void WriteStartRow()
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteStartElement("Row", "urn:schemas-microsoft-com:office:spreadsheet");
        }

        public void WriteEndRow()
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteEndElement();
        }

        public void WriteExcelStyledCell(object value, CellStyle style)
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            _writer.WriteStartElement("Cell", "urn:schemas-microsoft-com:office:spreadsheet");
            _writer.WriteAttributeString("StyleID", "urn:schemas-microsoft-com:office:spreadsheet", style.ToString());
            _writer.WriteStartElement("Data", "urn:schemas-microsoft-com:office:spreadsheet");
            switch (style)
            {
                case CellStyle.General:
                    _writer.WriteAttributeString("Type", "urn:schemas-microsoft-com:office:spreadsheet", "String");
                    break;
                case CellStyle.Number:
                case CellStyle.Currency:
                    _writer.WriteAttributeString("Type", "urn:schemas-microsoft-com:office:spreadsheet", "Number");
                    break;
                case CellStyle.ShortDate:
                case CellStyle.DateTime:
                    _writer.WriteAttributeString("Type", "urn:schemas-microsoft-com:office:spreadsheet", "DateTime");
                    break;
            }
            _writer.WriteValue(value);
            //  tag += String.Format("{1}\"><ss:Data ss:Type=\"DateTime\">{0:yyyy\\-MM\\-dd\\THH\\:mm\\:ss\\.fff}</ss:Data>", value,

            _writer.WriteEndElement();
            _writer.WriteEndElement();
        }

        public void WriteExcelAutoStyledCell(object value)
        {
            if (_writer == null) throw new InvalidOperationException("Cannot write after closing.");

            //write the <ss:Cell> and <ss:Data> tags for something
            if (value is Int16 || value is Int32 || value is Int64 || value is SByte ||
                value is UInt16 || value is UInt32 || value is UInt64 || value is Byte)
            {
                WriteExcelStyledCell(value, CellStyle.Number);
            }
            else if (value is Single || value is Double || value is Decimal) //we'll assume it's a currency
            {
                WriteExcelStyledCell(value, CellStyle.Currency);
            }
            else if (value is DateTime)
            {
                //check if there's no time information and use the appropriate style
                WriteExcelStyledCell(value, ((DateTime)value).TimeOfDay.CompareTo(new TimeSpan(0, 0, 0, 0, 0)) == 0 ? CellStyle.ShortDate : CellStyle.DateTime);
            }
            else
            {
                WriteExcelStyledCell(value, CellStyle.General);
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_writer == null)
                return;

            _writer.Close();
            _writer = null;
        }

        #endregion

        public static void ExportExcel(DataTable data, String fileName, bool openAfter)
        {
            try
            {
                using (ExcelWriter writer = new ExcelWriter(fileName))
                {
                    writer.WriteStartDocument();

                    // Write the worksheet contents
                    writer.WriteStartWorksheet("Sheet1");

                    //Write header row
                    writer.WriteStartRow();
                    foreach (DataColumn col in data.Columns)
                        writer.WriteExcelUnstyledCell(col.Caption);
                    writer.WriteEndRow();

                    //write data
                    foreach (DataRow row in data.Rows)
                    {
                        writer.WriteStartRow();
                        foreach (object o in row.ItemArray)
                        {
                            if (!(o is DBNull))
                                writer.WriteExcelAutoStyledCell(o);
                        }
                        writer.WriteEndRow();
                    }

                    // Close up the document
                    writer.WriteEndWorksheet();
                    writer.WriteEndDocument();
                    writer.Close();
                    if (openAfter)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        if (fi.Exists)
                            System.Diagnostics.Process.Start(@fileName);
                    }
                }
            }
            catch (Exception myException)
            {
                MessageBox.Show(myException.Message, "Excel Export", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
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
                string conStr, sheetName;

                conStr = string.Empty;
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, filePath, header);
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, filePath, header);
                        break;

                    default:
                        {
                            MessageBoxEX.DialogMessageBox("Thông báo", "File chọn không hợp lệ. Vui lòng chọn file Excel", "Bạn hãy kiểm tra lại file chọn cho phù hợp");
                            return null;
                        }
                }

                //Get the name of the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
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

                using (OleDbConnection con = new OleDbConnection(conStr))
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

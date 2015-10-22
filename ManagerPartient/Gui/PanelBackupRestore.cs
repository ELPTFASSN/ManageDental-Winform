using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManagerPartient.Core;
using System.Data.OleDb;
using ManagerPartient.CustomControl;
using ManagerPartient.ModelManage;
using ManagerPartient.Controller;
using System.Globalization;

namespace ManagerPartient.Gui
{
    public partial class PanelBackupRestore : UserControl, IFormDialogMain
    {
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        public PanelBackupRestore()
        {
            InitializeComponent();
        }

        public void cancel()
        {
            this.ParentForm.Close();
        }

        public void finish()
        {
            string filePath = txtPathFile.Text;
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
                            MessageBoxEX.DialogMessageBox("Thông báo", "File chọn không tồn tại hoặc hợp lệ", "Bạn hãy kiểm tra lại file chọn cho phù hợp");
                            return;
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

                List<tb_patient> patients;

                //Read Data from the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            bool flagIdIsNull = false;
                            patients = new List<tb_patient>();

                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();

                            foreach (DataRow row in dt.Rows)
                            {
                                Console.WriteLine("------ROW NEXT-----");

                                tb_patient patient = new tb_patient();

                                foreach (DataColumn column in dt.Columns)
                                {
                                    Console.Write("Item: ");
                                    Console.Write(column.ColumnName);
                                    Console.Write(" ");
                                    Console.WriteLine(row[column]);

                                    switch (column.ColumnName)
                                    {
                                        case "ID": patient.PatientID = row[column].ToString(); 
                                            break;
                                        case "FullName": patient.FullName = row[column].ToString();
                                            break;
                                        case "Birthday":
                                            {
                                                if (row[column] != null && !row[column].ToString().Equals(""))
                                                    patient.Birthday = DateTime.Parse(row[column].ToString(), new CultureInfo("en-CA"));
                                            }
                                            break;
                                        case "Gender": patient.Gender = (row[column].ToString().Equals("Nam")?"Male":(row[column].ToString().Equals("Nữ")?"Female":"Khác"));
                                            break;
                                        case "Mobile": patient.MobilePhone = row[column].ToString();
                                            break;
                                        case "Phone": patient.Tel = row[column].ToString();
                                            break;
                                        case "Email": patient.Email = row[column].ToString();
                                            break;
                                        case "Address": patient.Address = row[column].ToString();
                                            break;
                                        case "Note": patient.Note = row[column].ToString();
                                            break;
                                        default: break;
                                    }                                    
                                }

                                if (patient.PatientID != null && !patient.PatientID.Equals(""))
                                {
                                    patients.Add(patient);
                                    flagIdIsNull = false;
                                }
                                else
                                {
                                    if (flagIdIsNull)
                                    {
                                        break;
                                    }
                                    flagIdIsNull = true;
                                }
                            }
                        }
                    }
                }

                if(patients != null && patients.Count != 0)
                {
                    ManagerPartient.CustomControl.FormLoad f = new ManagerPartient.CustomControl.FormLoad();
                    f.Visible = true;
                    int num = 0;
                    foreach(tb_patient p in patients)
                    {
                        bool flagSave = PatientModelManage.Instance.CreatePatient(p);
                        if (flagSave) num += 1;
                    }
                    f.Close();
                    DialogResult dialogResult = MessageBoxEX.DialogMessageBox("Thông báo", "Đã hoàn thành thêm " + num + " bản ghi vào hệ thống", "");
                    if (dialogResult.Equals(DialogResult.OK))
                        this.ParentForm.Close();
                    return;
                }
                else
                {
                    MessageBoxEX.DialogMessageBox("Thông báo", "Dữ liệu trong file excel trống.", "Bạn hãy kiểm tra lại");
                    return;
                }
            }
            else
            {
                MessageBoxEX.DialogMessageBox("Thông báo", "Vui lòng chọn file phục hồi phù hợp", "Bạn hãy kiểm tra lại file chọn cho phù hợp");
                return;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtPathFile.Text = openFileDialog.FileName;            
        }
    }
}

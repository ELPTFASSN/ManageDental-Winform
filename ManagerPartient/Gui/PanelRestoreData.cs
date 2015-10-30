using ManagerPartient.Controller;
using ManagerPartient.Core;
using ManagerPartient.CustomControl;
using ManagerPartient.ModelManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagerPartient.Gui
{
    public partial class PanelRestoreData : UserControl, IFormDialogMain
    {
        SqlCommand cmd;
        SqlConnection con;

        public PanelRestoreData()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!System.IO.Directory.Exists(desktopPath))
                desktopPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            openFileDialog.InitialDirectory = @desktopPath;
            openFileDialog.Filter = "Restore Files|*.bak";
            openFileDialog.Title = "Vui lòng chọn file phục hồi";
        }

        public void cancel()
        {
            this.ParentForm.Close();
        }

        public void finish()
        {
            if(rbRetoreAll.Checked)
            {
                if (!txtPathFile.Text.Contains(".bak"))
                {
                    MessageBox.Show("File không hợp lệ !");
                    return;
                }
                
                ManagerPartient.CustomControl.FormLoad f = new ManagerPartient.CustomControl.FormLoad();
                f.TopMost = true;
                f.TopLevel = true;
                f.Size = new System.Drawing.Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
                f.WindowState = FormWindowState.Maximized;
                f.Show();

                try
                {
                    con = new SqlConnection("Data Source=.\\SQLEXPRESS;Database=Master;data source=.; uid=sa; pwd=123456;");
                    con.Open();
                    cmd = new SqlCommand("ALTER DATABASE nks_db SET SINGLE_USER WITH ROLLBACK IMMEDIATE", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("Restore database nks_db from disk='" + txtPathFile.Text + "' with replace", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("alter database nks_db set multi_user", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    f.Close();
                }


                DialogResult dialogResult = MessageBoxEX.DialogMessageBox("Thông báo", "Khôi phục dữ liệu thành công", "");
                if (dialogResult.Equals(DialogResult.OK))
                {
                    this.ParentForm.Close();
                    System.Diagnostics.Process.Start(Application.ExecutablePath); 
                    //Application.Exit();
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
            else
            {
                if (rbInsertData.Checked)
                {
                    List<tb_patient> patients = new List<tb_patient>();
                    List<tb_patient> patientsNotVaild = new List<tb_patient>();
                    bool flagRowEmpty = false;
                    DataTable tableSheet = ExcelWriter.ImportExcel(txtPathFile.Text);

                    for (int i = 0; i < tableSheet.Rows.Count; i++)
                    {
                        // Duyệt từng dòng lấy dữ liệu 
                        tb_patient patient = new tb_patient();
                        patient.PatientID = tableSheet.Rows[i]["PatientID"].ToString();
                        patient.FullName = tableSheet.Rows[i]["FullName"].ToString();
                        Object birthday = tableSheet.Rows[i]["Birthday"];
                        if (birthday != null && !birthday.ToString().Equals(""))
                            patient.Birthday = DateTime.Parse(birthday.ToString(), new System.Globalization.CultureInfo("en-CA"));
                        patient.Gender = (tableSheet.Rows[i]["Gender"].ToString().Equals("Nam") ? "Male" : (tableSheet.Rows[i]["Gender"].ToString().Equals("Nữ") ? "Female" : "Other"));
                        patient.MobilePhone = tableSheet.Rows[i]["MobilePhone"].ToString();
                        patient.Tel = tableSheet.Rows[i]["Tel"].ToString();
                        patient.Email = tableSheet.Rows[i]["Email"].ToString();
                        patient.Address = tableSheet.Rows[i]["Address"].ToString();
                        patient.Note = tableSheet.Rows[i]["_Note"].ToString();

                        // Kiểm tra dòng này đã là dòng trống chưa?
                        if (patient.PatientID.Equals("") && patient.FullName.Equals("") && patient.Address.Equals(""))
                        {
                            if (flagRowEmpty)
                                break;
                            flagRowEmpty = true;
                        }
                        else flagRowEmpty = false;

                        // Không phải dòng trống thì add list
                        if (!flagRowEmpty)
                        {
                            // Kiểm tra cell mã không được bỏ trống
                            if (!patient.PatientID.Equals(""))
                            {
                                // Kiểm tra có trùng mã không?
                                tb_patient patientChk = PatientModelManage.Instance.FindPatientByCode(patient.PatientID);
                                if (patientChk != null)
                                {
                                    patient.Gender = patient.Gender.Equals("Male") ? "Nam" : (patient.Gender.Equals("Female") ? "Nữ" : "Khác");
                                    patientsNotVaild.Add(patient);
                                }
                                else
                                    patients.Add(patient);
                            }
                            else
                            {
                                patient.Gender = patient.Gender.Equals("Male") ? "Nam" : (patient.Gender.Equals("Female") ? "Nữ" : "Khác");
                                // Nếu bất kì lỗi gì thì add vào list ko hợp lệ
                                patientsNotVaild.Add(patient);
                            }
                        }
                    }

                    if (patientsNotVaild.Count > 0)
                    {
                        DialogResult result = MessageBoxEX.DialogMessageBox("Thông báo", "Dữ liệu trong file excel có lỗi. Bạn muốn tiếp tục không ghi dữ liệu vào hệ thống?", "Nếu tiếp tục bạn chương trình sẽ xuất ra file Excel các bản ghi lỗi. Còn các bản ghi hợp lệ sẽ được lưu vào trong hệ thống");

                        // Ghi dữ liệu lỗi ra file Excel và hiển thị nó lên
                        string directoryPath = System.IO.Path.GetDirectoryName(txtPathFile.Text);
                        ExcelWriter.WriteExcelFile<tb_patient>(directoryPath + "\\dataError.xls", patientsNotVaild, true);
                        if (result.Equals(DialogResult.Cancel))
                            return;
                    }

                    if (patients.Count > 0)
                    {
                        ManagerPartient.CustomControl.FormLoad f = new ManagerPartient.CustomControl.FormLoad();
                        f.TopMost = true;
                        f.TopLevel = true;
                        f.Size = new System.Drawing.Size(SystemInformation.VirtualScreen.Width,SystemInformation.VirtualScreen.Height);
                        f.WindowState = FormWindowState.Maximized;
                        f.Show();
                        int num = 0;
                        foreach (tb_patient p in patients)
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
            }            

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowHelp = true;
            if(rbInsertData.Checked)
                openFileDialog.FileName = "excel_file.xlsx";
            else openFileDialog.FileName = "bak_file.bak";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtPathFile.Text = openFileDialog.FileName;
        }

        private void rbInsertData_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            txtPathFile.Text = "";
        }

        private void rbRetoreAll_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Restore Files|*.bak";
            txtPathFile.Text = "";
        }
    }
}

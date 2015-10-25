using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManagerPartient.Core;
using System.Data.SqlClient;
using ManagerPartient.ModelManage;
using ManagerPartient.Controller;
using ManagerPartient.CustomControl;

namespace ManagerPartient.Gui
{
    public partial class PanelBackupData : UserControl, IFormDialogMain
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string extendFile = ".sqlserver.bak";

        public PanelBackupData()
        {
            InitializeComponent();
            serverName(".");
            databaseName();
        }

        public void cancel()
        {
            this.ParentForm.Close();
        }

        public void finish()
        {            
            if (rbRetoreAll.Checked)
            {
                if (!System.IO.Path.GetExtension(txtPathFile.Text).Equals(".bak"))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại đường dẫn lưu file sao lưu !");
                    txtPathFile.Text = folderBrowserDialog.SelectedPath + "//backup_" + DateTime.Now.ToFileTime().ToString() + extendFile;
                    return;
                }

                ManagerPartient.CustomControl.FormLoad f = new ManagerPartient.CustomControl.FormLoad();
                f.TopMost = true;
                f.TopLevel = true;
                f.Size = new System.Drawing.Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
                f.WindowState = FormWindowState.Maximized;
                f.Show();

                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Database=Master;data source=.; uid=sa; pwd=123456;");
                con.Open();
                cmd = new SqlCommand("Backup database nks_db to disk='" + txtPathFile.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                f.Close();
                DialogResult dialogResult = MessageBoxEX.DialogMessageBox("Thông báo", "Sao lưu dữ liệu thành công", "File sao lưu được lưu ở " + txtPathFile.Text);
                if (dialogResult.Equals(DialogResult.OK))
                    this.ParentForm.Close();
            }
            else
            {
                if (rbInsertData.Checked)
                {
                    if (!System.IO.Path.GetExtension(txtPathFile.Text).Equals(".xls"))
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại đường dẫn lưu file sao lưu !");
                        txtPathFile.Text = folderBrowserDialog.SelectedPath + "//backup_" + DateTime.Now.ToFileTime().ToString() + extendFile;
                        return;
                    }
                    ExcelWriter.WriteExcelFile<tb_patient>(txtPathFile.Text, PatientModelManage.Instance.FindAllPatients(), true);
                    this.ParentForm.Close();
                }
            }
            
        }

        public void serverName(string serverName)
        {
            con = new SqlConnection("Data Source=" + serverName + ";Database=Master;data source=.; uid=sa; pwd=123456;");
            con.Open();
            cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbServerName.Items.Add(dr[2]);
            }
            dr.Close();
            con.Close();
        }

        public void databaseName()
        {
            con = new SqlConnection("Data Source=" + (cbServerName.Text) + ";Database=Master;data source=.; uid=sa; pwd=123456;");
            con.Open();
            cbDatabaseName.Items.Clear();
            cmd = new SqlCommand("select * from sysdatabases", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbDatabaseName.Items.Add(dr[0]);
            }
            dr.Close();
            con.Close();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtPathFile.Text = folderBrowserDialog.SelectedPath + "//backup_" + DateTime.Now.ToFileTime().ToString() + extendFile;
        }

        private void rbRetoreAll_CheckedChanged(object sender, EventArgs e)
        {
            extendFile = ".sqlserver.bak";
            txtPathFile.Text = "";
        }

        private void rbInsertData_CheckedChanged(object sender, EventArgs e)
        {
            extendFile = ".officeexcel.xls";
            txtPathFile.Text = "";
        }
    }
}

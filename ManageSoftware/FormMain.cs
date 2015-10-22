using ManageSoftware.Core;
using ManageSoftware.Gui;
using ManageSoftware.ModelManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSoftware
{    
    public partial class FormMain : Form
    {
        /**
         * Variable
         **/ 
        private PanelHome panelHome;
        private PanelListPatient panelListPatient;

        /**
         * Properties
         **/

        public FormMain()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblNaviBar1.Image = UtilImage.ResizeImage(global::ManageSoftware.Properties.Resources.button_menu_2, 120, 34);
            this.lblNaviBar2.Image = UtilImage.ResizeImage(global::ManageSoftware.Properties.Resources.button_menu_2, 120, 34);
            this.lblNaviBar3.Image = UtilImage.ResizeImage(global::ManageSoftware.Properties.Resources.button_menu_2, 120, 34);

            panelHome = new PanelHome();
            panelListPatient = new PanelListPatient();

            panelListPatient.DisplayPanelEvent += new DisplayPanelHander(DisplayPanel);

            panelMain.SuspendLayout();
            panelMain.Controls.Add(panelHome);
            panelMain.Controls.Add(panelListPatient);
            panelMain.ResumeLayout();

            panelHome.Hide();
            panelListPatient.Show();

            panelMain.Name = typeof(PanelListPatient).Name;
        }

        void DisplayPanel(object _child)
        {
            if (_child != null && _child is tb_person)
            {
                panelHome.Show();
                panelListPatient.Hide();
                panelMain.Name = typeof(PanelHome).Name;
                tb_person person = (tb_person)_child;
                panelHome.Person = person;
                lblNaviBar2.Visible = true;
                lblNaviBar2.Text = person.FullName;
            }
            else
            {
                if (_child != null && _child is string)
                {
                    foreach (UserControl c in panelMain.Controls)
                        ((IFormPanelChild)c).Hide();
                    if (_child.ToString().Equals(typeof(PanelListPatient).Name))
                    {                        
                        panelListPatient.RefeshDataTable(null);
                        panelListPatient.Show();
                        lblNaviBar2.Visible = false;
                        lblNaviBar2.Text = "Empty";
                    }
                }
            }           
        }

        private void btnBenhNhanMoi_Click(object sender, EventArgs e)
        {
            PanelCreatePatient panel = new PanelCreatePatient();
            panel.Dock = DockStyle.Fill;
            panel.PanelListPatient = panelListPatient;
            FormDialogMain form = new FormDialogMain(panel);
            form.Text = "Thêm bệnh nhân mới";
            form.TitleForm = "Thêm bệnh nhân mới";
            form.DesciptionForm = "Tạo thông tin chi tiết cho bệnh nhân lần đầu tiên";
            form.ShowDialog();
        }

        private void btnBenhNhanMoi_MouseEnter(object sender, EventArgs e)
        {
            this.btnBenhNhanMoi.BackgroundImage = global::ManageSoftware.Properties.Resources.background_button_hover;            
            this.btnBenhNhanMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBenhNhanMoi.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btnBenhNhanMoi_MouseLeave(object sender, EventArgs e)
        {
            this.btnBenhNhanMoi.BackgroundImage = null;
            this.btnBenhNhanMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnBenhNhanMoi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void lblNaviBar1_MouseEnter(object sender, EventArgs e)
        {
            this.lblNaviBar1.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblNaviBar1_MouseLeave(object sender, EventArgs e)
        {
            this.lblNaviBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void lblNaviBar2_MouseEnter(object sender, EventArgs e)
        {
            this.lblNaviBar2.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblNaviBar2_MouseLeave(object sender, EventArgs e)
        {
            this.lblNaviBar2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void lblNaviBar3_MouseEnter(object sender, EventArgs e)
        {
            this.lblNaviBar3.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lblNaviBar3_MouseLeave(object sender, EventArgs e)
        {
            this.lblNaviBar3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void frMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Dispose();
            Application.Exit();
        }

        private void lblNaviBar3_Click(object sender, EventArgs e)
        {

        }

        private void lblNaviBar2_Click(object sender, EventArgs e)
        {

        }

        private void lblNaviBar1_Click(object sender, EventArgs e)
        {
            DisplayPanel(typeof(PanelListPatient).Name);
        }

        private void btnQuanLyPhongKham_Click()
        {
            SettingPortCOM panel = SettingPortCOM.Instance;
            FormDialogMain form = new FormDialogMain(panel);
            form.Text = "Cấu hình kết nối";
            form.TitleForm = "Kết nối cổng COM";
            form.DesciptionForm = "Chọn thông số kết nối để thiết lập kết nối cổng COM";
            form.Size = new Size(450, 500);
            form.ShowDialog();
        }

        private void btnHoSoBenhNhan_Click()
        {
            DisplayPanel(typeof(PanelListPatient).Name);
        }

        private void lblNaviBar2_VisibleChanged(object sender, EventArgs e)
        {
            if(lblNaviBar2.Visible)
            {
                this.lblNaviBar1.Image = UtilImage.ResizeImage(global::ManageSoftware.Properties.Resources.button_menu_1, 120, 34);
                this.lblNaviBar2.Image = UtilImage.ResizeImage(global::ManageSoftware.Properties.Resources.button_menu_2, 120, 34);
            }
            else
            {
                this.lblNaviBar1.Image = UtilImage.ResizeImage(global::ManageSoftware.Properties.Resources.button_menu_2, 120, 34);
            }
        }
    }

}

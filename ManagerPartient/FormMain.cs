using ManagerPartient.Core;
using ManagerPartient.Gui;
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

namespace ManagerPartient
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
            this.lblNaviBar1.Image = UtilImage.ResizeImage(global::ManagerPartient.Properties.Resources.button_menu_2, 120, 34);
            this.lblNaviBar2.Image = UtilImage.ResizeImage(global::ManagerPartient.Properties.Resources.button_menu_1, 120, 34);
            this.lblNaviBar3.Image = UtilImage.ResizeImage(global::ManagerPartient.Properties.Resources.button_menu_1, 120, 34);

            panelHome = new PanelHome();
            panelListPatient = new PanelListPatient();

            panelHome.DisplayPanelEvent += new DisplayPanelHander(DisplayPanel);
            panelListPatient.DisplayPanelEvent += new DisplayPanelHander(DisplayPanel);

            panelMain.SuspendLayout();
            panelMain.Controls.Add(panelHome);
            panelMain.Controls.Add(panelListPatient);
            panelMain.ResumeLayout();

            panelHome.Show();
            panelListPatient.Hide();

            panelMain.Name = typeof(PanelHome).Name;
        }

        void DisplayPanel(object _child)
        {
            if (!_child.ToString().Equals(panelMain.Name))
            {
                foreach (UserControl c in panelMain.Controls)
                {
                    ((IFormPanelChild)c).Hide();
                }
                if (_child.ToString().Equals(typeof(PanelListPatient).Name))
                {
                    panelListPatient.RefeshDataTable(null);
                    panelListPatient.Show();
                    lblNaviBar2.Visible = true;
                    lblNaviBar2.Text = "Danh sách";
                }
                else
                {
                    if (_child.ToString().Equals(typeof(PanelHome).Name))
                    {
                        panelHome.Show();
                        lblNaviBar2.Visible = false;
                        lblNaviBar2.Text = "Empty";
                    }
                    else
                    {
                        if (_child.ToString().Equals("Backup"))
                        {
                            PanelFunction panelFunction = new PanelFunction();
                            panelFunction.Dock = DockStyle.Fill;
                            panelMain.Controls.Add(panelFunction);
                            panelFunction.Show();
                            lblNaviBar2.Visible = true;
                            lblNaviBar2.Text = "Backup";
                        }
                        else
                        {

                            this.Hide();
                            Form aboutForm = new Form();
                            AboutMe aboutMe = new AboutMe();
                            aboutMe.Dock = DockStyle.Fill;
                            aboutForm.Size = aboutMe.Size;
                            aboutForm.WindowState = FormWindowState.Normal;
                            aboutForm.StartPosition = FormStartPosition.CenterScreen;
                            aboutForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                            aboutForm.Controls.Add(aboutMe);
                            aboutForm.ShowDialog();
                            this.Show();

                            panelHome.Show();
                            lblNaviBar2.Visible = false;
                            lblNaviBar2.Text = "Empty";
                            panelMain.Name = typeof(PanelHome).Name;
                            return;
                        }
                    }
                }
                panelMain.Name = _child.ToString();
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
            this.btnBenhNhanMoi.BackgroundImage = global::ManagerPartient.Properties.Resources.background_button_hover;            
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
            //Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void lblNaviBar3_Click(object sender, EventArgs e)
        {

        }

        private void lblNaviBar2_Click(object sender, EventArgs e)
        {

        }

        private void lblNaviBar1_Click(object sender, EventArgs e)
        {
            DisplayPanel(typeof(PanelHome).Name);
        }

        private void btnHoSoBenhNhan_Click()
        {
            DisplayPanel(typeof(PanelListPatient).Name);
        }

        private void lblNaviBar2_VisibleChanged(object sender, EventArgs e)
        {
            if(lblNaviBar2.Visible)
            {
                this.lblNaviBar1.Image = UtilImage.ResizeImage(global::ManagerPartient.Properties.Resources.button_menu_1, 120, 34);
                this.lblNaviBar2.Image = UtilImage.ResizeImage(global::ManagerPartient.Properties.Resources.button_menu_2, 120, 34);
            }
            else
            {
                this.lblNaviBar1.Image = UtilImage.ResizeImage(global::ManagerPartient.Properties.Resources.button_menu_2, 120, 34);
            }
        }
    }

}

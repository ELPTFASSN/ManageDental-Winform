using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ManageSoftware.Core;

namespace ManageSoftware.Gui
{
    public partial class PanelFunction : UserControl, IFormPanelChild
    {
        public event DisplayPanelHander DisplayPanelEvent;

        public PanelFunction()
        {            
            InitializeComponent();
            SettingForm();
        }

        public new void Hide()
        {
            base.Hide();
        }

        public new void Show()
        {
            base.Show();
        }

        public void SettingForm()
        {
            this.Dock = DockStyle.Fill;
            this.Name = "Panel Backup";
        }

        private void btnRestoreData_Click(object sender, EventArgs e)
        {
            PanelBackupRestore panel = new PanelBackupRestore();
            panel.Dock = DockStyle.Fill;
            FormDialogMain form = new FormDialogMain(panel);
            form.Size = new Size(form.Bounds.Width, 550);
            form.Text = "Phục hồi dữ liệu";
            form.TitleForm = form.Text;
            form.DesciptionForm = "Phục hồi khôi phục lại dữ liệu đã sao lưu từ trước";
            form.ShowDialog();            
        }
    }
}

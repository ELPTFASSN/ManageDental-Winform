using ManagerPartient.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerPartient.Gui
{
    public partial class FormDialogMain : Form
    {
        private IFormDialogMain iFormDialogMain;

        public FormDialogMain(IFormDialogMain _iFormDialogMain)
        {
            this.iFormDialogMain = _iFormDialogMain;
            InitializeComponent();
            this.panelMain.SuspendLayout();
            this.panelMain.Controls.Add((System.Windows.Forms.UserControl)_iFormDialogMain);
            this.panelMain.ResumeLayout(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            iFormDialogMain.cancel();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            iFormDialogMain.finish();
        }
    }
}

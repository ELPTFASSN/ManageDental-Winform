using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ManageSoftware.CustomControl
{
    public partial class ButtonFunction : UserControl
    {
        public ButtonFunction()
        {
            InitializeComponent();
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            this.tablePanelMain.BackColor = Color.Beige;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            this.tablePanelMain.BackColor = colorOriginal;
        }

        private void mouseClick()
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageSoftware.Gui
{
    public partial class AboutMe : UserControl
    {
        private AboutMe aboutMe;
        private Timer timeClose;
        private bool flagExit = false;
        public AboutMe()
        {
            InitializeComponent();
            this.lblTimeClose.Name = "5";
            timeClose = new Timer();
            timeClose.Interval = 1000;
            timeClose.Tick += timeClose_Tick;
            timeClose.Enabled = true;
            aboutMe = this;
        }

        void timeClose_Tick(object sender, EventArgs e)
        {
            int timeSecond = Int32.Parse(lblTimeClose.Name);
            if (timeSecond % 2 != 0)
            {
                lblTimeClose.ForeColor = System.Drawing.SystemColors.ControlLight;
                lblTimeClose.BackColor = System.Drawing.Color.Crimson;
            }
            else
            {
                lblTimeClose.ForeColor = System.Drawing.Color.Crimson;
                lblTimeClose.BackColor = System.Drawing.SystemColors.ControlLight;
            }
            if (timeSecond == 0)
            {
                flagExit = true;
                this.timeClose.Enabled = false;
                ((Form)this.Parent).Close();
                this.Parent.Dispose();
                return;
            }
            lblTimeClose.Text = (timeSecond - 1) + "";
            lblTimeClose.Name = lblTimeClose.Text;
        }

        private void lblTimeClose_MouseClick(object sender, MouseEventArgs e)
        {
            flagExit = true;
            this.timeClose.Enabled = false;
            ((Form)this.Parent).Close();
            this.Parent.Dispose();
        }

        private void lblTimeClose_MouseEnter(object sender, EventArgs e)
        {
            timeClose.Enabled = false;
            lblTimeClose.Text = "X";
        }

        private void lblTimeClose_MouseLeave(object sender, EventArgs e)
        {
            if (!flagExit)
                timeClose.Enabled = true;
        }
    }
}

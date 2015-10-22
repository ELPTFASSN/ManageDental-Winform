using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSoftware.CustomControl
{
    public partial class ButtonMenuBar : UserControl
    {

        public delegate void EventHandler();
        public new event EventHandler Click;

        public ButtonMenuBar()
        {
            InitializeComponent();
            Click += delegate { };
        }        

        private void mouseEnter()
        {

            this.BackgroundImage = global::ManageSoftware.Properties.Resources.background_button_hover;
        }

        private void mouseLeave()
        {
            this.BackgroundImage = null;
        }

        public void mouseClick()
        {
            Click();
        }        

        private void lblDescriptionButton_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave();
        }

        private void lblDescriptionButton_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter();
        }

        private void lblTitleButton_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave();
        }

        private void lblTitleButton_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter();
        }

        private void ptbIcon_MouseEnter(object sender, EventArgs e)
        {
            mouseEnter();
        }

        private void ptbIcon_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave();
        }

        private void ptbIcon_Click(object sender, EventArgs e)
        {
            mouseClick();
        }

        private void lblTitleButton_Click(object sender, EventArgs e)
        {
            mouseClick();
        }

        private void lblDescriptionButton_Click(object sender, EventArgs e)
        {
            mouseClick();
        }

    }
}

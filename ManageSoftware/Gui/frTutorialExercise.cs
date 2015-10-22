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
    public partial class frTutorialExercise : Form
    {
        public frTutorialExercise()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setTitle(String title)
        {
            this.lblTitle.Text = title;
        }

    }
}

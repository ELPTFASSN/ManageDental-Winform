using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagerPartient.CustomControl
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Orange;
            this.BackColor = Color.Orange;
        }
    }
}

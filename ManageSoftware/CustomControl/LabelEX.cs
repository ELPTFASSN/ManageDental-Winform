using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoftware.CustomControl
{
    class LabelEX : System.Windows.Forms.Label
    {
        public LabelEX()
        {
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
        }
    }
}

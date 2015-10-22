using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerPartient.CustomControl
{
    class ButtonEX : System.Windows.Forms.Button
    {
        public ButtonEX()
        {
            this.Size = new System.Drawing.Size(this.Size.Width, 23);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
        }
    }
}

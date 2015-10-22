using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoftware.CustomControl
{
    class TextBoxEX : System.Windows.Forms.TextBox
    {
        private String textDefault;
        private bool clearTextDefaultForcus;

        public bool ClearTextDefaultForcus
        {
            get { return clearTextDefaultForcus; }
            set { clearTextDefaultForcus = value; }
        }

        public String TextDefault 
        {
            set 
            { 
                this.textDefault = value;
                this.Text = textDefault;
            }
            get { return this.textDefault; }
        }

        public TextBoxEX()
        {
            this.clearTextDefaultForcus = false;
            this.Size = new System.Drawing.Size(100, 23);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotFocus += (e, v) => 
            {
                if (clearTextDefaultForcus && this.Text != "" && this.ForeColor.Equals(System.Drawing.SystemColors.ControlDark))
                {                    
                    this.Text = "";
                }
                this.ForeColor = System.Drawing.SystemColors.ControlText;
            };
            this.LostFocus += (e, v) =>
            {
                if(this.Text.Equals("") && this.Text == "")
                {
                    this.ForeColor = System.Drawing.SystemColors.ControlDark;
                    this.Text = this.TextDefault;
                }                
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Communication_RS232
{
    
        public delegate void adcEvenChangeHandler (object sender, adcEvenChange e);
        public class adcEvenChange : EventArgs
        {
            public int lux1 { get; set; }
            public int lux2 { get; set; }
            public int lux3 { get; set; }
            public int lux4 { get; set; }
            public int lux5 { get; set; }
            public int lux6 { get; set; }
            public int lux7 { get; set; }
            public int lux8 { get; set; }
        }

        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
}

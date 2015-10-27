using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Communication_RS232
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //var DataLog = new StreamWriter(@"E:\DataLog.txt");
            var DataLog = new StreamWriter(DateTime.Now.ToString("yyyy+MM+dd")+".log");
            DataLog.WriteLine("               Date               Cb1          Cb2          Cb3          Cb4          Cb5          Cb6          Cb7          Cb8          \n");
            DataLog.Close();
            timer1.Interval = 10;
            timer1.Enabled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            Form1.Instance.ShowDialog();
            //Form1 form1 = new Form1();
            //form1.Show();
            //form1.adcEvenChangeHandler +=new adcEvenChangeHandler(form1_adcEvenChangeHandler);
        }
        public void GhiFile(string n)
        {
            StreamWriter f = null;
            try
            {
                if (File.Exists(DateTime.Now.ToString("yyyy+MM+dd") + ".log"))              //kiem tra xem file co ton tai ko
                {
                    f = File.AppendText(DateTime.Now.ToString("yyyy+MM+dd") + ".log"); //neu ko thi ghi noi vao cuoi file
                    f.WriteLine(n);
                }
                else
                {
                    f = File.CreateText(DateTime.Now.ToString("yyyy+MM+dd") + ".log"); //  neu file ko ton tai thi tao ra file moi
                    f.WriteLine(n);

                }
            }
            finally
            {
                if (f != null)
                    f.Close();
            }

        }
 /*
        void form1_adcEvenChangeHandler(object sender, adcEvenChange e)
        {
            txtCb1.Text = Convert.ToString(e.lux1);
            Cb1SetText(Convert.ToString(e.lux1));
            Cb2SetText(Convert.ToString(e.lux2));
            Cb3SetText(Convert.ToString(e.lux3));
            Cb4SetText(Convert.ToString(e.lux4));
            Cb5SetText(Convert.ToString(e.lux5));
            Cb6SetText(Convert.ToString(e.lux6));
            Cb7SetText(Convert.ToString(e.lux7));
            Cb8SetText(Convert.ToString(e.lux8));
            
        }

        // Hàm để hiển thị vào textbox 1
        private void Cb1SetText(string text)
        {
            if (this.txtCb1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb1SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb1.Text ="";
                this.txtCb1.Text += text;
            }
        }
        // Hàm để hiển thị vào textbox 2
        private void Cb2SetText(string text)
        {
            if (this.txtCb2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb2SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb2.Text = "";
                this.txtCb2.Text += text;
            }
        }
        // Hàm để hiển thị vào textbox 3
        private void Cb3SetText(string text)
        {
            if (this.txtCb3.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb3SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb3.Text = "";
                this.txtCb3.Text += text;
            }
        }
        // Hàm để hiển thị vào textbox 4
        private void Cb4SetText(string text)
        {
            if (this.txtCb4.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb4SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb4.Text = "";
                this.txtCb4.Text += text;
            }
        }
        // Hàm để hiển thị vào textbox 5
        private void Cb5SetText(string text)
        {
            if (this.txtCb5.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb5SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb5.Text = "";
                this.txtCb5.Text += text;
            }
        }
        // Hàm để hiển thị vào textbox 1
        private void Cb6SetText(string text)
        {
            if (this.txtCb6.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb6SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb6.Text = "";
                this.txtCb6.Text += text;
            }
        }
        // Hàm để hiển thị vào textbox 7
        private void Cb7SetText(string text)
        {
            if (this.txtCb7.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb7SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb7.Text = "";
                this.txtCb7.Text += text;
            }
        }
        // Hàm để hiển thị vào textbox 8
        private void Cb8SetText(string text)
        {
            if (this.txtCb8.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Cb8SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Xóa đi dòng dữ liệu trước.
                this.txtCb8.Text = "";
                this.txtCb8.Text += text;
            }
        }
  */
        private void button1_Click(object sender, EventArgs e)
        {
            Graph.Instance.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtCb1.Text = Convert.ToString(CommonData.lux1);
            txtCb2.Text = Convert.ToString(CommonData.lux2);
          
            GhiFile(Convert.ToString(DateTime.Now) + "    "+txtCb1.Text + "     " + txtCb2.Text + "\n");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCb1_TextChanged(object sender, EventArgs e)
        {

        }

      



      
    }
}

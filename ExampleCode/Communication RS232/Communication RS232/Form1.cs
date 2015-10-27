using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Thêm 3 em này vào là OK, để sài SerialPort
using System.IO;
using System.IO.Ports;
using System.Xml;
// Bắt đầu code
namespace Communication_RS232
{
    public partial class Form1 : Form
    {
        // Tu them vao
        string TemptInputData = String.Empty;
        SerialPort P = new SerialPort(); // Khai báo 1 Object SerialPort mới.
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.

        // Using this method ensure that only one form1 was opened
        public static Form1 instance;
        public static Form1 Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }

        public event adcEvenChangeHandler adcEvenChangeHandler = null;
        
        public Form1()
        {
            InitializeComponent();
            // Cài đặt các thông số cho COM
            // Mảng string port để chứ tất cả các cổng COM đang có trên máy tính
            string[] ports = SerialPort.GetPortNames();

            // Thêm toàn bộ các COM đã tìm được vào combox cbCom
            cbCom.Items.AddRange(ports); // Sử dụng AddRange thay vì dùng foreach
            P.ReadTimeout = 1000;
            // Khai báo hàm delegate bằng phương thức DataReceived của Object SerialPort;
            // Cái này khi có sự kiện nhận dữ liệu sẽ nhảy đến phương thức DataReceive
            // Nếu ko hiểu đoạn này bạn có thể tìm hiểu về Delegate, còn ko cứ COPY . Ko cần quan tâm
            P.DataReceived += new SerialDataReceivedEventHandler(DataReceive);

            // Cài đặt cho BaudRate
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbRate.Items.AddRange(BaudRate);

            // Cài đặt cho DataBits
            string[] Databits = { "6", "7", "8" };
            cbBits.Items.AddRange(Databits);

            //Cho Parity
            string[] Parity = { "None", "Odd", "Even" };
            cbParity.Items.AddRange(Parity);

            //Cho Stop bit
            string[] stopbit = { "1", "1.5", "2" };
            cbBit.Items.AddRange(stopbit);
            // Mấy cái này khá đơn giản, bạn đừng hỏi vì sao.  cứ COPY paste cho nhanh. :D
        }
        private void cbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P.IsOpen)
            {
                P.Close(); // Nếu đang mở Port thì phải đóng lại
            }
            P.PortName = cbCom.SelectedItem.ToString(); // Gán PortName bằng COM đã chọn 
        }

        private void cbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P.IsOpen)
            {
                P.Close();
            }
            P.BaudRate = Convert.ToInt32(cbRate.Text);
        }

        private void cbBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P.IsOpen)
            {
                P.Close();
            }
            P.DataBits = Convert.ToInt32(cbBits.Text);
        }

        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P.IsOpen)
            {
                P.Close();
            }
            // Với thằng Parity hơn lằng nhằng. Nhưng cũng OK thôi. ^_^
            switch (cbParity.SelectedItem.ToString())
            {
                case "Odd":
                    P.Parity = Parity.Odd;
                    break;
                case "None":
                    P.Parity = Parity.None;
                    break;
                case "Even":
                    P.Parity = Parity.Even;
                    break;
            }
        }

        private void cbBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (P.IsOpen)
            {
                P.Close();
            }
            switch (cbBit.SelectedItem.ToString())
            {
                case "1":
                    P.StopBits = StopBits.One;
                    break;
                case "1.5":
                    P.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    P.StopBits = StopBits.Two;
                    break;
            }
        }
        // Hàm này được sự kiện nhận dử liệu gọi đến. Mục đích để hiển thị thôi
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
                InputData = string.Empty; // Xóa lại chuỗi đã lưu lại trước đó để lấy dữ liệu mới.
                InputData = P.ReadExisting();
                //InputData = P.ReadLine();
                if (InputData != String.Empty)
                {
                    // Ghi dữ liệu vào ô textbox
                    //txtkq.Text = "";
                    //SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.
                    // Kiểm tra xem đã gặp ký tự kết thúc chuỗi chưa, Nếu chưa thì thực hiện
                    if (InputData != "X")
                    {
                        for (int i = 0; i < InputData.Length; i++)
                        {
                            // Lưu tất cả dữ liệu vào biến tạm thời.
                            TemptInputData += InputData[i];
                        }
                    }
                    // Nếu đã gặp ký tự kết thúc thì gọi hàm xử lý dữ liệu tạm
                    else
                    {
                        //SetText("");
                        //txtkq.Text = "";
                        //SetText(TemptInputData);
                        // Đưa dữ liệu vào hàm xử lý để tách dữ liệu
                        //CommonData.IsProcessing = true;
                        HandleData(TemptInputData);
                    }
                }
            }

       
        // Hàm của em nó là ở đây. Đừng hỏi vì sao lại thế.
        //private void SetText(string text)
        //{
        //    if (this.txtkq.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else this.txtkq.Text += text;

        //}
        // Toàn bộ cái này bạn nên COPY, nó cũng làm tôi đau đầu. :D
        // Hàm xử lý chuỗi dữ liệu tạm thu được
        private void HandleData(string data)
        {
            string ADC = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 'A')
                {
                    // Kiểm tra xem 4 ký tự tiếp theo có phải là số không
                    if (Char.IsDigit(data[i + 1]) && Char.IsDigit(data[i + 2]) && Char.IsDigit(data[i + 3]) && Char.IsDigit(data[i + 4]))
                    {
                        // Nếu là số thì gắn vào chuỗi tạm ADC
                        ADC = ADC + data[i + 1] + data[i + 2] + data[i + 3] + data[i + 4];
                        // Chuyển chuỗi tạm về dạng int
                        int adc = int.Parse(ADC);
                        // Gọi hàm tính lux
                        int lux = ToLux(adc);
                        // Gán giá trị này vào trong CommonData
                        CommonData.lux1 = lux;
                    }
                    ADC = string.Empty;
                }
                if (data[i] == 'B')
                {
                    // Kiểm tra xem 4 ký tự tiếp theo có phải là số không
                    if (Char.IsDigit(data[i + 1]) && Char.IsDigit(data[i + 2]) && Char.IsDigit(data[i + 3]) && Char.IsDigit(data[i + 4]))
                    {
                        // Nếu là số thì gắn vào chuỗi tạm ADC
                        ADC = ADC + data[i + 1] + data[i + 2] + data[i + 3] + data[i + 4];
                        // Chuyển chuỗi tạm về dạng int
                        int adc = int.Parse(ADC);
                        // Gọi hàm tính lux
                        int lux = ToLux(adc);
                        // Gán giá trị này vào trong CommonData
                        CommonData.lux2 = lux;
                    }
                    ADC = string.Empty;
                }
               

                // Xóa biến lưu tạm dữ liệu để đón đoạn dữ liệu mới.
                TemptInputData = string.Empty; 

                // Xét sự kiện có thay đổi dữ liệu xảy ra
                if (adcEvenChangeHandler != null)
                {
                    // Truyền các dạng dữ liệu vào Event
                    adcEvenChangeHandler(this, new adcEvenChange { lux1 = CommonData.lux1, lux2 = CommonData.lux2 });
                }

                //P.Write("123qwewr");

            }
        }
        // Đến hàm gửi data xuống COM
        //private void btSend_Click(object sender, EventArgs e)
        //{
        //    if (P.IsOpen)
        //    {
        //        if (txtSend.Text == "") MessageBox.Show("Chưa có dữ liệu!", "Thông Báo");
        //        else P.Write(txtSend.Text);
        //    }
        //    else MessageBox.Show("COM chưa mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    txtSend.Clear();
        //}
        // Đến đây coi như mọi việc đã ngon lành cành đào rồi.
        // Để chọn tiện trong việc Test thì chúng ta sẽ làm thêm bước nữa. cho mấy cái thông số
        // hay dùng được chọn. Ko cần thiết nếu bạn cảm thấy ko cần.

        // Hàm chuyển giá trị ADC nhận được sang giá trị lux
        private int ToLux(int adc)
        {
            //double  x = (3*10^9)/(10240/adc - 5);
            //return Convert.ToInt32(Math.Sqrt(x)); //Math.Sqrt(x);
            int lux = adc;
            return lux;

        }

        private void Form1_Load(object sender, EventArgs e) // sẽ được gọi khi mở chương trình.
        {
            //timer1.Enabled = true;
            //timer1.Interval = 2000;
            cbCom.SelectedIndex = 0;
            cbRate.SelectedIndex = 3; // 9600
            cbBits.SelectedIndex = 2; // 8
            cbParity.SelectedIndex = 0; // None
            cbBit.SelectedIndex = 0; // None
            // Hiện thị Status cho Pro tí
            status.Text = "Hãy chọn 1 cổng COM để kết nối.";
        }

        private void btKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                P.Open();
                btNgat.Enabled = true;
                btKetNoi.Enabled = false;
                // Hiện thị Status
                status.Text = "Đang kết nối với cổng " + cbCom.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Không kết nối được.", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNgat_Click(object sender, EventArgs e)
        {
            P.Close();
            btKetNoi.Enabled = true;
            btNgat.Enabled = false;
            // Hiện thị Status
            //status.Text = "Đã Ngắt Kết Nối";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn thực sự muốn thoát", "BKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("Cảm ơn bạn đã sử dụng chương trình", "BKAT");
                this.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm.ShowDialog();
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph.Instance.ShowDialog();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    //txtkq.Text = "";
        //}

    }
}

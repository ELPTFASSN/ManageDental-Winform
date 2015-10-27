using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Khai báo thêm thư viện vẽ đồ thị
using ZedGraph;

namespace Communication_RS232
{
    public partial class Graph : Form
    {
        // Khai báo 1 biến thời gian
        int TickStart = 0;

        public static Graph instance;
        public static Graph Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Graph();
                }
                return instance;
            }
        }

        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // Bật timer1 luôn.
            timer1.Enabled = true;
           
            // Khởi tạo các nút checkbox
            cbxCb1.Checked = true;
            cbxCb2.Checked = false;
          

            // Khai báo kiểu đồ thị được dùng
            GraphPane myGraph = zedGraphControl1.GraphPane;
            // Khai báo các hiển thị trên đồ thị
            myGraph.Title.Text = "NHIỆT ĐỘ GRAPH ";
            myGraph.XAxis.Title.Text = "Timer";
            myGraph.YAxis.Title.Text = "  ";

            // Khai báo 8 list(8 giá trị của cảm biến) để vẽ đồ thị.
            // 1 List chứa 1400 điểm
            RollingPointPairList adc1 = new RollingPointPairList(1400);
            RollingPointPairList adc2 = new RollingPointPairList(1400);
           

            // Định nghĩa Curve để vẽ
            LineItem Curve1 = myGraph.AddCurve("NHIỆT ĐỘ", adc1, Color.OrangeRed, SymbolType.None);
            LineItem Curve2 = myGraph.AddCurve("        ", adc2, Color.Aqua, SymbolType.None);
          

            // Khoảng cách lấy giá trị là 10ms 1 lần
            timer1.Interval = 10;

            // Định nghĩa hiển thị cho trục thời gian
            myGraph.XAxis.Scale.Min = 0 ;           // Giá trị bắt đầu là 0
            myGraph.XAxis.Scale.Max = 30 ;          // Giá trị lớn nhất là 30
            myGraph.XAxis.Scale.MinorStep = 1;      // Đơn vị chia nhỏ nhất là 1
            myGraph.XAxis.Scale.MajorStep = 5;      // Đơn vị chia lớn nhất 5

            // Gọi hàm xác định cỡ trục
            zedGraphControl1.AxisChange();
        }

        // Xây dựng hàm vẽ
        public void Draw()
        {
            // Kiểm tra không các đường Curve đã được khởi tạo hay chưa
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            // Đưa về điểm xuất phát
            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            LineItem curve2 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
           

            // Kiểm tra đã thành công hay chưa
            if (curve1 == null)
                return;
            if (curve2 == null)
                return;
           

            // Đoạn này chưa hiểu lắm, không biết lấy cái ni làm chi  nựa??
            // Get the PointPairList
            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            

            // Kiểm tra đã thành công hay chưa
            if (list1 == null)
                return;
            if (list2 == null)
                return;
           
            
            // Tính thời gian được tính bằng ms
            double time = (Environment.TickCount - TickStart) / 1000.0;
           
            // Kiểm tra trạng thái của các nút check box có được tick hay không để vẽ
            // Nếu không Tick thì cho vẽ đường trục hoành
            if (cbxCb1.Checked == true)
            {
                list1.Add(time, CommonData.lux1);
            }
            else
                list1.Add(time, 0);

            if (cbxCb2.Checked == true)
            {
                list2.Add(time, CommonData.lux2);
            }
            else
                list2.Add(time, 0);

           

            // Hiển thị đồ thị, dịch chuyển đồ thị khi thời gian chạy dài
            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                // Dịch chuyển đồ thị sang trái
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30.0;
            }

            // Vẽ đồ thị
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            CommonData.IsProcessing = false;

        }

        //  Hàm vẽ khi mà xuất hiện 1 sự kiện timer1_stick
        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        // Định nghĩa sự kiện khi nhấn nút Pause
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Dừng")
            {
                // Dừng việc vẽ đồ thị lại
                timer1.Enabled = false;
                btnPause.Text = "Tiếp";
            }
            else
            {
                // Tiếp tục vẽ đồ thị
                timer1.Enabled = true;
                btnPause.Text = "Dừng";
            }
        }

        // Định nghĩa sự kiện khi nhấn nút Hide
        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

      
      

    }
}

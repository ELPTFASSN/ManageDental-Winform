using ManageSoftware.ModelManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageSoftware.Gui
{
    public partial class ConfigPractice : Form
    {
        public delegate void ChangeConfig(object _object);
        public event  ChangeConfig EventConfig;
        private tb_config_practice config;

        public tb_config_practice Config
        {
            get { return config; }
            set { 
                config = value;
                SetData(config);
            }
        }

        public ConfigPractice()
        {
            InitializeComponent();
            if (SettingPortCOM.Instance.SerialPort.IsOpen)
                lblConnectionStatus.Text = "Đang kết nối " + SettingPortCOM.Instance.SerialPort.PortName;
            else lblConnectionStatus.Text = "Ngắt kết nối";
        }

        public void SetData(tb_config_practice Config)
        {
            txtLucNang.Text = Config.LiftingPower + "";
            txtThoiGianTap.Text = Config.RunTime + "";
            txtTocDoChay.Text = Config.Rate + "";
            TimeSpan timeRun = TimeSpan.FromMinutes(Double.Parse(txtThoiGianTap.Text));
            lblTimeLife.Text = timeRun + "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông số chỉnh sửa hay thông số mặc định
            if (!txtLucNang.Text.Equals(Config.LiftingPower.ToString()) || !txtThoiGianTap.Text.Equals(Config.RunTime.ToString()) || !txtTocDoChay.Text.Equals(Config.Rate.ToString()))
            {
                tb_config_practice cpra = new tb_config_practice()
                {
                    LiftingPower = Int32.Parse(txtLucNang.Text),
                    RunTime = Int32.Parse(txtThoiGianTap.Text),
                    Rate = Int32.Parse(txtTocDoChay.Text)
                };
                EventConfig(cpra);
            }

            
            // Thực hiện truyền dữ liệu xuống cổng COM R232
        }

        private void txtThoiGianTap_SelectedItemChanged(object sender, EventArgs e)
        {
            TimeSpan timeRun = TimeSpan.FromMinutes(Double.Parse(txtThoiGianTap.Text));
            lblTimeLife.Text = timeRun + "";
        }
    }
}

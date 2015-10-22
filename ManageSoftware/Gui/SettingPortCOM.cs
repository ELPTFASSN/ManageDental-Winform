using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using ManageSoftware.Core;

namespace ManageSoftware.Gui
{
    public partial class SettingPortCOM : UserControl, IFormDialogMain
    {
        private SerialPort serialPort;
        private string InputData = String.Empty;
        private string TemptInputData = String.Empty;
        private static SettingPortCOM instance;

        public static SettingPortCOM Instance
        {
            get 
            {
                if (instance == null)
                    instance = new SettingPortCOM();
                return SettingPortCOM.instance; 
            }            
        }

        public SerialPort SerialPort
        {
            get { return serialPort; }
            set { serialPort = value; }
        }

        public SettingPortCOM()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            serialPort = new SerialPort();

            string[] baudrate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbBaudRate.Items.AddRange(baudrate);

            string[] databits = { "6", "7", "8" };
            cbDataBits.Items.AddRange(databits);

            string[] parity = { "None", "Odd", "Even" };
            cbParity.Items.AddRange(parity);

            string[] stopbit = { "1", "1.5", "2" };
            cbStopBits.Items.AddRange(stopbit);

            string[] ports = SerialPort.GetPortNames();
            cbPortCOM.Items.AddRange(ports);

            serialPort.ReadTimeout = 2000;
            serialPort.WriteTimeout = 500;
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            InputData = string.Empty;
            InputData = SerialPort.ReadExisting();
            if (InputData != String.Empty)
            {
                if (InputData != "X")
                {
                    for (int i = 0; i < InputData.Length; i++)
                    {
                        TemptInputData += InputData[i];
                    }
                }
                else
                {
                    HandleData(TemptInputData);
                }
            }
        }

        private void HandleData(string data)
        {

        }

        private void GetData()
        {
            SerialPort.PortName = cbPortCOM.SelectedItem.ToString();
            SerialPort.BaudRate = Convert.ToInt32(cbBaudRate.SelectedItem.ToString());
            SerialPort.DataBits = Convert.ToInt32(cbDataBits.SelectedItem.ToString());
            SerialPort.Handshake = Handshake.None;

            switch (cbStopBits.SelectedItem.ToString())
            {
                case "1":
                    SerialPort.StopBits = StopBits.One;
                    break;
                case "1.5":
                    SerialPort.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    SerialPort.StopBits = StopBits.Two;
                    break;
            }

            switch (cbParity.SelectedItem.ToString())
            {
                case "Odd":
                    SerialPort.Parity = Parity.Odd;
                    break;
                case "None":
                    SerialPort.Parity = Parity.None;
                    break;
                case "Even":
                    SerialPort.Parity = Parity.Even;
                    break;
            }
        }

        public void cancel()
        {
            try
            {
                if ((SerialPort.IsOpen))
                {
                    SerialPort.Close();
                    EnableComponents(true);
                }
                else
                    this.ParentForm.Close();
            }
            catch
            {
                MessageBox.Show("Không ngắt được kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        public void finish()
        {
            try
            {
                GetData();
                if (!(SerialPort.IsOpen))
                {
                    SerialPort.Open();
                    EnableComponents(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được ! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EnableComponents(bool value)
        {
            cbPortCOM.Enabled = value;
            cbBaudRate.Enabled = value;
            cbDataBits.Enabled = value;
            cbStopBits.Enabled = value;
            cbParity.Enabled = value;
        }
    }
}

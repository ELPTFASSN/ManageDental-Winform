using System;
using System.Drawing;
using System.Windows.Forms;
using ManagerPartient.CustomControl;
using ManagerPartient.Core;
#region Assembly mscorlib.dll, v4.0.0.0
// C:\Program Files\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5\mscorlib.dll
#endregion

namespace ManagerPartient.Gui
{
    public partial class PanelHome : UserControl, IFormPanelChild
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point pnt);
        private MouseMoveMessageFilter mouseMessageFilter;
        public event DisplayPanelHander DisplayPanelEvent;

        public PanelHome()
        {
            InitializeComponent();
            SettingForm();
            this.mouseMessageFilter = new MouseMoveMessageFilter();
            this.mouseMessageFilter.TargetForm = this;
            StartFiltering(this.mouseMessageFilter);

            Timer updateTimeSystem = new Timer();
            updateTimeSystem.Interval = 500;
            updateTimeSystem.Tick += updateTimeSystem_Tick;
            updateTimeSystem.Enabled = true;
        }

        /**
         *Business Methods
         **/
        private void StopFiltering(IMessageFilter value)
        {
            Application.RemoveMessageFilter(value);
        }

        private void StartFiltering(IMessageFilter value)
        {
            StopFiltering(value);
            Application.AddMessageFilter(value);
        }

        public new void Hide()
        {
            base.Hide();
            StopFiltering(this.mouseMessageFilter);
        }

        public new void Show()
        {
            base.Show();
            StartFiltering(this.mouseMessageFilter);
        }

        public void SettingForm()
        {
            this.Dock = DockStyle.Fill;
            this.Name = typeof(PanelHome).Name;
        }

        /**
         ************Event Components*******************
         **/
        #region Event hander for components

        private void updateTimeSystem_Tick(object sender, EventArgs e)
        {
            lblTimeSystem.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
            lblDateSystem.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
        }

        #endregion

        /**
         ************Event Button Function*******************
         **/ 
        #region Event hander for button function

        private void handleBtnTienIch()
        {
            DisplayPanelEvent("Backup");
        }

        private void handleBtnQuanLyVatTu()
        {
            DisplayPanelEvent("");
        }

        private void handleBtnBaoCaoThongKe()
        {
            DisplayPanelEvent("");
        }

        private void handleBtnQuanLyNhanVien()
        {
            DisplayPanelEvent("");
        }

        private void handleBtnQuanLyBenhNhan()
        {
            DisplayPanelEvent("");
        }

        private void handleBtnHieuThuocNha()
        {
            DisplayPanelEvent("");
        }

        private void handleBtnDanhMucKhamBenh()
        {
            DisplayPanelEvent("");
        }

        private void handleBtnSoKhamBenh()
        {
            DisplayPanelEvent(typeof(PanelListPatient).Name);
        }

        #endregion

        class MouseMoveMessageFilter : IMessageFilter
        {
            public PanelHome TargetForm { get; set; }
            //ButtonFunction buttonTemp = null;
            public bool PreFilterMessage(ref Message m)
            {
                // Vị trí con trỏ chuột so với tablePanelRight
                Point mousePosition = this.TargetForm.tablePanelRight.PointToClient(MousePosition);
                // Kiểm tra vị trí con trỏ chuột này có nằm trong tablePanelRight không?
                if (this.TargetForm.tablePanelRight.ClientRectangle.Contains(mousePosition))
                {
                    // Bắt đầu Message
                    int numMsg = m.Msg;
                    // Message chuột di chuyển
                    if (numMsg == 0x0200 /*WM_MOUSEMOVE*/)
                    {
                        
                        Point p = this.TargetForm.PointToClient(MousePosition);
                        IntPtr hWnd = WindowFromPoint(MousePosition);
                        if (hWnd != IntPtr.Zero)
                        {
                            Control ctl = Control.FromHandle(hWnd);

                            if (ctl != null)
                            {
                                if (this.TargetForm.btnBaoCaoThongKe.ClientRectangle.Contains(this.TargetForm.btnBaoCaoThongKe.PointToClient(MousePosition)))
                                {
                                    this.TargetForm.btnBaoCaoThongKe.TablePanelMainBackColor = Color.Orange;
                                }
                                else
                                {
                                    this.TargetForm.btnBaoCaoThongKe.TablePanelMainBackColor = this.TargetForm.btnBaoCaoThongKe.ColorOriginal;
                                    if (this.TargetForm.btnDanhMucKhamBenh.ClientRectangle.Contains(this.TargetForm.btnDanhMucKhamBenh.PointToClient(MousePosition)))
                                    {
                                        this.TargetForm.btnDanhMucKhamBenh.TablePanelMainBackColor = Color.Orange;
                                    }
                                    else
                                    {
                                        this.TargetForm.btnDanhMucKhamBenh.TablePanelMainBackColor = this.TargetForm.btnDanhMucKhamBenh.ColorOriginal;
                                        if (this.TargetForm.btnHieuThuocNha.ClientRectangle.Contains(this.TargetForm.btnHieuThuocNha.PointToClient(MousePosition)))
                                        {
                                            this.TargetForm.btnHieuThuocNha.TablePanelMainBackColor = Color.Orange;
                                        }
                                        else
                                        {
                                            this.TargetForm.btnHieuThuocNha.TablePanelMainBackColor = this.TargetForm.btnHieuThuocNha.ColorOriginal;
                                            if (this.TargetForm.btnQuanLyBenhNhan.ClientRectangle.Contains(this.TargetForm.btnQuanLyBenhNhan.PointToClient(MousePosition)))
                                            {
                                                this.TargetForm.btnQuanLyBenhNhan.TablePanelMainBackColor = Color.Orange;
                                            }
                                            else
                                            {
                                                this.TargetForm.btnQuanLyBenhNhan.TablePanelMainBackColor = this.TargetForm.btnQuanLyBenhNhan.ColorOriginal;
                                                if (this.TargetForm.btnQuanLyNhanVien.ClientRectangle.Contains(this.TargetForm.btnQuanLyNhanVien.PointToClient(MousePosition)))
                                                {
                                                    this.TargetForm.btnQuanLyNhanVien.TablePanelMainBackColor = Color.Orange;
                                                }
                                                else
                                                {
                                                    this.TargetForm.btnQuanLyNhanVien.TablePanelMainBackColor = this.TargetForm.btnQuanLyNhanVien.ColorOriginal;
                                                    if (this.TargetForm.btnQuanLyVatTu.ClientRectangle.Contains(this.TargetForm.btnQuanLyVatTu.PointToClient(MousePosition)))
                                                    {
                                                        this.TargetForm.btnQuanLyVatTu.TablePanelMainBackColor = Color.Orange;
                                                    }
                                                    else
                                                    {
                                                        this.TargetForm.btnQuanLyVatTu.TablePanelMainBackColor = this.TargetForm.btnQuanLyVatTu.ColorOriginal;
                                                        if (this.TargetForm.btnSoKhamBenh.ClientRectangle.Contains(this.TargetForm.btnSoKhamBenh.PointToClient(MousePosition)))
                                                        {
                                                            this.TargetForm.btnSoKhamBenh.TablePanelMainBackColor = Color.Orange;
                                                        }
                                                        else
                                                        {
                                                            this.TargetForm.btnSoKhamBenh.TablePanelMainBackColor = this.TargetForm.btnSoKhamBenh.ColorOriginal;
                                                            if (this.TargetForm.btnTienIch.ClientRectangle.Contains(this.TargetForm.btnTienIch.PointToClient(MousePosition)))
                                                            {
                                                                this.TargetForm.btnTienIch.TablePanelMainBackColor = Color.Orange;
                                                            }
                                                            else
                                                            {
                                                                this.TargetForm.btnTienIch.TablePanelMainBackColor = this.TargetForm.btnTienIch.ColorOriginal;                                                                
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                //String nameButton = "";
                                //Control child = ctl;
                                //while (child != null)
                                //{
                                //    if (child.Name.Contains("btn"))
                                //    {
                                //        nameButton = child.Name;
                                //        break;
                                //    }
                                //    else
                                //    {
                                //        nameButton = "";
                                //        if (child.Name == "tablePanelRight")
                                //        {                                            
                                //            break;
                                //        }
                                //    }

                                //    child = child.Parent;
                                //}

                                //if(nameButton != "")
                                //{
                                //    ButtonFunction button = (ButtonFunction)child;
                                //    button.TablePanelMainBackColor = Color.Orange;
                                //    buttonTemp = button;
                                //}
                                //else
                                //{
                                    
                                //    if (buttonTemp != null)
                                //    {
                                //        buttonTemp.TablePanelMainBackColor = Color.Wheat;
                                //    }
                                //}
                            }                            
                        }
                    }
                    // Message chuột trái ấn
                    if (numMsg == 0x0202 /*WM_LBUTTONUP*/)
                    {
                        IntPtr hWnd = WindowFromPoint(MousePosition);
                        if (hWnd != IntPtr.Zero)
                        {
                            Control ctl = Control.FromHandle(hWnd);
                            if (ctl != null)
                            {
                                String nameButton = "";
                                Control child = ctl;
                                while(child != null)
                                {
                                    if(child.Name.Contains("btn")) 
                                    {
                                        nameButton = child.Name;
                                        break;
                                    } 
                                    else
                                    {
                                        if (child.Name == "tablePanelRight")
                                        {
                                            nameButton = "";
                                            break;
                                        }
                                    }                                    
                                    
                                    child = child.Parent;
                                }

                                if (nameButton != "")
                                {
                                    switch (nameButton)
                                    {
                                        case "btnTienIch": 
                                            {
                                                this.TargetForm.handleBtnTienIch();
                                                break; 
                                            }
                                        case "btnBaoCaoThongKe":
                                            {
                                                this.TargetForm.handleBtnBaoCaoThongKe();
                                                break;
                                            }
                                        case "btnQuanLyVatTu":
                                            {
                                                this.TargetForm.handleBtnQuanLyVatTu();
                                                break;
                                            }
                                        case "btnQuanLyNhanVien":
                                            {
                                                this.TargetForm.handleBtnQuanLyNhanVien();
                                                break;
                                            }
                                        case "btnQuanLyBenhNhan":
                                            {
                                                this.TargetForm.handleBtnQuanLyBenhNhan();
                                                break;
                                            }
                                        case "btnHieuThuocNha":
                                            {
                                                this.TargetForm.handleBtnHieuThuocNha();
                                                break;
                                            }
                                        case "btnDanhMucKhamBenh":
                                            {
                                                this.TargetForm.handleBtnDanhMucKhamBenh();
                                                break;
                                            }
                                        case "btnSoKhamBenh":
                                            {
                                                this.TargetForm.handleBtnSoKhamBenh();
                                                break;
                                            }
                                        default: break;
                                            
                                    }
                                }
                            }                                                   
                        }
                    }
                }
                else
                {
                    foreach (Control c in this.TargetForm.tablePanelRight.Controls)
                    {
                        ButtonFunction btn = (ButtonFunction)c;
                        btn.TablePanelMainBackColor = btn.ColorOriginal;
                    }
                }               
                return false;
            }
        }
        
    }
}

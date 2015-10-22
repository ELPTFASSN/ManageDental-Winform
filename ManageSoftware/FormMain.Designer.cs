using ManageSoftware.CustomControl;
using ManageSoftware.Gui;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace ManageSoftware
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenuButton = new System.Windows.Forms.Panel();
            this.btnQuanLyPhongKham = new ManageSoftware.CustomControl.ButtonMenuBar();
            this.btnThietLapChung = new ManageSoftware.CustomControl.ButtonMenuBar();
            this.btnTiepNhanDatHen = new ManageSoftware.CustomControl.ButtonMenuBar();
            this.btnHoSoBenhNhan = new ManageSoftware.CustomControl.ButtonMenuBar();
            this.panelPtrBoxIcon = new System.Windows.Forms.Panel();
            this.ptrBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuBottomBar = new System.Windows.Forms.MenuStrip();
            this.menuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItem2_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_SaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_KhoiPhuc = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSeparatorSubHeThong_1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripItemSub1_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItem3_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_NgheNghiep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_BenhLy = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSeparatorSubDanhMuc_1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripItemSub1_Thuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_MauDonThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSeparatorSubDanhMuc_2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripItemSub1_NhomThuThuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_ThuThuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_MauDotKham = new System.Windows.Forms.ToolStripMenuItem();
            this.stripSeparatorSubDanhMuc_3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripItemSub1_ChuanDoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItem4_ChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_HoSoBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_LichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItem5_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_VeChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSub1_HuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelNaviBar = new System.Windows.Forms.Panel();
            this.lblNaviBar3 = new System.Windows.Forms.Label();
            this.btnBenhNhanMoi = new System.Windows.Forms.Button();
            this.lblNaviBar2 = new System.Windows.Forms.Label();
            this.lblNaviBar1 = new System.Windows.Forms.Label();
            this.panelMenuButton.SuspendLayout();
            this.panelPtrBoxIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBoxIcon)).BeginInit();
            this.menuBottomBar.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelNaviBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuButton
            // 
            this.panelMenuButton.BackColor = System.Drawing.Color.Orange;
            this.panelMenuButton.Controls.Add(this.btnQuanLyPhongKham);
            this.panelMenuButton.Controls.Add(this.btnThietLapChung);
            this.panelMenuButton.Controls.Add(this.btnTiepNhanDatHen);
            this.panelMenuButton.Controls.Add(this.btnHoSoBenhNhan);
            this.panelMenuButton.Controls.Add(this.panelPtrBoxIcon);
            this.panelMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuButton.Location = new System.Drawing.Point(0, 0);
            this.panelMenuButton.Name = "panelMenuButton";
            this.panelMenuButton.Size = new System.Drawing.Size(1008, 69);
            this.panelMenuButton.TabIndex = 0;
            // 
            // btnQuanLyPhongKham
            // 
            this.btnQuanLyPhongKham.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLyPhongKham.ImageIconButton = ((System.Drawing.Image)(resources.GetObject("btnQuanLyPhongKham.ImageIconButton")));
            this.btnQuanLyPhongKham.Location = new System.Drawing.Point(481, 1);
            this.btnQuanLyPhongKham.Name = "btnQuanLyPhongKham";
            this.btnQuanLyPhongKham.Size = new System.Drawing.Size(250, 65);
            this.btnQuanLyPhongKham.TabIndex = 11;
            this.btnQuanLyPhongKham.TextDescriptionButton = "Quản lý thiết lập các thiết bị ";
            this.btnQuanLyPhongKham.TextTitleButton = "Quản lý kết nối";
            this.btnQuanLyPhongKham.Click += new ManageSoftware.CustomControl.ButtonMenuBar.EventHandler(this.btnQuanLyPhongKham_Click);
            // 
            // btnThietLapChung
            // 
            this.btnThietLapChung.BackColor = System.Drawing.Color.Transparent;
            this.btnThietLapChung.ImageIconButton = ((System.Drawing.Image)(resources.GetObject("btnThietLapChung.ImageIconButton")));
            this.btnThietLapChung.Location = new System.Drawing.Point(731, 1);
            this.btnThietLapChung.Name = "btnThietLapChung";
            this.btnThietLapChung.Size = new System.Drawing.Size(250, 65);
            this.btnThietLapChung.TabIndex = 10;
            this.btnThietLapChung.TextDescriptionButton = "Cấu hình thiết lập phần mềm";
            this.btnThietLapChung.TextTitleButton = "Thiết lập chung";
            // 
            // btnTiepNhanDatHen
            // 
            this.btnTiepNhanDatHen.BackColor = System.Drawing.Color.Transparent;
            this.btnTiepNhanDatHen.ImageIconButton = ((System.Drawing.Image)(resources.GetObject("btnTiepNhanDatHen.ImageIconButton")));
            this.btnTiepNhanDatHen.Location = new System.Drawing.Point(231, 1);
            this.btnTiepNhanDatHen.Name = "btnTiepNhanDatHen";
            this.btnTiepNhanDatHen.Size = new System.Drawing.Size(250, 65);
            this.btnTiepNhanDatHen.TabIndex = 9;
            this.btnTiepNhanDatHen.TextDescriptionButton = "Danh sách bài tập và cấu hình";
            this.btnTiepNhanDatHen.TextTitleButton = "Bài tập và thiết lập";            
            // 
            // btnHoSoBenhNhan
            // 
            this.btnHoSoBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnHoSoBenhNhan.ImageIconButton = ((System.Drawing.Image)(resources.GetObject("btnHoSoBenhNhan.ImageIconButton")));
            this.btnHoSoBenhNhan.Location = new System.Drawing.Point(3, 1);
            this.btnHoSoBenhNhan.Name = "btnHoSoBenhNhan";
            this.btnHoSoBenhNhan.Size = new System.Drawing.Size(228, 65);
            this.btnHoSoBenhNhan.TabIndex = 8;
            this.btnHoSoBenhNhan.TextDescriptionButton = "Danh sách CN tập luyện";
            this.btnHoSoBenhNhan.TextTitleButton = "Cá nhân rèn luyện";
            this.btnHoSoBenhNhan.Click += new ManageSoftware.CustomControl.ButtonMenuBar.EventHandler(this.btnHoSoBenhNhan_Click);
            // 
            // panelPtrBoxIcon
            // 
            this.panelPtrBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelPtrBoxIcon.Controls.Add(this.ptrBoxIcon);
            this.panelPtrBoxIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPtrBoxIcon.Location = new System.Drawing.Point(943, 0);
            this.panelPtrBoxIcon.Name = "panelPtrBoxIcon";
            this.panelPtrBoxIcon.Padding = new System.Windows.Forms.Padding(10);
            this.panelPtrBoxIcon.Size = new System.Drawing.Size(65, 69);
            this.panelPtrBoxIcon.TabIndex = 0;
            // 
            // ptrBoxIcon
            // 
            this.ptrBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.ptrBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("ptrBoxIcon.Image")));
            this.ptrBoxIcon.Location = new System.Drawing.Point(10, 10);
            this.ptrBoxIcon.Name = "ptrBoxIcon";
            this.ptrBoxIcon.Size = new System.Drawing.Size(45, 45);
            this.ptrBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrBoxIcon.TabIndex = 0;
            this.ptrBoxIcon.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.Location = new System.Drawing.Point(0, 105);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1008, 528);
            this.panelMain.TabIndex = 2;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLine.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLine.Location = new System.Drawing.Point(0, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(1008, 1);
            this.lblLine.TabIndex = 3;
            this.lblLine.Text = "LINE";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHospital
            // 
            this.lblHospital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHospital.AutoSize = true;
            this.lblHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospital.Location = new System.Drawing.Point(3, 6);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(63, 15);
            this.lblHospital.TabIndex = 4;
            this.lblHospital.Text = "Trung tâm";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(855, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người dùng";
            // 
            // menuBottomBar
            // 
            this.menuBottomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBottomBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBottomBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuBottomBar.Dock = System.Windows.Forms.DockStyle.None;
            this.menuBottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBottomBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuBottomBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip});
            this.menuBottomBar.Location = new System.Drawing.Point(925, 2);
            this.menuBottomBar.Name = "menuBottomBar";
            this.menuBottomBar.Size = new System.Drawing.Size(80, 24);
            this.menuBottomBar.TabIndex = 6;
            this.menuBottomBar.Text = "menuBottomBar";
            // 
            // menuStrip
            // 
            this.menuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItem2_HeThong,
            this.menuStripItem3_DanhMuc,
            this.menuStripItem4_ChucNang,
            this.menuStripItem5_TroGiup});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(68, 20);
            this.menuStrip.Text = "Tùy chọn";
            // 
            // menuStripItem2_HeThong
            // 
            this.menuStripItem2_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemSub1_SaoLuu,
            this.menuStripItemSub1_KhoiPhuc,
            this.stripSeparatorSubHeThong_1,
            this.menuStripItemSub1_Thoat});
            this.menuStripItem2_HeThong.Name = "menuStripItem2_HeThong";
            this.menuStripItem2_HeThong.Size = new System.Drawing.Size(133, 22);
            this.menuStripItem2_HeThong.Text = "Hệ thống";
            // 
            // menuStripItemSub1_SaoLuu
            // 
            this.menuStripItemSub1_SaoLuu.Name = "menuStripItemSub1_SaoLuu";
            this.menuStripItemSub1_SaoLuu.Size = new System.Drawing.Size(129, 22);
            this.menuStripItemSub1_SaoLuu.Text = "Sao lưu";
            // 
            // menuStripItemSub1_KhoiPhuc
            // 
            this.menuStripItemSub1_KhoiPhuc.Name = "menuStripItemSub1_KhoiPhuc";
            this.menuStripItemSub1_KhoiPhuc.Size = new System.Drawing.Size(129, 22);
            this.menuStripItemSub1_KhoiPhuc.Text = "Khôi phục";
            // 
            // stripSeparatorSubHeThong_1
            // 
            this.stripSeparatorSubHeThong_1.Name = "stripSeparatorSubHeThong_1";
            this.stripSeparatorSubHeThong_1.Size = new System.Drawing.Size(126, 6);
            // 
            // menuStripItemSub1_Thoat
            // 
            this.menuStripItemSub1_Thoat.Name = "menuStripItemSub1_Thoat";
            this.menuStripItemSub1_Thoat.Size = new System.Drawing.Size(129, 22);
            this.menuStripItemSub1_Thoat.Text = "Thoát";
            // 
            // menuStripItem3_DanhMuc
            // 
            this.menuStripItem3_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemSub1_NgheNghiep,
            this.menuStripItemSub1_BenhLy,
            this.stripSeparatorSubDanhMuc_1,
            this.menuStripItemSub1_Thuoc,
            this.menuStripItemSub1_MauDonThuoc,
            this.stripSeparatorSubDanhMuc_2,
            this.menuStripItemSub1_NhomThuThuat,
            this.menuStripItemSub1_ThuThuat,
            this.menuStripItemSub1_MauDotKham,
            this.stripSeparatorSubDanhMuc_3,
            this.menuStripItemSub1_ChuanDoan,
            this.menuStripItemSub1_HeThong});
            this.menuStripItem3_DanhMuc.Name = "menuStripItem3_DanhMuc";
            this.menuStripItem3_DanhMuc.Size = new System.Drawing.Size(133, 22);
            this.menuStripItem3_DanhMuc.Text = "Danh mục";
            // 
            // menuStripItemSub1_NgheNghiep
            // 
            this.menuStripItemSub1_NgheNghiep.Name = "menuStripItemSub1_NgheNghiep";
            this.menuStripItemSub1_NgheNghiep.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_NgheNghiep.Text = "Nghề nghiệp";
            // 
            // menuStripItemSub1_BenhLy
            // 
            this.menuStripItemSub1_BenhLy.Name = "menuStripItemSub1_BenhLy";
            this.menuStripItemSub1_BenhLy.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_BenhLy.Text = "Bệnh lý";
            // 
            // stripSeparatorSubDanhMuc_1
            // 
            this.stripSeparatorSubDanhMuc_1.Name = "stripSeparatorSubDanhMuc_1";
            this.stripSeparatorSubDanhMuc_1.Size = new System.Drawing.Size(155, 6);
            // 
            // menuStripItemSub1_Thuoc
            // 
            this.menuStripItemSub1_Thuoc.Name = "menuStripItemSub1_Thuoc";
            this.menuStripItemSub1_Thuoc.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_Thuoc.Text = "Thuốc";
            // 
            // menuStripItemSub1_MauDonThuoc
            // 
            this.menuStripItemSub1_MauDonThuoc.Name = "menuStripItemSub1_MauDonThuoc";
            this.menuStripItemSub1_MauDonThuoc.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_MauDonThuoc.Text = "Mẫu đơn thuốc";
            // 
            // stripSeparatorSubDanhMuc_2
            // 
            this.stripSeparatorSubDanhMuc_2.Name = "stripSeparatorSubDanhMuc_2";
            this.stripSeparatorSubDanhMuc_2.Size = new System.Drawing.Size(155, 6);
            // 
            // menuStripItemSub1_NhomThuThuat
            // 
            this.menuStripItemSub1_NhomThuThuat.Name = "menuStripItemSub1_NhomThuThuat";
            this.menuStripItemSub1_NhomThuThuat.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_NhomThuThuat.Text = "Nhóm thủ thuật";
            // 
            // menuStripItemSub1_ThuThuat
            // 
            this.menuStripItemSub1_ThuThuat.Name = "menuStripItemSub1_ThuThuat";
            this.menuStripItemSub1_ThuThuat.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_ThuThuat.Text = "Thủ thuật";
            // 
            // menuStripItemSub1_MauDotKham
            // 
            this.menuStripItemSub1_MauDotKham.Name = "menuStripItemSub1_MauDotKham";
            this.menuStripItemSub1_MauDotKham.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_MauDotKham.Text = "Mẫu đợt khám";
            // 
            // stripSeparatorSubDanhMuc_3
            // 
            this.stripSeparatorSubDanhMuc_3.Name = "stripSeparatorSubDanhMuc_3";
            this.stripSeparatorSubDanhMuc_3.Size = new System.Drawing.Size(155, 6);
            // 
            // menuStripItemSub1_ChuanDoan
            // 
            this.menuStripItemSub1_ChuanDoan.Name = "menuStripItemSub1_ChuanDoan";
            this.menuStripItemSub1_ChuanDoan.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_ChuanDoan.Text = "Chuẩn đoán";
            // 
            // menuStripItemSub1_HeThong
            // 
            this.menuStripItemSub1_HeThong.Name = "menuStripItemSub1_HeThong";
            this.menuStripItemSub1_HeThong.Size = new System.Drawing.Size(158, 22);
            this.menuStripItemSub1_HeThong.Text = "Hệ thống";
            // 
            // menuStripItem4_ChucNang
            // 
            this.menuStripItem4_ChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemSub1_HoSoBenhNhan,
            this.menuStripItemSub1_LichHen,
            this.menuStripItemSub1_NhanVien});
            this.menuStripItem4_ChucNang.Name = "menuStripItem4_ChucNang";
            this.menuStripItem4_ChucNang.Size = new System.Drawing.Size(133, 22);
            this.menuStripItem4_ChucNang.Text = "Chức năng";
            // 
            // menuStripItemSub1_HoSoBenhNhan
            // 
            this.menuStripItemSub1_HoSoBenhNhan.Name = "menuStripItemSub1_HoSoBenhNhan";
            this.menuStripItemSub1_HoSoBenhNhan.Size = new System.Drawing.Size(168, 22);
            this.menuStripItemSub1_HoSoBenhNhan.Text = "Hồ sơ bệnh nhân";
            // 
            // menuStripItemSub1_LichHen
            // 
            this.menuStripItemSub1_LichHen.Name = "menuStripItemSub1_LichHen";
            this.menuStripItemSub1_LichHen.Size = new System.Drawing.Size(168, 22);
            this.menuStripItemSub1_LichHen.Text = "Lịch hẹn";
            // 
            // menuStripItemSub1_NhanVien
            // 
            this.menuStripItemSub1_NhanVien.Name = "menuStripItemSub1_NhanVien";
            this.menuStripItemSub1_NhanVien.Size = new System.Drawing.Size(168, 22);
            this.menuStripItemSub1_NhanVien.Text = "Nhân viên";
            // 
            // menuStripItem5_TroGiup
            // 
            this.menuStripItem5_TroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemSub1_VeChuongTrinh,
            this.menuStripItemSub1_HuongDan});
            this.menuStripItem5_TroGiup.Name = "menuStripItem5_TroGiup";
            this.menuStripItem5_TroGiup.Size = new System.Drawing.Size(133, 22);
            this.menuStripItem5_TroGiup.Text = "Trợ giúp";
            // 
            // menuStripItemSub1_VeChuongTrinh
            // 
            this.menuStripItemSub1_VeChuongTrinh.Name = "menuStripItemSub1_VeChuongTrinh";
            this.menuStripItemSub1_VeChuongTrinh.Size = new System.Drawing.Size(182, 22);
            this.menuStripItemSub1_VeChuongTrinh.Text = "Về chương trình";
            // 
            // menuStripItemSub1_HuongDan
            // 
            this.menuStripItemSub1_HuongDan.Name = "menuStripItemSub1_HuongDan";
            this.menuStripItemSub1_HuongDan.Size = new System.Drawing.Size(182, 22);
            this.menuStripItemSub1_HuongDan.Text = "Hướng dẫn sử dụng";
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.Controls.Add(this.lblHospital);
            this.panelBottom.Controls.Add(this.lblLine);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.menuBottomBar);
            this.panelBottom.Location = new System.Drawing.Point(0, 633);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1008, 28);
            this.panelBottom.TabIndex = 7;
            // 
            // panelNaviBar
            // 
            this.panelNaviBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNaviBar.BackColor = System.Drawing.Color.DarkOrange;
            this.panelNaviBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelNaviBar.BackgroundImage")));
            this.panelNaviBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNaviBar.Controls.Add(this.lblNaviBar3);
            this.panelNaviBar.Controls.Add(this.btnBenhNhanMoi);
            this.panelNaviBar.Controls.Add(this.lblNaviBar2);
            this.panelNaviBar.Controls.Add(this.lblNaviBar1);
            this.panelNaviBar.Location = new System.Drawing.Point(0, 69);
            this.panelNaviBar.Name = "panelNaviBar";
            this.panelNaviBar.Size = new System.Drawing.Size(1008, 36);
            this.panelNaviBar.TabIndex = 1;
            // 
            // lblNaviBar3
            // 
            this.lblNaviBar3.BackColor = System.Drawing.Color.Transparent;
            this.lblNaviBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNaviBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaviBar3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNaviBar3.Location = new System.Drawing.Point(240, 0);
            this.lblNaviBar3.Name = "lblNaviBar3";
            this.lblNaviBar3.Size = new System.Drawing.Size(120, 36);
            this.lblNaviBar3.TabIndex = 1;
            this.lblNaviBar3.Text = "Điều hướng 3";
            this.lblNaviBar3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaviBar3.Visible = false;
            this.lblNaviBar3.Click += new System.EventHandler(this.lblNaviBar3_Click);
            this.lblNaviBar3.MouseEnter += new System.EventHandler(this.lblNaviBar3_MouseEnter);
            this.lblNaviBar3.MouseLeave += new System.EventHandler(this.lblNaviBar3_MouseLeave);
            // 
            // btnBenhNhanMoi
            // 
            this.btnBenhNhanMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBenhNhanMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnBenhNhanMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBenhNhanMoi.FlatAppearance.BorderSize = 0;
            this.btnBenhNhanMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenhNhanMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenhNhanMoi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBenhNhanMoi.Location = new System.Drawing.Point(831, 5);
            this.btnBenhNhanMoi.Name = "btnBenhNhanMoi";
            this.btnBenhNhanMoi.Size = new System.Drawing.Size(170, 25);
            this.btnBenhNhanMoi.TabIndex = 2;
            this.btnBenhNhanMoi.Text = "Tiếp nhận bệnh nhân mới";
            this.btnBenhNhanMoi.UseVisualStyleBackColor = true;
            this.btnBenhNhanMoi.Click += new System.EventHandler(this.btnBenhNhanMoi_Click);
            this.btnBenhNhanMoi.MouseEnter += new System.EventHandler(this.btnBenhNhanMoi_MouseEnter);
            this.btnBenhNhanMoi.MouseLeave += new System.EventHandler(this.btnBenhNhanMoi_MouseLeave);
            // 
            // lblNaviBar2
            // 
            this.lblNaviBar2.BackColor = System.Drawing.Color.Transparent;
            this.lblNaviBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNaviBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaviBar2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNaviBar2.Location = new System.Drawing.Point(120, 0);
            this.lblNaviBar2.Name = "lblNaviBar2";
            this.lblNaviBar2.Size = new System.Drawing.Size(120, 36);
            this.lblNaviBar2.TabIndex = 1;
            this.lblNaviBar2.Text = "Điều hướng 2";
            this.lblNaviBar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaviBar2.Visible = false;
            this.lblNaviBar2.VisibleChanged += new System.EventHandler(this.lblNaviBar2_VisibleChanged);
            this.lblNaviBar2.Click += new System.EventHandler(this.lblNaviBar2_Click);
            this.lblNaviBar2.MouseEnter += new System.EventHandler(this.lblNaviBar2_MouseEnter);
            this.lblNaviBar2.MouseLeave += new System.EventHandler(this.lblNaviBar2_MouseLeave);
            // 
            // lblNaviBar1
            // 
            this.lblNaviBar1.BackColor = System.Drawing.Color.Transparent;
            this.lblNaviBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNaviBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaviBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNaviBar1.Location = new System.Drawing.Point(0, 0);
            this.lblNaviBar1.Name = "lblNaviBar1";
            this.lblNaviBar1.Size = new System.Drawing.Size(120, 36);
            this.lblNaviBar1.TabIndex = 0;
            this.lblNaviBar1.Text = "Trang chủ";
            this.lblNaviBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaviBar1.Click += new System.EventHandler(this.lblNaviBar1_Click);
            this.lblNaviBar1.MouseEnter += new System.EventHandler(this.lblNaviBar1_MouseEnter);
            this.lblNaviBar1.MouseLeave += new System.EventHandler(this.lblNaviBar1_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelNaviBar);
            this.Controls.Add(this.panelMenuButton);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ NHA KHOA ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMain_FormClosed);
            this.panelMenuButton.ResumeLayout(false);
            this.panelPtrBoxIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBoxIcon)).EndInit();
            this.menuBottomBar.ResumeLayout(false);
            this.menuBottomBar.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelNaviBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion        

        private System.Windows.Forms.Panel panelMenuButton;
        private System.Windows.Forms.Panel panelNaviBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblNaviBar2;
        private System.Windows.Forms.Label lblNaviBar1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuBottomBar;
        private System.Windows.Forms.ToolStripMenuItem menuStrip;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnBenhNhanMoi;
        private ButtonMenuBar btnHoSoBenhNhan;
        private ButtonMenuBar btnQuanLyPhongKham;
        private ButtonMenuBar btnThietLapChung;
        private ButtonMenuBar btnTiepNhanDatHen;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem2_HeThong;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_SaoLuu;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_KhoiPhuc;
        private System.Windows.Forms.ToolStripSeparator stripSeparatorSubHeThong_1;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_Thoat;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem3_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem4_ChucNang;
        private System.Windows.Forms.ToolStripMenuItem menuStripItem5_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_NgheNghiep;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_BenhLy;
        private System.Windows.Forms.ToolStripSeparator stripSeparatorSubDanhMuc_1;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_Thuoc;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_MauDonThuoc;
        private System.Windows.Forms.ToolStripSeparator stripSeparatorSubDanhMuc_2;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_NhomThuThuat;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_ThuThuat;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_MauDotKham;
        private System.Windows.Forms.ToolStripSeparator stripSeparatorSubDanhMuc_3;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_ChuanDoan;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_HeThong;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_HoSoBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_LichHen;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_VeChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSub1_HuongDan;
        private System.Windows.Forms.Label lblNaviBar3;
        private System.Windows.Forms.PictureBox ptrBoxIcon;
        private System.Windows.Forms.Panel panelPtrBoxIcon;
    }
}


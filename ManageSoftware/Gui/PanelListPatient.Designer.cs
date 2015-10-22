namespace ManageSoftware.Gui
{
    partial class PanelListPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelListPatient));
            this.grvDSBenhNhan = new System.Windows.Forms.DataGridView();
            this.PatientID_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTimKiemPhienKham = new System.Windows.Forms.GroupBox();
            this.tableLayoutTimKiem = new System.Windows.Forms.TableLayoutPanel();
            this.ckTimKiemChinhXac = new System.Windows.Forms.CheckBox();
            this.txtTuTimKiem = new ManageSoftware.CustomControl.TextBoxEX();
            this.cbLoaiTimKiem = new ManageSoftware.CustomControl.ComboBoxEX();
            this.btnTimKiem = new ManageSoftware.CustomControl.ButtonEX();
            this.tableLayoutTimKiemNangCao = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimTen = new ManageSoftware.CustomControl.TextBoxEX();
            this.txtTimDiaChi = new ManageSoftware.CustomControl.TextBoxEX();
            this.cbGioiTinh = new ManageSoftware.CustomControl.ComboBoxEX();
            this.cbTuoi = new ManageSoftware.CustomControl.ComboBoxEX();
            this.cbThoiGian = new ManageSoftware.CustomControl.ComboBoxEX();
            this.btnTimKiemNangCao = new ManageSoftware.CustomControl.ButtonEX();
            this.lblTimKiemNangCao = new ManageSoftware.CustomControl.LabelEX();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnXemPhienKham = new System.Windows.Forms.Button();
            this.btnXemBenhNhan = new System.Windows.Forms.Button();
            this.btnPhienKhamMoi = new System.Windows.Forms.Button();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.cbBacSy = new ManageSoftware.CustomControl.ComboBoxEX();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSBenhNhan)).BeginInit();
            this.grbTimKiemPhienKham.SuspendLayout();
            this.tableLayoutTimKiem.SuspendLayout();
            this.tableLayoutTimKiemNangCao.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDSBenhNhan
            // 
            this.grvDSBenhNhan.AllowUserToAddRows = false;
            this.grvDSBenhNhan.AllowUserToResizeRows = false;
            this.grvDSBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvDSBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grvDSBenhNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvDSBenhNhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvDSBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDSBenhNhan.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.grvDSBenhNhan.Location = new System.Drawing.Point(3, 3);
            this.grvDSBenhNhan.MultiSelect = false;
            this.grvDSBenhNhan.Name = "grvDSBenhNhan";
            this.grvDSBenhNhan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvDSBenhNhan.RowHeadersVisible = false;
            this.grvDSBenhNhan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvDSBenhNhan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvDSBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDSBenhNhan.Size = new System.Drawing.Size(790, 478);
            this.grvDSBenhNhan.TabIndex = 3;
            this.grvDSBenhNhan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDSBenhNhan_CellDoubleClick);
            // 
            // PatientID_Col
            // 
            this.PatientID_Col.Name = "PatientID_Col";
            // 
            // FullName_Col
            // 
            this.FullName_Col.Name = "FullName_Col";
            // 
            // Gender_Col
            // 
            this.Gender_Col.Name = "Gender_Col";
            // 
            // Birthday_Col
            // 
            this.Birthday_Col.Name = "Birthday_Col";
            // 
            // Address_Col
            // 
            this.Address_Col.Name = "Address_Col";
            // 
            // Note_Col
            // 
            this.Note_Col.Name = "Note_Col";
            // 
            // grbTimKiemPhienKham
            // 
            this.grbTimKiemPhienKham.Controls.Add(this.tableLayoutTimKiem);
            this.grbTimKiemPhienKham.Controls.Add(this.tableLayoutTimKiemNangCao);
            this.grbTimKiemPhienKham.Controls.Add(this.lblTimKiemNangCao);
            this.grbTimKiemPhienKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTimKiemPhienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemPhienKham.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbTimKiemPhienKham.Location = new System.Drawing.Point(3, 3);
            this.grbTimKiemPhienKham.Name = "grbTimKiemPhienKham";
            this.grbTimKiemPhienKham.Size = new System.Drawing.Size(200, 522);
            this.grbTimKiemPhienKham.TabIndex = 2;
            this.grbTimKiemPhienKham.TabStop = false;
            this.grbTimKiemPhienKham.Text = "Tìm kiếm bệnh nhân";
            // 
            // tableLayoutTimKiem
            // 
            this.tableLayoutTimKiem.ColumnCount = 1;
            this.tableLayoutTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTimKiem.Controls.Add(this.ckTimKiemChinhXac, 0, 2);
            this.tableLayoutTimKiem.Controls.Add(this.txtTuTimKiem, 0, 0);
            this.tableLayoutTimKiem.Controls.Add(this.cbLoaiTimKiem, 0, 1);
            this.tableLayoutTimKiem.Controls.Add(this.btnTimKiem, 0, 3);
            this.tableLayoutTimKiem.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutTimKiem.Name = "tableLayoutTimKiem";
            this.tableLayoutTimKiem.RowCount = 4;
            this.tableLayoutTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiem.Size = new System.Drawing.Size(194, 114);
            this.tableLayoutTimKiem.TabIndex = 13;
            // 
            // ckTimKiemChinhXac
            // 
            this.ckTimKiemChinhXac.AutoSize = true;
            this.ckTimKiemChinhXac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckTimKiemChinhXac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckTimKiemChinhXac.Location = new System.Drawing.Point(3, 61);
            this.ckTimKiemChinhXac.Name = "ckTimKiemChinhXac";
            this.ckTimKiemChinhXac.Size = new System.Drawing.Size(188, 20);
            this.ckTimKiemChinhXac.TabIndex = 3;
            this.ckTimKiemChinhXac.Text = "Tìm kiếm chính xác";
            this.ckTimKiemChinhXac.UseVisualStyleBackColor = true;
            // 
            // txtTuTimKiem
            // 
            this.txtTuTimKiem.ClearTextDefaultForcus = false;
            this.txtTuTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTuTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuTimKiem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTuTimKiem.Location = new System.Drawing.Point(3, 3);
            this.txtTuTimKiem.Name = "txtTuTimKiem";
            this.txtTuTimKiem.Size = new System.Drawing.Size(188, 23);
            this.txtTuTimKiem.TabIndex = 4;
            this.txtTuTimKiem.Text = "Nhập từ cần tìm";
            this.txtTuTimKiem.TextDefault = "Nhập từ cần tìm";
            // 
            // cbLoaiTimKiem
            // 
            this.cbLoaiTimKiem.DisplayMember = "Name";
            this.cbLoaiTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbLoaiTimKiem.FormattingEnabled = true;
            this.cbLoaiTimKiem.ItemHeight = 15;
            this.cbLoaiTimKiem.Items = null;
            this.cbLoaiTimKiem.Location = new System.Drawing.Point(3, 32);
            this.cbLoaiTimKiem.Name = "cbLoaiTimKiem";
            this.cbLoaiTimKiem.Size = new System.Drawing.Size(188, 23);
            this.cbLoaiTimKiem.TabIndex = 5;
            this.cbLoaiTimKiem.ValueMember = "Value";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiem.Location = new System.Drawing.Point(3, 87);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(188, 24);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tableLayoutTimKiemNangCao
            // 
            this.tableLayoutTimKiemNangCao.ColumnCount = 1;
            this.tableLayoutTimKiemNangCao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTimKiemNangCao.Controls.Add(this.txtTimTen, 0, 0);
            this.tableLayoutTimKiemNangCao.Controls.Add(this.txtTimDiaChi, 0, 1);
            this.tableLayoutTimKiemNangCao.Controls.Add(this.cbGioiTinh, 0, 2);
            this.tableLayoutTimKiemNangCao.Controls.Add(this.cbTuoi, 0, 3);
            this.tableLayoutTimKiemNangCao.Controls.Add(this.cbThoiGian, 0, 4);
            this.tableLayoutTimKiemNangCao.Controls.Add(this.btnTimKiemNangCao, 0, 5);
            this.tableLayoutTimKiemNangCao.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutTimKiemNangCao.Name = "tableLayoutTimKiemNangCao";
            this.tableLayoutTimKiemNangCao.RowCount = 7;
            this.tableLayoutTimKiemNangCao.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiemNangCao.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiemNangCao.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiemNangCao.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiemNangCao.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiemNangCao.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTimKiemNangCao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutTimKiemNangCao.Size = new System.Drawing.Size(194, 174);
            this.tableLayoutTimKiemNangCao.TabIndex = 9;
            this.tableLayoutTimKiemNangCao.Visible = false;
            // 
            // txtTimTen
            // 
            this.txtTimTen.ClearTextDefaultForcus = false;
            this.txtTimTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTimTen.Location = new System.Drawing.Point(3, 3);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(188, 23);
            this.txtTimTen.TabIndex = 0;
            this.txtTimTen.Text = "Tên bệnh nhân";
            this.txtTimTen.TextDefault = "Tên bệnh nhân";
            // 
            // txtTimDiaChi
            // 
            this.txtTimDiaChi.ClearTextDefaultForcus = false;
            this.txtTimDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDiaChi.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTimDiaChi.Location = new System.Drawing.Point(3, 32);
            this.txtTimDiaChi.Name = "txtTimDiaChi";
            this.txtTimDiaChi.Size = new System.Drawing.Size(188, 23);
            this.txtTimDiaChi.TabIndex = 1;
            this.txtTimDiaChi.Text = "Địa chỉ";
            this.txtTimDiaChi.TextDefault = "Địa chỉ";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DisplayMember = "Name";
            this.cbGioiTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.ItemHeight = 15;
            this.cbGioiTinh.Items = null;
            this.cbGioiTinh.Location = new System.Drawing.Point(3, 61);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(188, 23);
            this.cbGioiTinh.TabIndex = 1;
            this.cbGioiTinh.ValueMember = "Value";
            // 
            // cbTuoi
            // 
            this.cbTuoi.DisplayMember = "Name";
            this.cbTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbTuoi.FormattingEnabled = true;
            this.cbTuoi.ItemHeight = 15;
            this.cbTuoi.Items = null;
            this.cbTuoi.Location = new System.Drawing.Point(3, 90);
            this.cbTuoi.Name = "cbTuoi";
            this.cbTuoi.Size = new System.Drawing.Size(188, 23);
            this.cbTuoi.TabIndex = 2;
            this.cbTuoi.ValueMember = "Value";
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.DisplayMember = "Name";
            this.cbThoiGian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThoiGian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.ItemHeight = 15;
            this.cbThoiGian.Items = null;
            this.cbThoiGian.Location = new System.Drawing.Point(3, 119);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(188, 23);
            this.cbThoiGian.TabIndex = 10;
            this.cbThoiGian.ValueMember = "Value";
            // 
            // btnTimKiemNangCao
            // 
            this.btnTimKiemNangCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemNangCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNangCao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiemNangCao.Location = new System.Drawing.Point(3, 148);
            this.btnTimKiemNangCao.Name = "btnTimKiemNangCao";
            this.btnTimKiemNangCao.Size = new System.Drawing.Size(188, 23);
            this.btnTimKiemNangCao.TabIndex = 12;
            this.btnTimKiemNangCao.Text = "Tìm kiếm";
            this.btnTimKiemNangCao.UseVisualStyleBackColor = true;
            this.btnTimKiemNangCao.Click += new System.EventHandler(this.btnTimKiemNangCao_Click);
            // 
            // lblTimKiemNangCao
            // 
            this.lblTimKiemNangCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimKiemNangCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNangCao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTimKiemNangCao.Location = new System.Drawing.Point(6, 488);
            this.lblTimKiemNangCao.Name = "lblTimKiemNangCao";
            this.lblTimKiemNangCao.Size = new System.Drawing.Size(188, 34);
            this.lblTimKiemNangCao.TabIndex = 4;
            this.lblTimKiemNangCao.Text = "Tìm nâng cao";
            this.lblTimKiemNangCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimKiemNangCao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTimKiemNangCao_MouseClick);
            this.lblTimKiemNangCao.MouseEnter += new System.EventHandler(this.lblTimKiemNangCao_MouseEnter);
            this.lblTimKiemNangCao.MouseLeave += new System.EventHandler(this.lblTimKiemNangCao_MouseLeave);
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.Controls.Add(this.bindingNavigator);
            this.panelBottom.Controls.Add(this.btnXemPhienKham);
            this.panelBottom.Controls.Add(this.btnXemBenhNhan);
            this.panelBottom.Controls.Add(this.btnPhienKhamMoi);
            this.panelBottom.Location = new System.Drawing.Point(3, 487);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(790, 32);
            this.panelBottom.TabIndex = 4;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.bindingNavigator.BindingSource = this.bindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.CountItemFormat = "/ {0}";
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 6);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator.Size = new System.Drawing.Size(188, 25);
            this.bindingNavigator.TabIndex = 4;
            this.bindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // btnXemPhienKham
            // 
            this.btnXemPhienKham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemPhienKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemPhienKham.Location = new System.Drawing.Point(675, 6);
            this.btnXemPhienKham.Name = "btnXemPhienKham";
            this.btnXemPhienKham.Size = new System.Drawing.Size(116, 23);
            this.btnXemPhienKham.TabIndex = 3;
            this.btnXemPhienKham.Text = "Xem phiên khám";
            this.btnXemPhienKham.UseVisualStyleBackColor = true;
            // 
            // btnXemBenhNhan
            // 
            this.btnXemBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBenhNhan.Location = new System.Drawing.Point(562, 6);
            this.btnXemBenhNhan.Name = "btnXemBenhNhan";
            this.btnXemBenhNhan.Size = new System.Drawing.Size(110, 23);
            this.btnXemBenhNhan.TabIndex = 2;
            this.btnXemBenhNhan.Text = "Xem bệnh nhân";
            this.btnXemBenhNhan.UseVisualStyleBackColor = true;
            // 
            // btnPhienKhamMoi
            // 
            this.btnPhienKhamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhienKhamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhienKhamMoi.Location = new System.Drawing.Point(421, 6);
            this.btnPhienKhamMoi.Name = "btnPhienKhamMoi";
            this.btnPhienKhamMoi.Size = new System.Drawing.Size(138, 23);
            this.btnPhienKhamMoi.TabIndex = 1;
            this.btnPhienKhamMoi.Text = "Tạo phiên khám mới";
            this.btnPhienKhamMoi.UseVisualStyleBackColor = true;
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.grbTimKiemPhienKham, 0, 0);
            this.tableLayoutMain.Controls.Add(this.tableLayoutLeft, 1, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1008, 528);
            this.tableLayoutMain.TabIndex = 5;
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.ColumnCount = 1;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.Controls.Add(this.grvDSBenhNhan, 0, 0);
            this.tableLayoutLeft.Controls.Add(this.panelBottom, 0, 1);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(209, 3);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 2;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutLeft.Size = new System.Drawing.Size(796, 522);
            this.tableLayoutLeft.TabIndex = 3;
            // 
            // cbBacSy
            // 
            this.cbBacSy.DisplayMember = "Name";
            this.cbBacSy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBacSy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBacSy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbBacSy.FormattingEnabled = true;
            this.cbBacSy.ItemHeight = 15;
            this.cbBacSy.Items = null;
            this.cbBacSy.Location = new System.Drawing.Point(3, 177);
            this.cbBacSy.Name = "cbBacSy";
            this.cbBacSy.Size = new System.Drawing.Size(191, 23);
            this.cbBacSy.TabIndex = 11;
            this.cbBacSy.ValueMember = "Value";
            // 
            // PanelListPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "PanelListPatient";
            this.Size = new System.Drawing.Size(1008, 528);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSBenhNhan)).EndInit();
            this.grbTimKiemPhienKham.ResumeLayout(false);
            this.tableLayoutTimKiem.ResumeLayout(false);
            this.tableLayoutTimKiem.PerformLayout();
            this.tableLayoutTimKiemNangCao.ResumeLayout(false);
            this.tableLayoutTimKiemNangCao.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDSBenhNhan;
        private System.Windows.Forms.GroupBox grbTimKiemPhienKham;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnXemPhienKham;
        private System.Windows.Forms.Button btnXemBenhNhan;
        private System.Windows.Forms.Button btnPhienKhamMoi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private System.Windows.Forms.CheckBox ckTimKiemChinhXac;
        private CustomControl.ComboBoxEX cbGioiTinh;
        private CustomControl.TextBoxEX txtTimTen;
        private CustomControl.LabelEX lblTimKiemNangCao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTimKiemNangCao;
        private CustomControl.TextBoxEX txtTimDiaChi;
        private CustomControl.ButtonEX btnTimKiemNangCao;
        private CustomControl.ComboBoxEX cbBacSy;
        private CustomControl.ComboBoxEX cbThoiGian;
        private CustomControl.ComboBoxEX cbTuoi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTimKiem;
        private CustomControl.TextBoxEX txtTuTimKiem;
        private CustomControl.ComboBoxEX cbLoaiTimKiem;
        private CustomControl.ButtonEX btnTimKiem;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    }
}

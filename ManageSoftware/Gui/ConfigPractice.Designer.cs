namespace ManageSoftware.Gui
{
    partial class ConfigPractice
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
            this.lblLucNang = new System.Windows.Forms.Label();
            this.lblTocDoChay = new System.Windows.Forms.Label();
            this.lblThoiGianTap = new System.Windows.Forms.Label();
            this.txtLucNang = new System.Windows.Forms.TextBox();
            this.txtTocDoChay = new System.Windows.Forms.DomainUpDown();
            this.txtThoiGianTap = new System.Windows.Forms.DomainUpDown();
            this.grbSettingConfig = new System.Windows.Forms.GroupBox();
            this.grbStatusMachine = new System.Windows.Forms.GroupBox();
            this.lblTimeLife = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblTextTimeLife = new System.Windows.Forms.Label();
            this.lblTextConnectingStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbSettingConfig.SuspendLayout();
            this.grbStatusMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLucNang
            // 
            this.lblLucNang.AutoSize = true;
            this.lblLucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucNang.Location = new System.Drawing.Point(16, 22);
            this.lblLucNang.Name = "lblLucNang";
            this.lblLucNang.Size = new System.Drawing.Size(92, 16);
            this.lblLucNang.TabIndex = 0;
            this.lblLucNang.Text = "Lực nâng (Kg):";
            // 
            // lblTocDoChay
            // 
            this.lblTocDoChay.AutoSize = true;
            this.lblTocDoChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTocDoChay.Location = new System.Drawing.Point(15, 47);
            this.lblTocDoChay.Name = "lblTocDoChay";
            this.lblTocDoChay.Size = new System.Drawing.Size(138, 16);
            this.lblTocDoChay.TabIndex = 1;
            this.lblTocDoChay.Text = "Tốc độ chạy (m/giây):";
            // 
            // lblThoiGianTap
            // 
            this.lblThoiGianTap.AutoSize = true;
            this.lblThoiGianTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianTap.Location = new System.Drawing.Point(15, 72);
            this.lblThoiGianTap.Name = "lblThoiGianTap";
            this.lblThoiGianTap.Size = new System.Drawing.Size(125, 16);
            this.lblThoiGianTap.TabIndex = 2;
            this.lblThoiGianTap.Text = "Thời gian tập (phút):";
            // 
            // txtLucNang
            // 
            this.txtLucNang.Location = new System.Drawing.Point(171, 17);
            this.txtLucNang.Name = "txtLucNang";
            this.txtLucNang.Size = new System.Drawing.Size(132, 21);
            this.txtLucNang.TabIndex = 3;
            this.txtLucNang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTocDoChay
            // 
            this.txtTocDoChay.Items.Add("10");
            this.txtTocDoChay.Items.Add("20");
            this.txtTocDoChay.Items.Add("30");
            this.txtTocDoChay.Items.Add("40");
            this.txtTocDoChay.Items.Add("50");
            this.txtTocDoChay.Items.Add("60");
            this.txtTocDoChay.Items.Add("70");
            this.txtTocDoChay.Items.Add("80");
            this.txtTocDoChay.Location = new System.Drawing.Point(171, 43);
            this.txtTocDoChay.Name = "txtTocDoChay";
            this.txtTocDoChay.Size = new System.Drawing.Size(132, 21);
            this.txtTocDoChay.TabIndex = 4;
            this.txtTocDoChay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtThoiGianTap
            // 
            this.txtThoiGianTap.Items.Add("10");
            this.txtThoiGianTap.Items.Add("20");
            this.txtThoiGianTap.Items.Add("30");
            this.txtThoiGianTap.Items.Add("40");
            this.txtThoiGianTap.Items.Add("50");
            this.txtThoiGianTap.Items.Add("60");
            this.txtThoiGianTap.Location = new System.Drawing.Point(171, 69);
            this.txtThoiGianTap.Name = "txtThoiGianTap";
            this.txtThoiGianTap.Size = new System.Drawing.Size(132, 21);
            this.txtThoiGianTap.TabIndex = 5;
            this.txtThoiGianTap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThoiGianTap.SelectedItemChanged += new System.EventHandler(this.txtThoiGianTap_SelectedItemChanged);
            // 
            // grbSettingConfig
            // 
            this.grbSettingConfig.Controls.Add(this.lblLucNang);
            this.grbSettingConfig.Controls.Add(this.txtThoiGianTap);
            this.grbSettingConfig.Controls.Add(this.lblTocDoChay);
            this.grbSettingConfig.Controls.Add(this.txtTocDoChay);
            this.grbSettingConfig.Controls.Add(this.lblThoiGianTap);
            this.grbSettingConfig.Controls.Add(this.txtLucNang);
            this.grbSettingConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSettingConfig.Location = new System.Drawing.Point(12, 154);
            this.grbSettingConfig.Name = "grbSettingConfig";
            this.grbSettingConfig.Size = new System.Drawing.Size(324, 100);
            this.grbSettingConfig.TabIndex = 6;
            this.grbSettingConfig.TabStop = false;
            this.grbSettingConfig.Text = "Thiết lập máy tập";
            // 
            // grbStatusMachine
            // 
            this.grbStatusMachine.Controls.Add(this.lblTimeLife);
            this.grbStatusMachine.Controls.Add(this.lblConnectionStatus);
            this.grbStatusMachine.Controls.Add(this.lblTextTimeLife);
            this.grbStatusMachine.Controls.Add(this.lblTextConnectingStatus);
            this.grbStatusMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStatusMachine.Location = new System.Drawing.Point(12, 57);
            this.grbStatusMachine.Name = "grbStatusMachine";
            this.grbStatusMachine.Size = new System.Drawing.Size(324, 82);
            this.grbStatusMachine.TabIndex = 7;
            this.grbStatusMachine.TabStop = false;
            this.grbStatusMachine.Text = "Trạng thái máy tập";
            // 
            // lblTimeLife
            // 
            this.lblTimeLife.AutoSize = true;
            this.lblTimeLife.Location = new System.Drawing.Point(168, 52);
            this.lblTimeLife.Name = "lblTimeLife";
            this.lblTimeLife.Size = new System.Drawing.Size(63, 15);
            this.lblTimeLife.TabIndex = 11;
            this.lblTimeLife.Text = "00:10:00";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(168, 27);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(88, 15);
            this.lblConnectionStatus.TabIndex = 10;
            this.lblConnectionStatus.Text = "Đang kết nối";
            // 
            // lblTextTimeLife
            // 
            this.lblTextTimeLife.AutoSize = true;
            this.lblTextTimeLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTimeLife.Location = new System.Drawing.Point(14, 52);
            this.lblTextTimeLife.Name = "lblTextTimeLife";
            this.lblTextTimeLife.Size = new System.Drawing.Size(130, 16);
            this.lblTextTimeLife.TabIndex = 9;
            this.lblTextTimeLife.Text = "Thời gian hoạt động:";
            // 
            // lblTextConnectingStatus
            // 
            this.lblTextConnectingStatus.AutoSize = true;
            this.lblTextConnectingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextConnectingStatus.Location = new System.Drawing.Point(15, 27);
            this.lblTextConnectingStatus.Name = "lblTextConnectingStatus";
            this.lblTextConnectingStatus.Size = new System.Drawing.Size(102, 16);
            this.lblTextConnectingStatus.TabIndex = 8;
            this.lblTextConnectingStatus.Text = "Kết nối máy tập:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 43);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Tên bài tập luyện";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(174, 263);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 28);
            this.btnDongY.TabIndex = 9;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(261, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 28);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ConfigPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbStatusMachine);
            this.Controls.Add(this.grbSettingConfig);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập máy tập";
            this.grbSettingConfig.ResumeLayout(false);
            this.grbSettingConfig.PerformLayout();
            this.grbStatusMachine.ResumeLayout(false);
            this.grbStatusMachine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLucNang;
        private System.Windows.Forms.Label lblTocDoChay;
        private System.Windows.Forms.Label lblThoiGianTap;
        private System.Windows.Forms.TextBox txtLucNang;
        private System.Windows.Forms.DomainUpDown txtTocDoChay;
        private System.Windows.Forms.DomainUpDown txtThoiGianTap;
        private System.Windows.Forms.GroupBox grbSettingConfig;
        private System.Windows.Forms.GroupBox grbStatusMachine;
        private System.Windows.Forms.Label lblTimeLife;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblTextTimeLife;
        private System.Windows.Forms.Label lblTextConnectingStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;

        public string TitleForm
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
    }
}
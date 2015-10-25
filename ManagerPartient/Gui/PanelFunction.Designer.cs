namespace ManagerPartient.Gui
{
    partial class PanelFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelFunction));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInfomation = new ManagerPartient.CustomControl.ButtonEX();
            this.btnRestoreData = new ManagerPartient.CustomControl.ButtonEX();
            this.btnBackupData = new ManagerPartient.CustomControl.ButtonEX();
            this.btnSeting = new ManagerPartient.CustomControl.ButtonEX();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnInfomation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRestoreData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBackupData, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSeting, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1002, 363);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnInfomation
            // 
            this.btnInfomation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfomation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfomation.Image = ((System.Drawing.Image)(resources.GetObject("btnInfomation.Image")));
            this.btnInfomation.Location = new System.Drawing.Point(3, 3);
            this.btnInfomation.Name = "btnInfomation";
            this.btnInfomation.Size = new System.Drawing.Size(244, 357);
            this.btnInfomation.TabIndex = 0;
            this.btnInfomation.Text = "Thông tin";
            this.btnInfomation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnInfomation.UseVisualStyleBackColor = false;
            // 
            // btnRestoreData
            // 
            this.btnRestoreData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestoreData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestoreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestoreData.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreData.Image")));
            this.btnRestoreData.Location = new System.Drawing.Point(253, 3);
            this.btnRestoreData.Name = "btnRestoreData";
            this.btnRestoreData.Size = new System.Drawing.Size(244, 357);
            this.btnRestoreData.TabIndex = 1;
            this.btnRestoreData.Text = "Khôi phục";
            this.btnRestoreData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRestoreData.UseVisualStyleBackColor = false;
            this.btnRestoreData.Click += new System.EventHandler(this.btnRestoreData_Click);
            // 
            // btnBackupData
            // 
            this.btnBackupData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackupData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackupData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackupData.Image = ((System.Drawing.Image)(resources.GetObject("btnBackupData.Image")));
            this.btnBackupData.Location = new System.Drawing.Point(503, 3);
            this.btnBackupData.Name = "btnBackupData";
            this.btnBackupData.Size = new System.Drawing.Size(244, 357);
            this.btnBackupData.TabIndex = 2;
            this.btnBackupData.Text = "Sao lưu";
            this.btnBackupData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBackupData.UseVisualStyleBackColor = false;
            this.btnBackupData.Click += new System.EventHandler(this.btnBackupData_Click);
            // 
            // btnSeting
            // 
            this.btnSeting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeting.Image = ((System.Drawing.Image)(resources.GetObject("btnSeting.Image")));
            this.btnSeting.Location = new System.Drawing.Point(753, 3);
            this.btnSeting.Name = "btnSeting";
            this.btnSeting.Size = new System.Drawing.Size(246, 357);
            this.btnSeting.TabIndex = 3;
            this.btnSeting.Text = "Cài đặt";
            this.btnSeting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSeting.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(6, 375);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(996, 147);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // PanelFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PanelFunction";
            this.Size = new System.Drawing.Size(1008, 528);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControl.ButtonEX btnInfomation;
        private CustomControl.ButtonEX btnRestoreData;
        private CustomControl.ButtonEX btnBackupData;
        private CustomControl.ButtonEX btnSeting;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

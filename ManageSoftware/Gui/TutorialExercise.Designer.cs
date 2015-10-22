namespace ManageSoftware.Gui
{
    partial class TutorialExercise
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
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtHuongDan = new ManageSoftware.CustomControl.TextBoxEX();
            this.lblHuongDan = new ManageSoftware.CustomControl.LabelEX();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.txtLuuY = new ManageSoftware.CustomControl.TextBoxEX();
            this.lblLuuY = new ManageSoftware.CustomControl.LabelEX();
            this.tableLayoutMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutMain.Controls.Add(this.panelBottom, 0, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMain.Size = new System.Drawing.Size(750, 400);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtHuongDan);
            this.panelTop.Controls.Add(this.lblHuongDan);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(744, 274);
            this.panelTop.TabIndex = 0;
            // 
            // txtHuongDan
            // 
            this.txtHuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHuongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHuongDan.ClearTextDefaultForcus = false;
            this.txtHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuongDan.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtHuongDan.Location = new System.Drawing.Point(3, 23);
            this.txtHuongDan.Multiline = true;
            this.txtHuongDan.Name = "txtHuongDan";
            this.txtHuongDan.Size = new System.Drawing.Size(738, 248);
            this.txtHuongDan.TabIndex = 1;
            this.txtHuongDan.TextDefault = null;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHuongDan.Location = new System.Drawing.Point(0, 5);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(146, 15);
            this.lblHuongDan.TabIndex = 0;
            this.lblHuongDan.Text = "Hướng dẫn chi tiết bài tập";
            this.lblHuongDan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.txtLuuY);
            this.panelBottom.Controls.Add(this.lblLuuY);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 283);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(744, 114);
            this.panelBottom.TabIndex = 1;
            // 
            // txtLuuY
            // 
            this.txtLuuY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuuY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuuY.ClearTextDefaultForcus = false;
            this.txtLuuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuuY.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtLuuY.Location = new System.Drawing.Point(3, 24);
            this.txtLuuY.Multiline = true;
            this.txtLuuY.Name = "txtLuuY";
            this.txtLuuY.Size = new System.Drawing.Size(738, 87);
            this.txtLuuY.TabIndex = 1;
            this.txtLuuY.TextDefault = null;
            // 
            // lblLuuY
            // 
            this.lblLuuY.AutoSize = true;
            this.lblLuuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuuY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLuuY.Location = new System.Drawing.Point(0, 6);
            this.lblLuuY.Name = "lblLuuY";
            this.lblLuuY.Size = new System.Drawing.Size(88, 15);
            this.lblLuuY.TabIndex = 0;
            this.lblLuuY.Text = "Cần lưu ý thêm";
            this.lblLuuY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TutorialExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "TutorialExercise";
            this.Size = new System.Drawing.Size(750, 400);
            this.tableLayoutMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Panel panelTop;
        private CustomControl.TextBoxEX txtHuongDan;
        private CustomControl.LabelEX lblHuongDan;
        private System.Windows.Forms.Panel panelBottom;
        private CustomControl.TextBoxEX txtLuuY;
        private CustomControl.LabelEX lblLuuY;
    }
}

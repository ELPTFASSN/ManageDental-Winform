namespace ManageSoftware.Gui
{
    partial class SettingPortCOM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblPortCom = new ManageSoftware.CustomControl.LabelEX();
            this.lblBaudRate = new ManageSoftware.CustomControl.LabelEX();
            this.lblDataBits = new ManageSoftware.CustomControl.LabelEX();
            this.lblStopBits = new ManageSoftware.CustomControl.LabelEX();
            this.lblParity = new ManageSoftware.CustomControl.LabelEX();
            this.cbPortCOM = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.tableLayoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông số kết nối COM";
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.lblPortCom, 0, 0);
            this.tableLayoutMain.Controls.Add(this.lblBaudRate, 0, 1);
            this.tableLayoutMain.Controls.Add(this.lblDataBits, 0, 2);
            this.tableLayoutMain.Controls.Add(this.lblStopBits, 0, 3);
            this.tableLayoutMain.Controls.Add(this.lblParity, 0, 4);
            this.tableLayoutMain.Controls.Add(this.cbPortCOM, 1, 0);
            this.tableLayoutMain.Controls.Add(this.cbBaudRate, 1, 1);
            this.tableLayoutMain.Controls.Add(this.cbDataBits, 1, 2);
            this.tableLayoutMain.Controls.Add(this.cbStopBits, 1, 3);
            this.tableLayoutMain.Controls.Add(this.cbParity, 1, 4);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 5;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(500, 400);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // lblPortCom
            // 
            this.lblPortCom.AutoSize = true;
            this.lblPortCom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPortCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortCom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPortCom.Location = new System.Drawing.Point(3, 3);
            this.lblPortCom.Margin = new System.Windows.Forms.Padding(3);
            this.lblPortCom.Name = "lblPortCom";
            this.lblPortCom.Size = new System.Drawing.Size(94, 15);
            this.lblPortCom.TabIndex = 0;
            this.lblPortCom.Text = "Port COM";
            this.lblPortCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBaudRate.Location = new System.Drawing.Point(3, 83);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(3);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(94, 15);
            this.lblBaudRate.TabIndex = 1;
            this.lblBaudRate.Text = "Baud Rate";
            this.lblBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataBits.Location = new System.Drawing.Point(3, 163);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(3);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(94, 15);
            this.lblDataBits.TabIndex = 2;
            this.lblDataBits.Text = "Data Bits";
            this.lblDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopBits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStopBits.Location = new System.Drawing.Point(3, 243);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(3);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(94, 15);
            this.lblStopBits.TabIndex = 3;
            this.lblStopBits.Text = "Stop Bits";
            this.lblStopBits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParity.Location = new System.Drawing.Point(3, 323);
            this.lblParity.Margin = new System.Windows.Forms.Padding(3);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(94, 15);
            this.lblParity.TabIndex = 4;
            this.lblParity.Text = "Parity";
            this.lblParity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPortCOM
            // 
            this.cbPortCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPortCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortCOM.FormattingEnabled = true;
            this.cbPortCOM.Location = new System.Drawing.Point(103, 3);
            this.cbPortCOM.Name = "cbPortCOM";
            this.cbPortCOM.Size = new System.Drawing.Size(394, 21);
            this.cbPortCOM.TabIndex = 5;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(103, 83);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(394, 21);
            this.cbBaudRate.TabIndex = 6;
            // 
            // cbDataBits
            // 
            this.cbDataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(103, 163);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(394, 21);
            this.cbDataBits.TabIndex = 7;
            // 
            // cbStopBits
            // 
            this.cbStopBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(103, 243);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(394, 21);
            this.cbStopBits.TabIndex = 8;
            // 
            // cbParity
            // 
            this.cbParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(103, 323);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(394, 21);
            this.cbParity.TabIndex = 9;
            // 
            // SettingPortCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "SettingPortCOM";
            this.Size = new System.Drawing.Size(500, 400);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private CustomControl.LabelEX lblPortCom;
        private CustomControl.LabelEX lblBaudRate;
        private CustomControl.LabelEX lblDataBits;
        private CustomControl.LabelEX lblStopBits;
        private CustomControl.LabelEX lblParity;
        private System.Windows.Forms.ComboBox cbPortCOM;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
    }
}

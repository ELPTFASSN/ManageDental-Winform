namespace ManagerPartient.Gui
{
    partial class PanelBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelBackupRestore));
            this.tablePanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextNote3 = new ManagerPartient.CustomControl.LabelEX();
            this.lblText1 = new ManagerPartient.CustomControl.LabelEX();
            this.lblText2 = new ManagerPartient.CustomControl.LabelEX();
            this.lblTextNote2 = new ManagerPartient.CustomControl.LabelEX();
            this.lblTextNote1 = new ManagerPartient.CustomControl.LabelEX();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.grbChooseFile = new System.Windows.Forms.GroupBox();
            this.tablePanelChooseFile = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbInsertData = new System.Windows.Forms.RadioButton();
            this.rbRetoreAll = new System.Windows.Forms.RadioButton();
            this.labelEX1 = new ManagerPartient.CustomControl.LabelEX();
            this.pnChooseFile = new System.Windows.Forms.Panel();
            this.lblPathFile = new ManagerPartient.CustomControl.LabelEX();
            this.btnChooseFile = new ManagerPartient.CustomControl.ButtonEX();
            this.txtPathFile = new ManagerPartient.CustomControl.TextBoxEX();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tablePanelMain.SuspendLayout();
            this.tablePanelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.grbChooseFile.SuspendLayout();
            this.tablePanelChooseFile.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnChooseFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanelMain
            // 
            this.tablePanelMain.ColumnCount = 1;
            this.tablePanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMain.Controls.Add(this.tablePanelTop, 0, 0);
            this.tablePanelMain.Controls.Add(this.panelBottom, 0, 1);
            this.tablePanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelMain.Location = new System.Drawing.Point(0, 0);
            this.tablePanelMain.Name = "tablePanelMain";
            this.tablePanelMain.RowCount = 2;
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tablePanelMain.Size = new System.Drawing.Size(750, 400);
            this.tablePanelMain.TabIndex = 0;
            // 
            // tablePanelTop
            // 
            this.tablePanelTop.ColumnCount = 1;
            this.tablePanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelTop.Controls.Add(this.lblTextNote3, 0, 4);
            this.tablePanelTop.Controls.Add(this.lblText1, 0, 0);
            this.tablePanelTop.Controls.Add(this.lblText2, 0, 1);
            this.tablePanelTop.Controls.Add(this.lblTextNote2, 0, 3);
            this.tablePanelTop.Controls.Add(this.lblTextNote1, 0, 2);
            this.tablePanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelTop.Location = new System.Drawing.Point(3, 3);
            this.tablePanelTop.Name = "tablePanelTop";
            this.tablePanelTop.RowCount = 5;
            this.tablePanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePanelTop.Size = new System.Drawing.Size(744, 274);
            this.tablePanelTop.TabIndex = 5;
            // 
            // lblTextNote3
            // 
            this.lblTextNote3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNote3.ForeColor = System.Drawing.Color.Red;
            this.lblTextNote3.Location = new System.Drawing.Point(3, 194);
            this.lblTextNote3.Name = "lblTextNote3";
            this.lblTextNote3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTextNote3.Size = new System.Drawing.Size(738, 20);
            this.lblTextNote3.TabIndex = 4;
            this.lblTextNote3.Text = "* Lựa chọn 2: Thêm dữ liệu từ bản sao lưu vào hệ thống (Giữ nguyên các dữ liệu đa" +
    "ng có)";
            this.lblTextNote3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblText1
            // 
            this.lblText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblText1.Location = new System.Drawing.Point(3, 0);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(738, 58);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Chào mừng bạn đã đến với công cụ hỗ trợ phục hồi hệ thống";
            this.lblText1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblText2
            // 
            this.lblText2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblText2.Location = new System.Drawing.Point(3, 58);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(738, 91);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = resources.GetString("lblText2.Text");
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextNote2
            // 
            this.lblTextNote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNote2.ForeColor = System.Drawing.Color.Red;
            this.lblTextNote2.Location = new System.Drawing.Point(3, 174);
            this.lblTextNote2.Name = "lblTextNote2";
            this.lblTextNote2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTextNote2.Size = new System.Drawing.Size(738, 20);
            this.lblTextNote2.TabIndex = 3;
            this.lblTextNote2.Text = "* Lựa chọn 1: Phục hồi hệ thống lại như ban đầu (Xóa sạch toàn bộ dữ liệu hiện tạ" +
    "i thay vào dữ liệu mới)";
            this.lblTextNote2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextNote1
            // 
            this.lblTextNote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNote1.ForeColor = System.Drawing.Color.Red;
            this.lblTextNote1.Image = ((System.Drawing.Image)(resources.GetObject("lblTextNote1.Image")));
            this.lblTextNote1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTextNote1.Location = new System.Drawing.Point(3, 149);
            this.lblTextNote1.Name = "lblTextNote1";
            this.lblTextNote1.Size = new System.Drawing.Size(694, 25);
            this.lblTextNote1.TabIndex = 2;
            this.lblTextNote1.Text = "Lưu ý: Bạn chọn một trọng hai lựa chọn sau có thể mất hoàn toàn dữ liệu cần lưu ý" +
    " và đọc kỹ đề mục sau:";
            this.lblTextNote1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.grbChooseFile);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 283);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(744, 114);
            this.panelBottom.TabIndex = 1;
            // 
            // grbChooseFile
            // 
            this.grbChooseFile.Controls.Add(this.tablePanelChooseFile);
            this.grbChooseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChooseFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbChooseFile.Location = new System.Drawing.Point(0, 0);
            this.grbChooseFile.Name = "grbChooseFile";
            this.grbChooseFile.Size = new System.Drawing.Size(744, 114);
            this.grbChooseFile.TabIndex = 5;
            this.grbChooseFile.TabStop = false;
            this.grbChooseFile.Text = "Thao tác phục hồi";
            // 
            // tablePanelChooseFile
            // 
            this.tablePanelChooseFile.ColumnCount = 1;
            this.tablePanelChooseFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelChooseFile.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tablePanelChooseFile.Controls.Add(this.pnChooseFile, 0, 1);
            this.tablePanelChooseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelChooseFile.Location = new System.Drawing.Point(3, 16);
            this.tablePanelChooseFile.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanelChooseFile.Name = "tablePanelChooseFile";
            this.tablePanelChooseFile.RowCount = 2;
            this.tablePanelChooseFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelChooseFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelChooseFile.Size = new System.Drawing.Size(738, 95);
            this.tablePanelChooseFile.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rbInsertData, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbRetoreAll, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelEX1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(732, 41);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rbInsertData
            // 
            this.rbInsertData.AutoSize = true;
            this.rbInsertData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInsertData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbInsertData.Location = new System.Drawing.Point(458, 3);
            this.rbInsertData.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.rbInsertData.Name = "rbInsertData";
            this.rbInsertData.Size = new System.Drawing.Size(242, 20);
            this.rbInsertData.TabIndex = 2;
            this.rbInsertData.TabStop = true;
            this.rbInsertData.Text = "Lựa chọn 2: Thêm dữ liệu từ file Excel";
            this.rbInsertData.UseVisualStyleBackColor = true;
            // 
            // rbRetoreAll
            // 
            this.rbRetoreAll.AutoSize = true;
            this.rbRetoreAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetoreAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRetoreAll.Location = new System.Drawing.Point(154, 3);
            this.rbRetoreAll.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.rbRetoreAll.Name = "rbRetoreAll";
            this.rbRetoreAll.Size = new System.Drawing.Size(259, 20);
            this.rbRetoreAll.TabIndex = 1;
            this.rbRetoreAll.TabStop = true;
            this.rbRetoreAll.Text = "Lựa chọn 1: Phục hồi dữ liệu về ban đầu";
            this.rbRetoreAll.UseVisualStyleBackColor = true;
            // 
            // labelEX1
            // 
            this.labelEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEX1.Location = new System.Drawing.Point(20, 0);
            this.labelEX1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.labelEX1.Name = "labelEX1";
            this.labelEX1.Size = new System.Drawing.Size(131, 23);
            this.labelEX1.TabIndex = 3;
            this.labelEX1.Text = "Thao tác dữ liệu";
            this.labelEX1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnChooseFile
            // 
            this.pnChooseFile.Controls.Add(this.lblPathFile);
            this.pnChooseFile.Controls.Add(this.btnChooseFile);
            this.pnChooseFile.Controls.Add(this.txtPathFile);
            this.pnChooseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChooseFile.Location = new System.Drawing.Point(3, 50);
            this.pnChooseFile.Name = "pnChooseFile";
            this.pnChooseFile.Size = new System.Drawing.Size(732, 42);
            this.pnChooseFile.TabIndex = 1;
            // 
            // lblPathFile
            // 
            this.lblPathFile.AutoSize = true;
            this.lblPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPathFile.Location = new System.Drawing.Point(21, 3);
            this.lblPathFile.Name = "lblPathFile";
            this.lblPathFile.Size = new System.Drawing.Size(111, 16);
            this.lblPathFile.TabIndex = 4;
            this.lblPathFile.Text = "Đường dẫn tệp tin";
            this.lblPathFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChooseFile.Location = new System.Drawing.Point(609, 0);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(102, 25);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Chọn tệp tin";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtPathFile
            // 
            this.txtPathFile.ClearTextDefaultForcus = false;
            this.txtPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPathFile.Location = new System.Drawing.Point(153, 0);
            this.txtPathFile.Multiline = true;
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(450, 23);
            this.txtPathFile.TabIndex = 3;
            this.txtPathFile.TextDefault = null;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // PanelBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanelMain);
            this.Name = "PanelBackupRestore";
            this.Size = new System.Drawing.Size(750, 400);
            this.tablePanelMain.ResumeLayout(false);
            this.tablePanelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.grbChooseFile.ResumeLayout(false);
            this.tablePanelChooseFile.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pnChooseFile.ResumeLayout(false);
            this.pnChooseFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanelMain;
        private System.Windows.Forms.Panel panelBottom;
        private CustomControl.TextBoxEX txtPathFile;
        private System.Windows.Forms.RadioButton rbInsertData;
        private System.Windows.Forms.RadioButton rbRetoreAll;
        private CustomControl.ButtonEX btnChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel tablePanelChooseFile;
        private System.Windows.Forms.GroupBox grbChooseFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel pnChooseFile;
        private CustomControl.LabelEX lblPathFile;
        private System.Windows.Forms.TableLayoutPanel tablePanelTop;
        private CustomControl.LabelEX lblTextNote3;
        private CustomControl.LabelEX lblText1;
        private CustomControl.LabelEX lblText2;
        private CustomControl.LabelEX lblTextNote2;
        private CustomControl.LabelEX lblTextNote1;
        private CustomControl.LabelEX labelEX1;
    }
}

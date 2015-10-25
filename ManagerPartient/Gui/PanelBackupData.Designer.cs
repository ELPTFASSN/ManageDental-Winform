using System.Windows.Forms;
namespace ManagerPartient.Gui
{
    partial class PanelBackupData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelBackupData));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDatabaseName = new System.Windows.Forms.ComboBox();
            this.lblThongSoDatabase = new ManagerPartient.CustomControl.LabelEX();
            this.cbServerName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPathFile = new ManagerPartient.CustomControl.TextBoxEX();
            this.btnChooseFile = new ManagerPartient.CustomControl.ButtonEX();
            this.lblPathFile = new ManagerPartient.CustomControl.LabelEX();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tablePanelMain.SuspendLayout();
            this.tablePanelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.grbChooseFile.SuspendLayout();
            this.tablePanelChooseFile.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
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
            this.lblTextNote3.Text = "* Lựa chọn 2: Sao lưu dữ liệu danh sách bệnh nhân ra file Excel.";
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
            this.lblText1.Text = "Chào mừng bạn đã đến với công cụ hỗ trợ sao lưu dữ liệu";
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
            this.lblTextNote2.Text = "* Lựa chọn 1: Sao lưu toàn bộ dữ liệu trong hệ thống.";
            this.lblTextNote2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextNote1
            // 
            this.lblTextNote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNote1.ForeColor = System.Drawing.Color.Red;
            this.lblTextNote1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTextNote1.Location = new System.Drawing.Point(3, 149);
            this.lblTextNote1.Name = "lblTextNote1";
            this.lblTextNote1.Size = new System.Drawing.Size(504, 25);
            this.lblTextNote1.TabIndex = 2;
            this.lblTextNote1.Text = "Lưu ý: Có 2 hình thức sao lưu dữ liệu, bạn có thể lựa chọn đề mục như sau:";
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
            this.tablePanelChooseFile.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tablePanelChooseFile.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tablePanelChooseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelChooseFile.Location = new System.Drawing.Point(3, 16);
            this.tablePanelChooseFile.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanelChooseFile.Name = "tablePanelChooseFile";
            this.tablePanelChooseFile.RowCount = 3;
            this.tablePanelChooseFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanelChooseFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanelChooseFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePanelChooseFile.Size = new System.Drawing.Size(738, 95);
            this.tablePanelChooseFile.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(732, 25);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rbInsertData
            // 
            this.rbInsertData.AutoSize = true;
            this.rbInsertData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbInsertData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInsertData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbInsertData.Location = new System.Drawing.Point(444, 3);
            this.rbInsertData.Name = "rbInsertData";
            this.rbInsertData.Size = new System.Drawing.Size(285, 19);
            this.rbInsertData.TabIndex = 2;
            this.rbInsertData.Text = "Lựa chọn 2: Sao lưu danh sách bệnh nhân";
            this.rbInsertData.UseVisualStyleBackColor = true;
            this.rbInsertData.CheckedChanged += new System.EventHandler(this.rbInsertData_CheckedChanged);
            // 
            // rbRetoreAll
            // 
            this.rbRetoreAll.AutoSize = true;
            this.rbRetoreAll.Checked = true;
            this.rbRetoreAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbRetoreAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRetoreAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRetoreAll.Location = new System.Drawing.Point(153, 3);
            this.rbRetoreAll.Name = "rbRetoreAll";
            this.rbRetoreAll.Size = new System.Drawing.Size(285, 19);
            this.rbRetoreAll.TabIndex = 1;
            this.rbRetoreAll.TabStop = true;
            this.rbRetoreAll.Text = "Lựa chọn 1: Sao lưu toàn bộ dữ liệu ";
            this.rbRetoreAll.UseVisualStyleBackColor = true;
            this.rbRetoreAll.CheckedChanged += new System.EventHandler(this.rbRetoreAll_CheckedChanged);
            // 
            // labelEX1
            // 
            this.labelEX1.AutoSize = true;
            this.labelEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEX1.Location = new System.Drawing.Point(3, 0);
            this.labelEX1.Name = "labelEX1";
            this.labelEX1.Size = new System.Drawing.Size(144, 25);
            this.labelEX1.TabIndex = 3;
            this.labelEX1.Text = "Thao tác với dữ liệu";
            this.labelEX1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbDatabaseName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblThongSoDatabase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbServerName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 27);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cbDatabaseName
            // 
            this.cbDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDatabaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabaseName.Enabled = false;
            this.cbDatabaseName.FormattingEnabled = true;
            this.cbDatabaseName.Location = new System.Drawing.Point(444, 3);
            this.cbDatabaseName.Name = "cbDatabaseName";
            this.cbDatabaseName.Size = new System.Drawing.Size(285, 21);
            this.cbDatabaseName.TabIndex = 2;
            // 
            // lblThongSoDatabase
            // 
            this.lblThongSoDatabase.AutoSize = true;
            this.lblThongSoDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThongSoDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongSoDatabase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblThongSoDatabase.Location = new System.Drawing.Point(3, 0);
            this.lblThongSoDatabase.Name = "lblThongSoDatabase";
            this.lblThongSoDatabase.Size = new System.Drawing.Size(144, 27);
            this.lblThongSoDatabase.TabIndex = 0;
            this.lblThongSoDatabase.Text = "Thông số database";
            this.lblThongSoDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbServerName
            // 
            this.cbServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerName.Enabled = false;
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.Location = new System.Drawing.Point(153, 3);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(285, 21);
            this.cbServerName.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtPathFile, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChooseFile, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPathFile, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(732, 25);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // txtPathFile
            // 
            this.txtPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathFile.ClearTextDefaultForcus = false;
            this.txtPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPathFile.Location = new System.Drawing.Point(153, 0);
            this.txtPathFile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtPathFile.Multiline = true;
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(476, 23);
            this.txtPathFile.TabIndex = 5;
            this.txtPathFile.TextDefault = null;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChooseFile.Location = new System.Drawing.Point(635, 0);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(94, 25);
            this.btnChooseFile.TabIndex = 4;
            this.btnChooseFile.Text = "Thư mục";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblPathFile
            // 
            this.lblPathFile.AutoSize = true;
            this.lblPathFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPathFile.Location = new System.Drawing.Point(3, 0);
            this.lblPathFile.Name = "lblPathFile";
            this.lblPathFile.Size = new System.Drawing.Size(144, 25);
            this.lblPathFile.TabIndex = 6;
            this.lblPathFile.Text = "Đường dẫn lưu file";
            this.lblPathFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelBackupData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanelMain);
            this.Name = "PanelBackupData";
            this.Size = new System.Drawing.Size(750, 400);
            this.tablePanelMain.ResumeLayout(false);
            this.tablePanelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.grbChooseFile.ResumeLayout(false);
            this.tablePanelChooseFile.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tablePanelMain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.RadioButton rbInsertData;
        private System.Windows.Forms.RadioButton rbRetoreAll;
        private System.Windows.Forms.TableLayoutPanel tablePanelChooseFile;
        private System.Windows.Forms.GroupBox grbChooseFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tablePanelTop;
        private CustomControl.LabelEX lblTextNote3;
        private CustomControl.LabelEX lblText1;
        private CustomControl.LabelEX lblText2;
        private CustomControl.LabelEX lblTextNote2;
        private CustomControl.LabelEX lblTextNote1;
        private FolderBrowserDialog folderBrowserDialog;
        private CustomControl.LabelEX labelEX1;

        #endregion

        private CustomControl.LabelEX lblThongSoDatabase;
        private ComboBox cbDatabaseName;
        private ComboBox cbServerName;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControl.TextBoxEX txtPathFile;
        private CustomControl.ButtonEX btnChooseFile;
        private CustomControl.LabelEX lblPathFile;
    }
}

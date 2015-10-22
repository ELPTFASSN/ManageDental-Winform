using ManageSoftware.Core;
namespace ManageSoftware.Gui
{
    partial class FormDialogMain
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
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblTitleDiscription = new System.Windows.Forms.Label();
            this.tableLayoutBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnFunction1 = new System.Windows.Forms.Button();
            this.btnFunction2 = new System.Windows.Forms.Button();
            this.btnFunction3 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tableLayoutBottom.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutMain.Controls.Add(this.tableLayoutBottom, 0, 2);
            this.tableLayoutMain.Controls.Add(this.panelMain, 0, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutMain.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutMain.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.ColumnCount = 1;
            this.panelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTop.Controls.Add(this.lblTitle, 0, 0);
            this.panelTop.Controls.Add(this.lblLine1, 0, 2);
            this.panelTop.Controls.Add(this.lblTitleDiscription, 0, 1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.RowCount = 3;
            this.panelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTop.Size = new System.Drawing.Size(784, 60);
            this.panelTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(778, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Name function";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblLine1
            // 
            this.lblLine1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLine1.Location = new System.Drawing.Point(3, 54);
            this.lblLine1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(778, 1);
            this.lblLine1.TabIndex = 2;
            // 
            // lblTitleDiscription
            // 
            this.lblTitleDiscription.AutoSize = true;
            this.lblTitleDiscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDiscription.Location = new System.Drawing.Point(3, 27);
            this.lblTitleDiscription.Name = "lblTitleDiscription";
            this.lblTitleDiscription.Size = new System.Drawing.Size(778, 27);
            this.lblTitleDiscription.TabIndex = 1;
            this.lblTitleDiscription.Text = "Introduce generalized functions";
            // 
            // tableLayoutBottom
            // 
            this.tableLayoutBottom.ColumnCount = 1;
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBottom.Controls.Add(this.lblLine2, 0, 0);
            this.tableLayoutBottom.Controls.Add(this.panelBottom, 0, 1);
            this.tableLayoutBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutBottom.Location = new System.Drawing.Point(0, 501);
            this.tableLayoutBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutBottom.Name = "tableLayoutBottom";
            this.tableLayoutBottom.RowCount = 2;
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBottom.Size = new System.Drawing.Size(784, 60);
            this.tableLayoutBottom.TabIndex = 5;
            // 
            // lblLine2
            // 
            this.lblLine2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLine2.Location = new System.Drawing.Point(3, 3);
            this.lblLine2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(778, 1);
            this.lblLine2.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnHuy);
            this.panelBottom.Controls.Add(this.btnHoanThanh);
            this.panelBottom.Controls.Add(this.btnFunction1);
            this.panelBottom.Controls.Add(this.btnFunction2);
            this.panelBottom.Controls.Add(this.btnFunction3);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelBottom.Location = new System.Drawing.Point(0, 4);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.panelBottom.Size = new System.Drawing.Size(784, 56);
            this.panelBottom.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(703, 13);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 30);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.Location = new System.Drawing.Point(598, 13);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(100, 30);
            this.btnHoanThanh.TabIndex = 0;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnFunction1
            // 
            this.btnFunction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction1.Location = new System.Drawing.Point(493, 13);
            this.btnFunction1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFunction1.Name = "btnFunction1";
            this.btnFunction1.Size = new System.Drawing.Size(100, 30);
            this.btnFunction1.TabIndex = 2;
            this.btnFunction1.Text = "Chức năng 1";
            this.btnFunction1.UseVisualStyleBackColor = true;
            this.btnFunction1.Visible = false;
            // 
            // btnFunction2
            // 
            this.btnFunction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction2.Location = new System.Drawing.Point(388, 13);
            this.btnFunction2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFunction2.Name = "btnFunction2";
            this.btnFunction2.Size = new System.Drawing.Size(100, 30);
            this.btnFunction2.TabIndex = 3;
            this.btnFunction2.Text = "Chức năng 2";
            this.btnFunction2.UseVisualStyleBackColor = true;
            this.btnFunction2.Visible = false;
            // 
            // btnFunction3
            // 
            this.btnFunction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction3.Location = new System.Drawing.Point(283, 13);
            this.btnFunction3.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFunction3.Name = "btnFunction3";
            this.btnFunction3.Size = new System.Drawing.Size(100, 30);
            this.btnFunction3.TabIndex = 4;
            this.btnFunction3.Text = "Chức năng 3";
            this.btnFunction3.UseVisualStyleBackColor = true;
            this.btnFunction3.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 63);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0, 3, 0, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(784, 433);
            this.panelMain.TabIndex = 6;
            // 
            // FormDialogMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDialogMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Title";
            this.tableLayoutMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutBottom.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.String TitleForm
        { 
            set { this.lblTitle.Text = value;}
            get { return this.lblTitle.Text; }
        }

        public System.String DesciptionForm
        {
            set { this.lblTitleDiscription.Text = value; }
            get { return this.lblTitleDiscription.Text; }
        }

        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblTitleDiscription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel panelTop;
        private System.Windows.Forms.FlowLayoutPanel panelBottom;
        private System.Windows.Forms.Button btnFunction1;
        private System.Windows.Forms.Button btnFunction2;
        private System.Windows.Forms.Button btnFunction3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBottom;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Panel panelMain;
    }
}
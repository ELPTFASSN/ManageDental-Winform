using System;
using System.Drawing;
using System.Windows.Forms;
namespace ManagerPartient.CustomControl
{
    partial class ButtonFunction
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
            this.tablePanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameButton = new System.Windows.Forms.Label();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.ptrBoxImage = new System.Windows.Forms.PictureBox();
            this.tablePanelMain.SuspendLayout();
            this.tablePanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanelMain
            // 
            this.tablePanelMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tablePanelMain.ColumnCount = 2;
            this.tablePanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablePanelMain.Controls.Add(this.tablePanelContent, 1, 0);
            this.tablePanelMain.Controls.Add(this.ptrBoxImage, 0, 0);
            this.tablePanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelMain.Location = new System.Drawing.Point(0, 0);
            this.tablePanelMain.Name = "tablePanelMain";
            this.tablePanelMain.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanelMain.RowCount = 1;
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelMain.Size = new System.Drawing.Size(330, 100);
            this.tablePanelMain.TabIndex = 0;
            // 
            // tablePanelContent
            // 
            this.tablePanelContent.BackColor = System.Drawing.Color.Transparent;
            this.tablePanelContent.ColumnCount = 1;
            this.tablePanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelContent.Controls.Add(this.lblNameButton, 0, 0);
            this.tablePanelContent.Controls.Add(this.lblDescription1, 0, 1);
            this.tablePanelContent.Controls.Add(this.lblDescription2, 0, 2);
            this.tablePanelContent.Controls.Add(this.lblDescription3, 0, 3);
            this.tablePanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelContent.Location = new System.Drawing.Point(136, 8);
            this.tablePanelContent.Name = "tablePanelContent";
            this.tablePanelContent.RowCount = 4;
            this.tablePanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelContent.Size = new System.Drawing.Size(186, 84);
            this.tablePanelContent.TabIndex = 0;
            // 
            // lblNameButton
            // 
            this.lblNameButton.AutoSize = true;
            this.lblNameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNameButton.Location = new System.Drawing.Point(3, 0);
            this.lblNameButton.Name = "lblNameButton";
            this.lblNameButton.Size = new System.Drawing.Size(180, 21);
            this.lblNameButton.TabIndex = 0;
            this.lblNameButton.Text = "Title button";
            // 
            // lblDescription1
            // 
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription1.Location = new System.Drawing.Point(3, 21);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(180, 21);
            this.lblDescription1.TabIndex = 1;
            this.lblDescription1.Text = "- Mô tả chức năng 1";
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription2.Location = new System.Drawing.Point(3, 42);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(180, 21);
            this.lblDescription2.TabIndex = 2;
            this.lblDescription2.Text = "- Mô tả chức năng 2";
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription3.Location = new System.Drawing.Point(3, 63);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(180, 21);
            this.lblDescription3.TabIndex = 3;
            this.lblDescription3.Text = "- Mô tả chức năng 3";
            // 
            // ptrBoxImage
            // 
            this.ptrBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.ptrBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptrBoxImage.Location = new System.Drawing.Point(8, 8);
            this.ptrBoxImage.Name = "ptrBoxImage";
            this.ptrBoxImage.Size = new System.Drawing.Size(122, 84);
            this.ptrBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrBoxImage.TabIndex = 1;
            this.ptrBoxImage.TabStop = false;
            // 
            // ButtonFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManagerPartient.Properties.Resources.background_button_hover;
            this.Controls.Add(this.tablePanelMain);
            this.Name = "ButtonFunction";
            this.Size = new System.Drawing.Size(330, 100);
            this.tablePanelMain.ResumeLayout(false);
            this.tablePanelContent.ResumeLayout(false);
            this.tablePanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanelMain;
        private System.Windows.Forms.TableLayoutPanel tablePanelContent;        
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.PictureBox ptrBoxImage;
        private System.Windows.Forms.Label lblNameButton;
        private Color colorOriginal = Color.Empty;
        private String groupButtonName;

        public String GroupButtonName
        {
            get { return groupButtonName; }
            set { groupButtonName = value; }
        }

        public Color TablePanelMainBackColor
        {
            get { return tablePanelMain.BackColor; }
            set 
            { 
                tablePanelMain.BackColor = value;
                if (colorOriginal == Color.Empty)
                    colorOriginal = value;
            }
        }

        public Color ColorOriginal
        {
            get { return colorOriginal; }
        }

        public Image TablePanelMainBackgroundImage
        {
            get { return tablePanelMain.BackgroundImage; }
            set { tablePanelMain.BackgroundImage = value; }
        }

        public Image PtrBoxImage
        {
            get { return ptrBoxImage.Image; }
            set { ptrBoxImage.Image = value; }
        }

        public String NameButtonText
        {
            get { return lblNameButton.Text; }
            set { lblNameButton.Text = value; }
        }

        public String TextDescription1
        {
            get { return lblDescription1.Text; }
            set { lblDescription1.Text = value; }
        }

        public String TextDescription2
        {
            get { return lblDescription2.Text; }
            set { lblDescription2.Text = value; }
        }

        public String TextDescription3
        {
            get { return lblDescription3.Text; }
            set { lblDescription3.Text = value; }
        }

    }
}

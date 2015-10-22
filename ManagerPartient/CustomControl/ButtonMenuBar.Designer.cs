using System;
using System.Drawing;
namespace ManagerPartient.CustomControl
{
    partial class ButtonMenuBar
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
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.lblTitleButton = new System.Windows.Forms.Label();
            this.lblDescriptionButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbIcon
            // 
            this.ptbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ptbIcon.Location = new System.Drawing.Point(0, 0);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(50, 65);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbIcon.TabIndex = 0;
            this.ptbIcon.TabStop = false;
            this.ptbIcon.Click += new System.EventHandler(this.ptbIcon_Click);
            this.ptbIcon.MouseEnter += new System.EventHandler(this.ptbIcon_MouseEnter);
            this.ptbIcon.MouseLeave += new System.EventHandler(this.ptbIcon_MouseLeave);
            // 
            // lblTitleButton
            // 
            this.lblTitleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleButton.Location = new System.Drawing.Point(50, 0);
            this.lblTitleButton.Name = "lblTitleButton";
            this.lblTitleButton.Size = new System.Drawing.Size(210, 35);
            this.lblTitleButton.TabIndex = 1;
            this.lblTitleButton.Text = "Name Button";
            this.lblTitleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleButton.Click += new System.EventHandler(this.lblTitleButton_Click);
            this.lblTitleButton.MouseEnter += new System.EventHandler(this.lblTitleButton_MouseEnter);
            this.lblTitleButton.MouseLeave += new System.EventHandler(this.lblTitleButton_MouseLeave);
            // 
            // lblDescriptionButton
            // 
            this.lblDescriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescriptionButton.Location = new System.Drawing.Point(50, 35);
            this.lblDescriptionButton.Name = "lblDescriptionButton";
            this.lblDescriptionButton.Size = new System.Drawing.Size(210, 30);
            this.lblDescriptionButton.TabIndex = 2;
            this.lblDescriptionButton.Text = "Introduct Button";
            this.lblDescriptionButton.Click += new System.EventHandler(this.lblDescriptionButton_Click);
            this.lblDescriptionButton.MouseEnter += new System.EventHandler(this.lblDescriptionButton_MouseEnter);
            this.lblDescriptionButton.MouseLeave += new System.EventHandler(this.lblDescriptionButton_MouseLeave);
            // 
            // ButtonMenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ptbIcon);
            this.Controls.Add(this.lblDescriptionButton);
            this.Controls.Add(this.lblTitleButton);
            this.Name = "ButtonMenuBar";
            this.Size = new System.Drawing.Size(250, 65);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbIcon;       
        private System.Windows.Forms.Label lblTitleButton;
        private System.Windows.Forms.Label lblDescriptionButton;

        public System.Windows.Forms.Label LblDescriptionButton
        {
            get { return lblDescriptionButton; }
            set { lblDescriptionButton = value; }
        }

        public System.Windows.Forms.Label LblTitleButton
        {
            get { return lblTitleButton; }
            set { lblTitleButton = value; }
        }

        public System.Windows.Forms.PictureBox PtbIcon
        {
            get { return ptbIcon; }
            set { ptbIcon = value; }
        }

        public Image ImageIconButton
        {
            get { return ptbIcon.Image; }
            set { ptbIcon.Image = value; }
        }

        public String TextTitleButton
        {
            get { return lblTitleButton.Text; }
            set { lblTitleButton.Text = value; }
        }

        public String TextDescriptionButton
        {
            get { return lblDescriptionButton.Text; }
            set { lblDescriptionButton.Text = value; }
        }
    }
}

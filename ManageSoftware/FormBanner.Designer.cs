namespace ManageSoftware
{
    partial class FormBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanner));
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new ManageSoftware.CustomControl.ProgressBarEx();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.progressBar.Border = false;
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.GradiantColor = System.Drawing.Color.DodgerBlue;
            this.progressBar.GradiantPosition = ManageSoftware.CustomControl.ProgressBarEx.GradiantArea.Center;
            this.progressBar.Image = null;
            this.progressBar.Location = new System.Drawing.Point(132, 187);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.Orange;
            this.progressBar.RoundedCorners = false;
            this.progressBar.ShowPercentage = true;
            this.progressBar.Size = new System.Drawing.Size(339, 24);
            // 
            // FormBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogoBanner";
            this.TransparencyKey = System.Drawing.Color.Orange;
            this.Load += new System.EventHandler(this.frBanner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ManageSoftware.CustomControl.ProgressBarEx progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;

        public ManageSoftware.CustomControl.ProgressBarEx ProgressBar
        {
            get { return progressBar; }
            set { progressBar = value; }
        }

    }
}
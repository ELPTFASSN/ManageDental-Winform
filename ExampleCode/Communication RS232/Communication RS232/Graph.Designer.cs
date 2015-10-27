namespace Communication_RS232
{
    partial class Graph
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.cbxCb1 = new System.Windows.Forms.CheckBox();
            this.cbxCb2 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(990, 418);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Lime;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHide.ForeColor = System.Drawing.Color.Black;
            this.btnHide.Location = new System.Drawing.Point(866, 457);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(85, 55);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Ẩn";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPause.Location = new System.Drawing.Point(718, 457);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(81, 55);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Dừng";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // cbxCb1
            // 
            this.cbxCb1.AutoSize = true;
            this.cbxCb1.BackColor = System.Drawing.Color.Transparent;
            this.cbxCb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxCb1.Location = new System.Drawing.Point(189, 457);
            this.cbxCb1.Name = "cbxCb1";
            this.cbxCb1.Size = new System.Drawing.Size(98, 20);
            this.cbxCb1.TabIndex = 3;
            this.cbxCb1.Text = "NHIỆT ĐỘ";
            this.cbxCb1.UseVisualStyleBackColor = false;
            // 
            // cbxCb2
            // 
            this.cbxCb2.AutoSize = true;
            this.cbxCb2.BackColor = System.Drawing.Color.Transparent;
            this.cbxCb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxCb2.Location = new System.Drawing.Point(311, 457);
            this.cbxCb2.Name = "cbxCb2";
            this.cbxCb2.Size = new System.Drawing.Size(15, 14);
            this.cbxCb2.TabIndex = 4;
            this.cbxCb2.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Communication_RS232.Properties.Resources.blue_sky_dsc03155_wp;
            this.ClientSize = new System.Drawing.Size(1014, 531);
            this.Controls.Add(this.cbxCb2);
            this.Controls.Add(this.cbxCb1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.zedGraphControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graph";
            this.Text = "Đồ thị";
            this.Load += new System.EventHandler(this.Graph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.CheckBox cbxCb1;
        private System.Windows.Forms.CheckBox cbxCb2;
        private System.Windows.Forms.Timer timer1;
    }
}
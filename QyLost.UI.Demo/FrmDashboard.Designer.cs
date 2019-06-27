namespace QyLost.UI.Demo
{
    partial class FrmDashboard
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
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.dashboard = new QyLost.UI.Chart.Dashboard();
            this.btnShowAnimation = new QyLost.UI.Demo.UButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(445, 608);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(662, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.dashboard;
            this.propertyGrid.Size = new System.Drawing.Size(439, 718);
            this.propertyGrid.TabIndex = 3;
            // 
            // dashboard
            // 
            this.dashboard.BottomTitleColor = System.Drawing.Color.Blue;
            this.dashboard.BottomTitleFont = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.dashboard.Expected = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dashboard.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.dashboard.ForeColor = System.Drawing.Color.Red;
            this.dashboard.IndicatorAngle = 60;
            this.dashboard.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dashboard.IndicatorFill = true;
            this.dashboard.InnerBackground = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(198)))), ((int)(((byte)(254)))));
            this.dashboard.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(168)))));
            this.dashboard.InnerRoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.dashboard.Location = new System.Drawing.Point(445, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.dashboard.ProgressColor = System.Drawing.Color.Gray;
            this.dashboard.ProgressDisplayModel = QyLost.UI.Chart.Dashboard.ProgressModel.Inner;
            this.dashboard.Real = new decimal(new int[] {
            69,
            0,
            0,
            0});
            this.dashboard.ScaleExpectedColor = System.Drawing.Color.Blue;
            this.dashboard.ScaleRealColor = System.Drawing.Color.Yellow;
            this.dashboard.Size = new System.Drawing.Size(662, 602);
            this.dashboard.TabIndex = 5;
            this.dashboard.Text = "Progress";
            // 
            // btnShowAnimation
            // 
            this.btnShowAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAnimation.ForeColor = System.Drawing.Color.White;
            this.btnShowAnimation.Location = new System.Drawing.Point(896, 659);
            this.btnShowAnimation.Name = "btnShowAnimation";
            this.btnShowAnimation.Size = new System.Drawing.Size(211, 47);
            this.btnShowAnimation.TabIndex = 4;
            this.btnShowAnimation.Text = "Show Animation";
            this.btnShowAnimation.UseVisualStyleBackColor = false;
            this.btnShowAnimation.Click += new System.EventHandler(this.btnShowAnimation_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 718);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.btnShowAnimation);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.trackBar);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private UButton btnShowAnimation;
        private Chart.Dashboard dashboard;
    }
}
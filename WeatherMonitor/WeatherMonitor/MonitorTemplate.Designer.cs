namespace WeatherMonitor
{
    partial class MonitorTemplate
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
            this.gaugeTemp = new LiveCharts.WinForms.SolidGauge();
            this.gaugeRainfall = new LiveCharts.WinForms.SolidGauge();
            this.gBoxLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLocationHeader = new System.Windows.Forms.Label();
            this.lblTemperatureHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gaugeTemp
            // 
            this.gaugeTemp.Location = new System.Drawing.Point(69, 38);
            this.gaugeTemp.Name = "gaugeTemp";
            this.gaugeTemp.Size = new System.Drawing.Size(213, 178);
            this.gaugeTemp.TabIndex = 0;
            this.gaugeTemp.Text = "gaugeTemp";
            // 
            // gaugeRainfall
            // 
            this.gaugeRainfall.Location = new System.Drawing.Point(69, 263);
            this.gaugeRainfall.Name = "gaugeRainfall";
            this.gaugeRainfall.Size = new System.Drawing.Size(213, 178);
            this.gaugeRainfall.TabIndex = 1;
            this.gaugeRainfall.Text = "gaugeTemp";
            // 
            // gBoxLocation
            // 
            this.gBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.gBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxLocation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gBoxLocation.Location = new System.Drawing.Point(-4, -3);
            this.gBoxLocation.Name = "gBoxLocation";
            this.gBoxLocation.Size = new System.Drawing.Size(946, 102);
            this.gBoxLocation.TabIndex = 43;
            this.gBoxLocation.Text = "Melbourne (Olympic park)";
            this.gBoxLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(385, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 330);
            this.label1.TabIndex = 44;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(385, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 127);
            this.label2.TabIndex = 45;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocationHeader
            // 
            this.lblLocationHeader.AutoSize = true;
            this.lblLocationHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLocationHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLocationHeader.ForeColor = System.Drawing.Color.White;
            this.lblLocationHeader.Location = new System.Drawing.Point(1, 1);
            this.lblLocationHeader.Name = "lblLocationHeader";
            this.lblLocationHeader.Size = new System.Drawing.Size(104, 25);
            this.lblLocationHeader.TabIndex = 47;
            this.lblLocationHeader.Text = "Location";
            // 
            // lblTemperatureHeader
            // 
            this.lblTemperatureHeader.AutoSize = true;
            this.lblTemperatureHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblTemperatureHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTemperatureHeader.ForeColor = System.Drawing.Color.White;
            this.lblTemperatureHeader.Location = new System.Drawing.Point(94, 10);
            this.lblTemperatureHeader.Name = "lblTemperatureHeader";
            this.lblTemperatureHeader.Size = new System.Drawing.Size(164, 25);
            this.lblTemperatureHeader.TabIndex = 48;
            this.lblTemperatureHeader.Text = "Temperature: ";
            this.lblTemperatureHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Rainfall: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.gaugeTemp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gaugeRainfall);
            this.panel1.Controls.Add(this.lblTemperatureHeader);
            this.panel1.Location = new System.Drawing.Point(1, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 453);
            this.panel1.TabIndex = 50;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(386, 433);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(556, 127);
            this.txtOut.TabIndex = 51;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.ForeColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Location = new System.Drawing.Point(386, 101);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(556, 330);
            this.cartesianChart1.TabIndex = 52;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 20000;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // MonitorTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(942, 557);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLocationHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBoxLocation);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.Name = "MonitorTemplate";
            this.Text = "MonitorTemplate";
            this.Load += new System.EventHandler(this.MonitorTemplate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.SolidGauge gaugeTemp;
        private LiveCharts.WinForms.SolidGauge gaugeRainfall;
        private System.Windows.Forms.Label gBoxLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLocationHeader;
        private System.Windows.Forms.Label lblTemperatureHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOut;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
namespace WeatherMonitor

{

    partial class lab

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lab));
            this.lblNav = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxLocation = new System.Windows.Forms.ComboBox();
            this.lblLocationcbox = new System.Windows.Forms.Label();
            this.lbMonitors = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbxRain = new System.Windows.Forms.CheckBox();
            this.cbxTemp = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.gBoxLocation = new System.Windows.Forms.Label();
            this.gBoxLastUpdated = new System.Windows.Forms.Label();
            this.lblLocationHeader = new System.Windows.Forms.Label();
            this.lblTemperatureHeader = new System.Windows.Forms.Label();
            this.lblRainfallHeader = new System.Windows.Forms.Label();
            this.lblLastUpdatedHeader = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gaugeTemp = new LiveCharts.WinForms.SolidGauge();
            this.gaugeRainfall = new LiveCharts.WinForms.SolidGauge();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbx5min = new System.Windows.Forms.RadioButton();
            this.rbx20s = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveForms = new System.Windows.Forms.Button();
            this.lb20s = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNav
            // 
            this.lblNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNav.Location = new System.Drawing.Point(0, 0);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(284, 539);
            this.lblNav.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(23, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 66);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dynamic Hunter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cBoxLocation
            // 
            this.cBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxLocation.FormattingEnabled = true;
            this.cBoxLocation.Items.AddRange(new object[] {
            "Free State Orange Farm"});
            this.cBoxLocation.Location = new System.Drawing.Point(93, 61);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(163, 21);
            this.cBoxLocation.TabIndex = 17;
            this.cBoxLocation.Text = "Please Make a Selection";
            // 
            // lblLocationcbox
            // 
            this.lblLocationcbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblLocationcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLocationcbox.ForeColor = System.Drawing.Color.White;
            this.lblLocationcbox.Location = new System.Drawing.Point(20, 61);
            this.lblLocationcbox.Name = "lblLocationcbox";
            this.lblLocationcbox.Size = new System.Drawing.Size(67, 21);
            this.lblLocationcbox.TabIndex = 18;
            this.lblLocationcbox.Text = "Location";
            // 
            // lbMonitors
            // 
            this.lbMonitors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMonitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonitors.FormattingEnabled = true;
            this.lbMonitors.Location = new System.Drawing.Point(4, 21);
            this.lbMonitors.Name = "lbMonitors";
            this.lbMonitors.Size = new System.Drawing.Size(264, 108);
            this.lbMonitors.TabIndex = 19;
            this.lbMonitors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(290, 60);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 44);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxRain
            // 
            this.cbxRain.AutoSize = true;
            this.cbxRain.Checked = true;
            this.cbxRain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxRain.ForeColor = System.Drawing.SystemColors.Control;
            this.cbxRain.Location = new System.Drawing.Point(23, 85);
            this.cbxRain.Name = "cbxRain";
            this.cbxRain.Size = new System.Drawing.Size(61, 24);
            this.cbxRain.TabIndex = 29;
            this.cbxRain.Text = "Rain";
            this.cbxRain.UseVisualStyleBackColor = true;
            // 
            // cbxTemp
            // 
            this.cbxTemp.AutoSize = true;
            this.cbxTemp.Checked = true;
            this.cbxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.cbxTemp.Location = new System.Drawing.Point(23, 110);
            this.cbxTemp.Name = "cbxTemp";
            this.cbxTemp.Size = new System.Drawing.Size(119, 24);
            this.cbxTemp.TabIndex = 30;
            this.cbxTemp.Text = "Temperature";
            this.cbxTemp.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblLastUpdated.Font = new System.Drawing.Font("Century Gothic", 27.5F);
            this.lblLastUpdated.ForeColor = System.Drawing.Color.White;
            this.lblLastUpdated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastUpdated.Location = new System.Drawing.Point(290, 423);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(0, 44);
            this.lblLastUpdated.TabIndex = 34;
            this.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxLocation
            // 
            this.gBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.gBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxLocation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gBoxLocation.Location = new System.Drawing.Point(284, 0);
            this.gBoxLocation.Name = "gBoxLocation";
            this.gBoxLocation.Size = new System.Drawing.Size(632, 118);
            this.gBoxLocation.TabIndex = 42;
            this.gBoxLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxLastUpdated
            // 
            this.gBoxLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxLastUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.gBoxLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxLastUpdated.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gBoxLastUpdated.Location = new System.Drawing.Point(286, 427);
            this.gBoxLastUpdated.Name = "gBoxLastUpdated";
            this.gBoxLastUpdated.Size = new System.Drawing.Size(630, 111);
            this.gBoxLastUpdated.TabIndex = 43;
            this.gBoxLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocationHeader
            // 
            this.lblLocationHeader.AutoSize = true;
            this.lblLocationHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLocationHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLocationHeader.ForeColor = System.Drawing.Color.White;
            this.lblLocationHeader.Location = new System.Drawing.Point(284, 0);
            this.lblLocationHeader.Name = "lblLocationHeader";
            this.lblLocationHeader.Size = new System.Drawing.Size(104, 25);
            this.lblLocationHeader.TabIndex = 46;
            this.lblLocationHeader.Text = "Location";
            // 
            // lblTemperatureHeader
            // 
            this.lblTemperatureHeader.AutoSize = true;
            this.lblTemperatureHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblTemperatureHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTemperatureHeader.ForeColor = System.Drawing.Color.White;
            this.lblTemperatureHeader.Location = new System.Drawing.Point(367, 134);
            this.lblTemperatureHeader.Name = "lblTemperatureHeader";
            this.lblTemperatureHeader.Size = new System.Drawing.Size(152, 25);
            this.lblTemperatureHeader.TabIndex = 47;
            this.lblTemperatureHeader.Text = "Temperature";
            // 
            // lblRainfallHeader
            // 
            this.lblRainfallHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRainfallHeader.AutoSize = true;
            this.lblRainfallHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblRainfallHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblRainfallHeader.ForeColor = System.Drawing.Color.White;
            this.lblRainfallHeader.Location = new System.Drawing.Point(707, 134);
            this.lblRainfallHeader.Name = "lblRainfallHeader";
            this.lblRainfallHeader.Size = new System.Drawing.Size(91, 25);
            this.lblRainfallHeader.TabIndex = 48;
            this.lblRainfallHeader.Text = "Rainfall";
            // 
            // lblLastUpdatedHeader
            // 
            this.lblLastUpdatedHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastUpdatedHeader.AutoSize = true;
            this.lblLastUpdatedHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLastUpdatedHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLastUpdatedHeader.ForeColor = System.Drawing.Color.White;
            this.lblLastUpdatedHeader.Location = new System.Drawing.Point(284, 427);
            this.lblLastUpdatedHeader.Name = "lblLastUpdatedHeader";
            this.lblLastUpdatedHeader.Size = new System.Drawing.Size(155, 25);
            this.lblLastUpdatedHeader.TabIndex = 49;
            this.lblLastUpdatedHeader.Text = "Last updated";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Silver;
            this.btnRemove.Location = new System.Drawing.Point(4, 130);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(264, 21);
            this.btnRemove.TabIndex = 50;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gaugeTemp
            // 
            this.gaugeTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gaugeTemp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gaugeTemp.Location = new System.Drawing.Point(296, 170);
            this.gaugeTemp.Name = "gaugeTemp";
            this.gaugeTemp.Size = new System.Drawing.Size(300, 245);
            this.gaugeTemp.TabIndex = 53;
            this.gaugeTemp.Text = "solidGauge1";
            // 
            // gaugeRainfall
            // 
            this.gaugeRainfall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gaugeRainfall.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gaugeRainfall.Location = new System.Drawing.Point(601, 170);
            this.gaugeRainfall.Name = "gaugeRainfall";
            this.gaugeRainfall.Size = new System.Drawing.Size(300, 245);
            this.gaugeRainfall.TabIndex = 54;
            this.gaugeRainfall.Text = "solidGauge2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.groupBox1.Controls.Add(this.rbx5min);
            this.groupBox1.Controls.Add(this.rbx20s);
            this.groupBox1.Controls.Add(this.cBoxLocation);
            this.groupBox1.Controls.Add(this.cbxTemp);
            this.groupBox1.Controls.Add(this.cbxRain);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblLocationcbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(6, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 181);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Monitor";
            // 
            // rbx5min
            // 
            this.rbx5min.Checked = true;
            this.rbx5min.Location = new System.Drawing.Point(152, 26);
            this.rbx5min.Name = "rbx5min";
            this.rbx5min.Size = new System.Drawing.Size(104, 24);
            this.rbx5min.TabIndex = 0;
            this.rbx5min.TabStop = true;
            this.rbx5min.Text = "5 Minute";
            this.rbx5min.Click += new System.EventHandler(this.rbx5min_Click);
            // 
            // rbx20s
            // 
            this.rbx20s.AutoSize = true;
            this.rbx20s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbx20s.Location = new System.Drawing.Point(23, 26);
            this.rbx20s.Name = "rbx20s";
            this.rbx20s.Size = new System.Drawing.Size(104, 24);
            this.rbx20s.TabIndex = 31;
            this.rbx20s.Text = "20 Second";
            this.rbx20s.UseVisualStyleBackColor = true;
            this.rbx20s.Click += new System.EventHandler(this.rbx20s_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.groupBox2.Controls.Add(this.btnRemoveForms);
            this.groupBox2.Controls.Add(this.lb20s);
            this.groupBox2.Controls.Add(this.lbMonitors);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(6, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 290);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitors";
            // 
            // btnRemoveForms
            // 
            this.btnRemoveForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnRemoveForms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveForms.ForeColor = System.Drawing.Color.Silver;
            this.btnRemoveForms.Location = new System.Drawing.Point(4, 261);
            this.btnRemoveForms.Name = "btnRemoveForms";
            this.btnRemoveForms.Size = new System.Drawing.Size(264, 21);
            this.btnRemoveForms.TabIndex = 52;
            this.btnRemoveForms.Text = "Remove";
            this.btnRemoveForms.UseVisualStyleBackColor = false;
            this.btnRemoveForms.Click += new System.EventHandler(this.btnRemoveForms_Click);
            // 
            // lb20s
            // 
            this.lb20s.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb20s.FormattingEnabled = true;
            this.lb20s.Location = new System.Drawing.Point(4, 153);
            this.lb20s.Name = "lb20s";
            this.lb20s.Size = new System.Drawing.Size(264, 108);
            this.lb20s.TabIndex = 51;
            this.lb20s.SelectedIndexChanged += new System.EventHandler(this.lb20s_SelectedIndexChanged);
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(916, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gaugeRainfall);
            this.Controls.Add(this.gaugeTemp);
            this.Controls.Add(this.lblLastUpdatedHeader);
            this.Controls.Add(this.lblRainfallHeader);
            this.Controls.Add(this.lblTemperatureHeader);
            this.Controls.Add(this.lblLocationHeader);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.gBoxLocation);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.gBoxLastUpdated);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lab";
            this.Text = "Melbourne Weather Monitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Label lblNav;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cBoxLocation;

        private System.Windows.Forms.Label lblLocationcbox;

        private System.Windows.Forms.ListBox lbMonitors;

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.CheckBox cbxRain;
        private System.Windows.Forms.CheckBox cbxTemp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label gBoxLocation;
        private System.Windows.Forms.Label gBoxLastUpdated;
        private System.Windows.Forms.Label lblLocationHeader;
        private System.Windows.Forms.Label lblTemperatureHeader;
        private System.Windows.Forms.Label lblRainfallHeader;
        private System.Windows.Forms.Label lblLastUpdatedHeader;
        private System.Windows.Forms.Button btnRemove;
        private LiveCharts.WinForms.SolidGauge gaugeTemp;
        private LiveCharts.WinForms.SolidGauge gaugeRainfall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbx20s;
        private System.Windows.Forms.RadioButton rbx5min;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveForms;
        private System.Windows.Forms.ListBox lb20s;
    }

}




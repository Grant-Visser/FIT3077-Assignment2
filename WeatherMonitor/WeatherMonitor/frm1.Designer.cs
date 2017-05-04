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
            this.btnAddMonitor = new System.Windows.Forms.Button();
            this.btnMonitors = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxLocation = new System.Windows.Forms.ComboBox();
            this.lblLocationcbox = new System.Windows.Forms.Label();
            this.lbMonitors = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbxRain = new System.Windows.Forms.CheckBox();
            this.cbxTemp = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.gBoxLocation = new System.Windows.Forms.Label();
            this.gBoxLastUpdated = new System.Windows.Forms.Label();
            this.gBoxRainfall = new System.Windows.Forms.Label();
            this.gBoxTemperature = new System.Windows.Forms.Label();
            this.lblLocationHeader = new System.Windows.Forms.Label();
            this.lblTemperatureHeader = new System.Windows.Forms.Label();
            this.lblRainfallHeader = new System.Windows.Forms.Label();
            this.lblLastUpdatedHeader = new System.Windows.Forms.Label();
            this.lblRainfall = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNav
            // 
            this.lblNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNav.Location = new System.Drawing.Point(0, 0);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(284, 492);
            this.lblNav.TabIndex = 3;
            // 
            // btnAddMonitor
            // 
            this.btnAddMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnAddMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonitor.ForeColor = System.Drawing.Color.Silver;
            this.btnAddMonitor.Location = new System.Drawing.Point(1, 75);
            this.btnAddMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMonitor.Name = "btnAddMonitor";
            this.btnAddMonitor.Size = new System.Drawing.Size(283, 51);
            this.btnAddMonitor.TabIndex = 6;
            this.btnAddMonitor.Text = "Add Monitor";
            this.btnAddMonitor.UseVisualStyleBackColor = false;
            // 
            // btnMonitors
            // 
            this.btnMonitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnMonitors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonitors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitors.ForeColor = System.Drawing.Color.Silver;
            this.btnMonitors.Location = new System.Drawing.Point(1, 256);
            this.btnMonitors.Name = "btnMonitors";
            this.btnMonitors.Size = new System.Drawing.Size(283, 53);
            this.btnMonitors.TabIndex = 7;
            this.btnMonitors.Text = "Monitors";
            this.btnMonitors.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(31, 218);
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
            this.label1.Font = new System.Drawing.Font("Pacifico", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 66);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dynamic Hunter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cBoxLocation
            // 
            this.cBoxLocation.FormattingEnabled = true;
            this.cBoxLocation.Items.AddRange(new object[] {
            "Free State Orange Farm"});
            this.cBoxLocation.Location = new System.Drawing.Point(101, 133);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(174, 21);
            this.cBoxLocation.TabIndex = 17;
            this.cBoxLocation.Text = "Please Make a Selection";
            // 
            // lblLocationcbox
            // 
            this.lblLocationcbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblLocationcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLocationcbox.ForeColor = System.Drawing.Color.White;
            this.lblLocationcbox.Location = new System.Drawing.Point(28, 133);
            this.lblLocationcbox.Name = "lblLocationcbox";
            this.lblLocationcbox.Size = new System.Drawing.Size(67, 21);
            this.lblLocationcbox.TabIndex = 18;
            this.lblLocationcbox.Text = "Location";
            // 
            // lbMonitors
            // 
            this.lbMonitors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMonitors.FormattingEnabled = true;
            this.lbMonitors.Location = new System.Drawing.Point(11, 322);
            this.lbMonitors.Name = "lbMonitors";
            this.lbMonitors.Size = new System.Drawing.Size(264, 121);
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
            this.cbxRain.Location = new System.Drawing.Point(31, 158);
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
            this.cbxTemp.Location = new System.Drawing.Point(31, 183);
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
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblTemperature.Font = new System.Drawing.Font("Century Gothic", 27.5F);
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(290, 181);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(0, 44);
            this.lblTemperature.TabIndex = 32;
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.gBoxLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBoxLocation.Location = new System.Drawing.Point(290, 9);
            this.gBoxLocation.Name = "gBoxLocation";
            this.gBoxLocation.Size = new System.Drawing.Size(492, 108);
            this.gBoxLocation.TabIndex = 42;
            // 
            // gBoxLastUpdated
            // 
            this.gBoxLastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxLastUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.gBoxLastUpdated.Location = new System.Drawing.Point(290, 371);
            this.gBoxLastUpdated.Name = "gBoxLastUpdated";
            this.gBoxLastUpdated.Size = new System.Drawing.Size(492, 111);
            this.gBoxLastUpdated.TabIndex = 43;
            // 
            // gBoxRainfall
            // 
            this.gBoxRainfall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxRainfall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.gBoxRainfall.Location = new System.Drawing.Point(290, 249);
            this.gBoxRainfall.Name = "gBoxRainfall";
            this.gBoxRainfall.Size = new System.Drawing.Size(492, 111);
            this.gBoxRainfall.TabIndex = 44;
            // 
            // gBoxTemperature
            // 
            this.gBoxTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.gBoxTemperature.Location = new System.Drawing.Point(290, 128);
            this.gBoxTemperature.Name = "gBoxTemperature";
            this.gBoxTemperature.Size = new System.Drawing.Size(492, 111);
            this.gBoxTemperature.TabIndex = 45;
            // 
            // lblLocationHeader
            // 
            this.lblLocationHeader.AutoSize = true;
            this.lblLocationHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLocationHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLocationHeader.ForeColor = System.Drawing.Color.White;
            this.lblLocationHeader.Location = new System.Drawing.Point(290, 9);
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
            this.lblTemperatureHeader.Location = new System.Drawing.Point(290, 128);
            this.lblTemperatureHeader.Name = "lblTemperatureHeader";
            this.lblTemperatureHeader.Size = new System.Drawing.Size(152, 25);
            this.lblTemperatureHeader.TabIndex = 47;
            this.lblTemperatureHeader.Text = "Temperature";
            // 
            // lblRainfallHeader
            // 
            this.lblRainfallHeader.AutoSize = true;
            this.lblRainfallHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblRainfallHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblRainfallHeader.ForeColor = System.Drawing.Color.White;
            this.lblRainfallHeader.Location = new System.Drawing.Point(288, 249);
            this.lblRainfallHeader.Name = "lblRainfallHeader";
            this.lblRainfallHeader.Size = new System.Drawing.Size(91, 25);
            this.lblRainfallHeader.TabIndex = 48;
            this.lblRainfallHeader.Text = "Rainfall";
            // 
            // lblLastUpdatedHeader
            // 
            this.lblLastUpdatedHeader.AutoSize = true;
            this.lblLastUpdatedHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLastUpdatedHeader.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLastUpdatedHeader.ForeColor = System.Drawing.Color.White;
            this.lblLastUpdatedHeader.Location = new System.Drawing.Point(290, 371);
            this.lblLastUpdatedHeader.Name = "lblLastUpdatedHeader";
            this.lblLastUpdatedHeader.Size = new System.Drawing.Size(155, 25);
            this.lblLastUpdatedHeader.TabIndex = 49;
            this.lblLastUpdatedHeader.Text = "Last updated";
            // 
            // lblRainfall
            // 
            this.lblRainfall.AutoSize = true;
            this.lblRainfall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblRainfall.Font = new System.Drawing.Font("Century Gothic", 27.5F);
            this.lblRainfall.ForeColor = System.Drawing.Color.White;
            this.lblRainfall.Location = new System.Drawing.Point(290, 300);
            this.lblRainfall.Name = "lblRainfall";
            this.lblRainfall.Size = new System.Drawing.Size(0, 44);
            this.lblRainfall.TabIndex = 33;
            this.lblRainfall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Silver;
            this.btnRemove.Location = new System.Drawing.Point(31, 450);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(215, 32);
            this.btnRemove.TabIndex = 50;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(791, 492);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblLastUpdatedHeader);
            this.Controls.Add(this.lblRainfallHeader);
            this.Controls.Add(this.lblTemperatureHeader);
            this.Controls.Add(this.lblLocationHeader);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.gBoxLocation);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.lblRainfall);
            this.Controls.Add(this.cbxTemp);
            this.Controls.Add(this.cbxRain);
            this.Controls.Add(this.lbMonitors);
            this.Controls.Add(this.lblLocationcbox);
            this.Controls.Add(this.cBoxLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMonitors);
            this.Controls.Add(this.btnAddMonitor);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.gBoxLastUpdated);
            this.Controls.Add(this.gBoxRainfall);
            this.Controls.Add(this.gBoxTemperature);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lab";
            this.Text = "Melbourne Weather Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Label lblNav;

        private System.Windows.Forms.Button btnAddMonitor;

        private System.Windows.Forms.Button btnMonitors;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cBoxLocation;

        private System.Windows.Forms.Label lblLocationcbox;

        private System.Windows.Forms.ListBox lbMonitors;

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.CheckBox cbxRain;
        private System.Windows.Forms.CheckBox cbxTemp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label gBoxLocation;
        private System.Windows.Forms.Label gBoxLastUpdated;
        private System.Windows.Forms.Label gBoxRainfall;
        private System.Windows.Forms.Label gBoxTemperature;
        private System.Windows.Forms.Label lblLocationHeader;
        private System.Windows.Forms.Label lblTemperatureHeader;
        private System.Windows.Forms.Label lblRainfallHeader;
        private System.Windows.Forms.Label lblLastUpdatedHeader;
        private System.Windows.Forms.Label lblRainfall;
        private System.Windows.Forms.Button btnRemove;
    }

}




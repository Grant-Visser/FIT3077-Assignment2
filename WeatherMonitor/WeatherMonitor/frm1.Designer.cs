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
            this.lblRainfall = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
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
            this.btnAddMonitor.Enabled = false;
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
            this.btnMonitors.Enabled = false;
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
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 66);
            this.label1.TabIndex = 15;
            this.label1.Text = "T/D";
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
            this.lbMonitors.FormattingEnabled = true;
            this.lbMonitors.Location = new System.Drawing.Point(11, 322);
            this.lbMonitors.Name = "lbMonitors";
            this.lbMonitors.Size = new System.Drawing.Size(264, 160);
            this.lbMonitors.TabIndex = 19;
            this.lbMonitors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(305, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(104, 25);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "Location";
            // 
            // cbxRain
            // 
            this.cbxRain.AutoSize = true;
            this.cbxRain.Checked = true;
            this.cbxRain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRain.Location = new System.Drawing.Point(31, 158);
            this.cbxRain.Name = "cbxRain";
            this.cbxRain.Size = new System.Drawing.Size(48, 17);
            this.cbxRain.TabIndex = 29;
            this.cbxRain.Text = "Rain";
            this.cbxRain.UseVisualStyleBackColor = true;
            // 
            // cbxTemp
            // 
            this.cbxTemp.AutoSize = true;
            this.cbxTemp.Checked = true;
            this.cbxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTemp.Location = new System.Drawing.Point(31, 181);
            this.cbxTemp.Name = "cbxTemp";
            this.cbxTemp.Size = new System.Drawing.Size(86, 17);
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
            this.lblTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblTemperature.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(305, 145);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(152, 25);
            this.lblTemperature.TabIndex = 32;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblRainfall
            // 
            this.lblRainfall.AutoSize = true;
            this.lblRainfall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblRainfall.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblRainfall.ForeColor = System.Drawing.Color.White;
            this.lblRainfall.Location = new System.Drawing.Point(305, 75);
            this.lblRainfall.Name = "lblRainfall";
            this.lblRainfall.Size = new System.Drawing.Size(91, 25);
            this.lblRainfall.TabIndex = 33;
            this.lblRainfall.Text = "Rainfall";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLastUpdated.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLastUpdated.ForeColor = System.Drawing.Color.White;
            this.lblLastUpdated.Location = new System.Drawing.Point(305, 218);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(155, 25);
            this.lblLastUpdated.TabIndex = 34;
            this.lblLastUpdated.Text = "Last updated";
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(791, 492);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.lblRainfall);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.cbxTemp);
            this.Controls.Add(this.cbxRain);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lbMonitors);
            this.Controls.Add(this.lblLocationcbox);
            this.Controls.Add(this.cBoxLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMonitors);
            this.Controls.Add(this.btnAddMonitor);
            this.Controls.Add(this.lblNav);
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
        private System.Windows.Forms.Label lblRainfall;
        private System.Windows.Forms.Label lblLastUpdated;
    }

}




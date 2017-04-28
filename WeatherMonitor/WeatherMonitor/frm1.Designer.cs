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
            this.btntemp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNav = new System.Windows.Forms.Label();
            this.btnAddMonitor = new System.Windows.Forms.Button();
            this.btnMonitors = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxLocation = new System.Windows.Forms.ComboBox();
            this.lblLocationcbox = new System.Windows.Forms.Label();
            this.lbMonitors = new System.Windows.Forms.ListBox();
            this.cLBox = new System.Windows.Forms.CheckedListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblRainfall = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.LblLastUpdatedHolder = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntemp
            // 
            this.btntemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btntemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemp.ForeColor = System.Drawing.Color.White;
            this.btntemp.Location = new System.Drawing.Point(369, 9);
            this.btntemp.Name = "btntemp";
            this.btntemp.Size = new System.Drawing.Size(154, 34);
            this.btntemp.TabIndex = 0;
            this.btntemp.Text = "Make em beautiful";
            this.btntemp.UseVisualStyleBackColor = false;
            this.btntemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(290, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            "Durban",
            "Cape town"});
            this.cBoxLocation.Location = new System.Drawing.Point(101, 133);
            this.cBoxLocation.Name = "cBoxLocation";
            this.cBoxLocation.Size = new System.Drawing.Size(174, 21);
            this.cBoxLocation.TabIndex = 17;
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
            this.lbMonitors.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.lbMonitors.Location = new System.Drawing.Point(11, 322);
            this.lbMonitors.Name = "lbMonitors";
            this.lbMonitors.Size = new System.Drawing.Size(264, 160);
            this.lbMonitors.TabIndex = 19;
            this.lbMonitors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cLBox
            // 
            this.cLBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.cLBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cLBox.CheckOnClick = true;
            this.cLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLBox.ForeColor = System.Drawing.Color.White;
            this.cLBox.FormattingEnabled = true;
            this.cLBox.Items.AddRange(new object[] {
            "Rainfall",
            "Temperature"});
            this.cLBox.Location = new System.Drawing.Point(31, 160);
            this.cLBox.Name = "cLBox";
            this.cLBox.Size = new System.Drawing.Size(120, 38);
            this.cLBox.TabIndex = 22;
            // 
            // lblLocation
            // 
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(317, 55);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(110, 32);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "Location";
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblTemperature.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(460, 55);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(158, 32);
            this.lblTemperature.TabIndex = 24;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblRainfall
            // 
            this.lblRainfall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.lblRainfall.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblRainfall.ForeColor = System.Drawing.Color.White;
            this.lblRainfall.Location = new System.Drawing.Point(650, 55);
            this.lblRainfall.Name = "lblRainfall";
            this.lblRainfall.Size = new System.Drawing.Size(106, 32);
            this.lblRainfall.TabIndex = 25;
            this.lblRainfall.Text = "Rainfall";
            this.lblRainfall.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblLastUpdated.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblLastUpdated.ForeColor = System.Drawing.Color.White;
            this.lblLastUpdated.Location = new System.Drawing.Point(561, 447);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(163, 32);
            this.lblLastUpdated.TabIndex = 26;
            this.lblLastUpdated.Text = "Last updated";
            // 
            // LblLastUpdatedHolder
            // 
            this.LblLastUpdatedHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.LblLastUpdatedHolder.Location = new System.Drawing.Point(558, 441);
            this.LblLastUpdatedHolder.Name = "LblLastUpdatedHolder";
            this.LblLastUpdatedHolder.Size = new System.Drawing.Size(221, 41);
            this.LblLastUpdatedHolder.TabIndex = 27;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(290, 441);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(122, 23);
            this.btnTest.TabIndex = 28;
            this.btnTest.Text = "Fetch from server";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(791, 492);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.LblLastUpdatedHolder);
            this.Controls.Add(this.lblRainfall);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cLBox);
            this.Controls.Add(this.lbMonitors);
            this.Controls.Add(this.lblLocationcbox);
            this.Controls.Add(this.cBoxLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMonitors);
            this.Controls.Add(this.btnAddMonitor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btntemp);
            this.Controls.Add(this.lblNav);
            this.Name = "lab";
            this.Text = "WeatherMonitor";
            this.ResumeLayout(false);

        }



        #endregion



        private System.Windows.Forms.Button btntemp;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label lblNav;

        private System.Windows.Forms.Button btnAddMonitor;

        private System.Windows.Forms.Button btnMonitors;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cBoxLocation;

        private System.Windows.Forms.Label lblLocationcbox;

        private System.Windows.Forms.ListBox lbMonitors;

        private System.Windows.Forms.CheckedListBox cLBox;

        private System.Windows.Forms.Label lblLocation;

        private System.Windows.Forms.Label lblTemperature;

        private System.Windows.Forms.Label lblRainfall;

        private System.Windows.Forms.Label lblLastUpdated;

        private System.Windows.Forms.Label LblLastUpdatedHolder;
        private System.Windows.Forms.Button btnTest;
    }

}




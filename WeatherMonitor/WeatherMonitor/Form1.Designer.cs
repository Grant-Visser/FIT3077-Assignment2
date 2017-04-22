namespace WeatherMonitor
{
    partial class frm1
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
            this.SuspendLayout();
            // 
            // btntemp
            // 
            this.btntemp.AutoSize = true;
            this.btntemp.Location = new System.Drawing.Point(12, 12);
            this.btntemp.Name = "btntemp";
            this.btntemp.Size = new System.Drawing.Size(104, 23);
            this.btntemp.TabIndex = 0;
            this.btntemp.Text = "Make em beautiful";
            this.btntemp.UseVisualStyleBackColor = true;
            this.btntemp.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btntemp);
            this.Name = "frm1";
            this.Text = "WeatherMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntemp;
    }
}


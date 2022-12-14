namespace ZH3_hve1gg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Adatbazis_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Excel_button = new System.Windows.Forms.Button();
            this.Szinezes_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adatbazis_button
            // 
            this.Adatbazis_button.Location = new System.Drawing.Point(12, 55);
            this.Adatbazis_button.Name = "Adatbazis_button";
            this.Adatbazis_button.Size = new System.Drawing.Size(126, 47);
            this.Adatbazis_button.TabIndex = 0;
            this.Adatbazis_button.Text = "Adatbázis";
            this.Adatbazis_button.UseVisualStyleBackColor = true;
            this.Adatbazis_button.Click += new System.EventHandler(this.Adatbazis_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(162, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 528);
            this.panel1.TabIndex = 1;
            // 
            // Excel_button
            // 
            this.Excel_button.Location = new System.Drawing.Point(12, 140);
            this.Excel_button.Name = "Excel_button";
            this.Excel_button.Size = new System.Drawing.Size(126, 47);
            this.Excel_button.TabIndex = 2;
            this.Excel_button.Text = "Excel";
            this.Excel_button.UseVisualStyleBackColor = true;
            this.Excel_button.Click += new System.EventHandler(this.Excel_button_Click);
            // 
            // Szinezes_button
            // 
            this.Szinezes_button.Location = new System.Drawing.Point(12, 223);
            this.Szinezes_button.Name = "Szinezes_button";
            this.Szinezes_button.Size = new System.Drawing.Size(126, 47);
            this.Szinezes_button.TabIndex = 3;
            this.Szinezes_button.Text = "Színez";
            this.Szinezes_button.UseVisualStyleBackColor = true;
            this.Szinezes_button.Click += new System.EventHandler(this.Szinezes_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 552);
            this.Controls.Add(this.Szinezes_button);
            this.Controls.Add(this.Excel_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Adatbazis_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Adatbazis_button;
        private Panel panel1;
        private Button Excel_button;
        private Button Szinezes_button;
    }
}
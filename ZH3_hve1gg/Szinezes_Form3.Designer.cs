namespace ZH3_hve1gg
{
    partial class Szinezes_Form3
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
            this.Szinezes_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Szinezes_button
            // 
            this.Szinezes_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Szinezes_button.Location = new System.Drawing.Point(149, 172);
            this.Szinezes_button.Name = "Szinezes_button";
            this.Szinezes_button.Size = new System.Drawing.Size(138, 51);
            this.Szinezes_button.TabIndex = 0;
            this.Szinezes_button.Text = "Átszínezem";
            this.Szinezes_button.UseVisualStyleBackColor = true;
            this.Szinezes_button.Click += new System.EventHandler(this.Szinezes_button_Click);
            // 
            // Szinezes_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 369);
            this.Controls.Add(this.Szinezes_button);
            this.Name = "Szinezes_Form3";
            this.Text = "Szinezes_Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Szinezes_button;
    }
}
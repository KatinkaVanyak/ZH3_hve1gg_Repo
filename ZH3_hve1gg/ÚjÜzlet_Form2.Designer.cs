namespace ZH3_hve1gg
{
    partial class ÚjÜzlet_Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ok_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_ÚjÜzlet = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adja meg a kívánt üzlet nevét";
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(288, 228);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 23);
            this.Ok_button.TabIndex = 1;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(399, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_ÚjÜzlet
            // 
            this.textBox1_ÚjÜzlet.Location = new System.Drawing.Point(71, 89);
            this.textBox1_ÚjÜzlet.Name = "textBox1_ÚjÜzlet";
            this.textBox1_ÚjÜzlet.Size = new System.Drawing.Size(204, 23);
            this.textBox1_ÚjÜzlet.TabIndex = 3;
            this.textBox1_ÚjÜzlet.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_ÚjÜzlet_Validating);
            this.textBox1_ÚjÜzlet.Validated += new System.EventHandler(this.textBox1_ÚjÜzlet_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ÚjÜzlet_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 265);
            this.Controls.Add(this.textBox1_ÚjÜzlet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.label1);
            this.Name = "ÚjÜzlet_Form2";
            this.Text = "ÚjÜzlet_Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Ok_button;
        private Button button1;
        public TextBox textBox1_ÚjÜzlet;
        private ErrorProvider errorProvider1;
    }
}
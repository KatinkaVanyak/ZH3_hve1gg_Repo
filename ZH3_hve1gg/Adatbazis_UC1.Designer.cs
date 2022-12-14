namespace ZH3_hve1gg
{
    partial class Adatbazis_UC1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1_Üzlet = new System.Windows.Forms.ListBox();
            this.listBox2_Product = new System.Windows.Forms.ListBox();
            this.ÚjÜzlet_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailedStockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1_Üzletre = new System.Windows.Forms.TextBox();
            this.textBox2_Productra = new System.Windows.Forms.TextBox();
            this.textBox3_Mennyiseg = new System.Windows.Forms.TextBox();
            this.Hozzáad_button = new System.Windows.Forms.Button();
            this.Töröl_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailedStockItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1_Üzlet
            // 
            this.listBox1_Üzlet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBox1_Üzlet.FormattingEnabled = true;
            this.listBox1_Üzlet.ItemHeight = 15;
            this.listBox1_Üzlet.Location = new System.Drawing.Point(13, 137);
            this.listBox1_Üzlet.Name = "listBox1_Üzlet";
            this.listBox1_Üzlet.Size = new System.Drawing.Size(236, 379);
            this.listBox1_Üzlet.TabIndex = 0;
            this.listBox1_Üzlet.SelectedIndexChanged += new System.EventHandler(this.listBox1_Üzlet_SelectedIndexChanged);
            // 
            // listBox2_Product
            // 
            this.listBox2_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBox2_Product.FormattingEnabled = true;
            this.listBox2_Product.ItemHeight = 15;
            this.listBox2_Product.Location = new System.Drawing.Point(719, 137);
            this.listBox2_Product.Name = "listBox2_Product";
            this.listBox2_Product.Size = new System.Drawing.Size(242, 379);
            this.listBox2_Product.TabIndex = 1;
            // 
            // ÚjÜzlet_button
            // 
            this.ÚjÜzlet_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ÚjÜzlet_button.Location = new System.Drawing.Point(42, 29);
            this.ÚjÜzlet_button.Name = "ÚjÜzlet_button";
            this.ÚjÜzlet_button.Size = new System.Drawing.Size(167, 23);
            this.ÚjÜzlet_button.TabIndex = 2;
            this.ÚjÜzlet_button.Text = "Új üzlet hozzáadása";
            this.ÚjÜzlet_button.UseVisualStyleBackColor = true;
            this.ÚjÜzlet_button.Click += new System.EventHandler(this.ÚjÜzlet_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailedStockItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(272, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(338, 379);
            this.dataGridView1.TabIndex = 3;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            this.storeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // detailedStockItemBindingSource
            // 
            this.detailedStockItemBindingSource.DataSource = typeof(ZH3_hve1gg.DetailedStockItem);
            // 
            // textBox1_Üzletre
            // 
            this.textBox1_Üzletre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1_Üzletre.Location = new System.Drawing.Point(16, 89);
            this.textBox1_Üzletre.Name = "textBox1_Üzletre";
            this.textBox1_Üzletre.Size = new System.Drawing.Size(210, 23);
            this.textBox1_Üzletre.TabIndex = 4;
            this.textBox1_Üzletre.TextChanged += new System.EventHandler(this.textBox1_Üzletre_TextChanged);
            // 
            // textBox2_Productra
            // 
            this.textBox2_Productra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox2_Productra.Location = new System.Drawing.Point(748, 89);
            this.textBox2_Productra.Name = "textBox2_Productra";
            this.textBox2_Productra.Size = new System.Drawing.Size(210, 23);
            this.textBox2_Productra.TabIndex = 5;
            this.textBox2_Productra.TextChanged += new System.EventHandler(this.textBox2_Productra_TextChanged);
            // 
            // textBox3_Mennyiseg
            // 
            this.textBox3_Mennyiseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox3_Mennyiseg.Location = new System.Drawing.Point(629, 193);
            this.textBox3_Mennyiseg.Name = "textBox3_Mennyiseg";
            this.textBox3_Mennyiseg.Size = new System.Drawing.Size(69, 23);
            this.textBox3_Mennyiseg.TabIndex = 6;
            // 
            // Hozzáad_button
            // 
            this.Hozzáad_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Hozzáad_button.Location = new System.Drawing.Point(638, 259);
            this.Hozzáad_button.Name = "Hozzáad_button";
            this.Hozzáad_button.Size = new System.Drawing.Size(47, 45);
            this.Hozzáad_button.TabIndex = 7;
            this.Hozzáad_button.Text = "+";
            this.Hozzáad_button.UseVisualStyleBackColor = true;
            this.Hozzáad_button.Click += new System.EventHandler(this.Hozzáad_button_Click);
            // 
            // Töröl_button
            // 
            this.Töröl_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Töröl_button.Location = new System.Drawing.Point(638, 325);
            this.Töröl_button.Name = "Töröl_button";
            this.Töröl_button.Size = new System.Drawing.Size(47, 45);
            this.Töröl_button.TabIndex = 8;
            this.Töröl_button.Text = "-";
            this.Töröl_button.UseVisualStyleBackColor = true;
            this.Töröl_button.Click += new System.EventHandler(this.Töröl_button_Click);
            // 
            // Adatbazis_UC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.Töröl_button);
            this.Controls.Add(this.Hozzáad_button);
            this.Controls.Add(this.textBox3_Mennyiseg);
            this.Controls.Add(this.textBox2_Productra);
            this.Controls.Add(this.textBox1_Üzletre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ÚjÜzlet_button);
            this.Controls.Add(this.listBox2_Product);
            this.Controls.Add(this.listBox1_Üzlet);
            this.Name = "Adatbazis_UC1";
            this.Size = new System.Drawing.Size(978, 528);
            this.Load += new System.EventHandler(this.Adatbazis_UC1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailedStockItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1_Üzlet;
        private ListBox listBox2_Product;
        private Button ÚjÜzlet_button;
        private DataGridView dataGridView1;
        private TextBox textBox1_Üzletre;
        private TextBox textBox2_Productra;
        private TextBox textBox3_Mennyiseg;
        private Button Hozzáad_button;
        private Button Töröl_button;
        private DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource detailedStockItemBindingSource;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_hve1gg
{
    public partial class Adatbazis_UC1 : UserControl
    {
        Models.SeBikestoreContext context = new Models.SeBikestoreContext();

        public Adatbazis_UC1()
        {
            InitializeComponent();
        }

        private void textBox1_Üzletre_TextChanged(object sender, EventArgs e)
        {
            Üzlet_Szűrés();
        }

        void Üzlet_Szűrés()
        {
            var szűrtüzlet = from x in context.Stores
                             where x.StoreName.Contains(textBox1_Üzletre.Text)
                             select x;
            listBox1_Üzlet.DataSource = szűrtüzlet.ToList();
            listBox1_Üzlet.DisplayMember = "StoreName";
        }

        private void Adatbazis_UC1_Load(object sender, EventArgs e)
        {
            Üzlet_Szűrés();
            Product_Szűrés();
            Rácsban();
        }

        private void textBox2_Productra_TextChanged(object sender, EventArgs e)
        {
            Product_Szűrés();
        }
        void Product_Szűrés()
        {
            var szűrtProduct = from x in context.Products
                             where x.ProductName.Contains(textBox2_Productra.Text)
                             select x;

            listBox2_Product.DataSource = szűrtProduct.ToList();
            listBox2_Product.DisplayMember = "ProductName";
        }

        private void listBox1_Üzlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rácsban();
        }

        void Rácsban()
        {
            var VálasztottÜzlet = (Models.Store)listBox1_Üzlet.SelectedItem;

            var szűrés = from x in context.Stocks
                         where x.StoreSk == VálasztottÜzlet.StoreSk && x.ProductFk == x.ProductFkNavigation.ProductSk
                         select new DetailedStockItem()
                         {
                             StoreId = VálasztottÜzlet.StoreSk,
                             ProductId = x.ProductFk,
                             ProductName = x.ProductFkNavigation.ProductName,
                             Quantity = x.Quantity
                         };


            detailedStockItemBindingSource.DataSource = szűrés.ToList();


            
        }

        private void ÚjÜzlet_button_Click(object sender, EventArgs e)
        {
            ÚjÜzlet_Form2 form2 = new ÚjÜzlet_Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Models.Store üzlet = new Models.Store();
                üzlet.StoreName = form2.textBox1_ÚjÜzlet.Text;

                context.Stores.Add(üzlet);
                context.SaveChanges();

                Üzlet_Szűrés();
            }
        }

        private void Hozzáad_button_Click(object sender, EventArgs e)
        {
            var VálÜzlet = (Models.Store)listBox1_Üzlet.SelectedItem;
            var VálProd = (Models.Product)listBox2_Product.SelectedItem;

            Models.Stock újstock = new Models.Stock()
            {
                StoreSk = VálÜzlet.StoreSk,
                ProductFk = VálProd.ProductSk,
                Quantity = int.Parse(textBox3_Mennyiseg.Text)

            };

            context.Stocks.Add(újstock);
            context.SaveChanges();

            Rácsban();
        }

        private void Töröl_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretné törölni?", "Kitörlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var KiStock = (DetailedStockItem)detailedStockItemBindingSource.Current;

                var törlendo = from x in context.Stocks
                               where x.StoreSk == KiStock.StoreId
                               select x;

                context.Stocks.Remove(törlendo.FirstOrDefault());
                context.SaveChanges();

                Rácsban();

            }
        }
    }
}

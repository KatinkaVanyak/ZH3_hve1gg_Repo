using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_hve1gg
{
    public partial class ÚjÜzlet_Form2 : Form
    {
        public ÚjÜzlet_Form2()
        {
            InitializeComponent();
        }

        private bool CheckÜres(string nev)
        {
            return !string.IsNullOrEmpty(nev);
        }
        private bool CheckSzám(string nev)
        {
            Regex r = new Regex("^[^0-9]");
            return r.IsMatch(nev);
        }

        private void textBox1_ÚjÜzlet_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckÜres(textBox1_ÚjÜzlet.Text) || !CheckSzám(textBox1_ÚjÜzlet.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1_ÚjÜzlet,"Nem lehet üres és nem kezdődhez számmal");
            }
        }

        private void textBox1_ÚjÜzlet_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1_ÚjÜzlet, "");

        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

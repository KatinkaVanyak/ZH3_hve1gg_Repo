namespace ZH3_hve1gg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Adatbazis_button_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Adatbazis_UC1 uc1 = new Adatbazis_UC1();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
        }

        private void Excel_button_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Excel_UC2 uc2 = new Excel_UC2();
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
        }

        private void Szinezes_button_Click(object sender, EventArgs e)
        {
            Szinezes_Form3 form3 = new Szinezes_Form3();
            form3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Be szeretné zárni az ablakot?","Ablak bezárás", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
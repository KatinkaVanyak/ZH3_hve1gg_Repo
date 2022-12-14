using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace ZH3_hve1gg
{
    public partial class Excel_UC2 : UserControl
    {
        Excel.Application xlApp;
        Excel.Workbook wb;
        Excel.Worksheet ws;

        public Excel_UC2()
        {
            InitializeComponent();
        }

        private void Export_button_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            wb = xlApp.Workbooks.Add(Missing.Value);
            ws = wb.ActiveSheet;

            CreateTable();

            xlApp.Visible = true;
            xlApp.UserControl = true;

        }

        void CreateTable()
        {
            string[] fejlec = new string[]
            {
                "First Name",
                "Last Name",
                "Phone",
                "Email",
                "Zip Code"
            };

            for (int i = 0; i < fejlec.Length; i++)
            {
                ws.Cells[1, 1] = fejlec[0];
                ws.Cells[1, 2] = fejlec[1];
                ws.Cells[1, 3] = fejlec[2];
                ws.Cells[1, 4] = fejlec[3];
                ws.Cells[1, 5] = fejlec[4];
            }

            Models.SeBikestoreContext context = new Models.SeBikestoreContext();
            var Össz_Vevök = context.Customers.ToList();

            object[,] adatok = new object[Össz_Vevök.Count(),fejlec.Count()];

            for (int i = 0; i < Össz_Vevök.Count; i++)
            {
                adatok[i, 0] = Össz_Vevök[i].FirstName;
                adatok[i, 1] = Össz_Vevök[i].LastName;
                adatok[i, 2] = Össz_Vevök[i].Phone;
                adatok[i, 3] = Össz_Vevök[i].Email;
                adatok[i, 4] = Össz_Vevök[i].ZipCode;

            }

            Excel.Range adatRange = ws.get_Range("A2", Type.Missing).get_Resize(Össz_Vevök.Count(),fejlec.Count());

            adatRange.Value2 = adatok;

            adatRange.Font.Bold = true;
        }
    }
}

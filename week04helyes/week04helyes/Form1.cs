using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace week04helyes
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> lakasok;
        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xLSheet; // Munkalap a munkafüzeten belül
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            lakasok = context.Flats.ToList();

        }
        public void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application(); // Excel elindítása és az applikáció objektum betöltése

                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xLSheet = xlWB.ActiveSheet;

                //CreateTabel();

                xlApp.Visible = true;
                xlApp.UserControl = true;

            }
            catch (Exception ex)
            {
                string errorMSG = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;

            }
        }
    }
}

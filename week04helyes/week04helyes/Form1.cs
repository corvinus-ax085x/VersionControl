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
        private int _million = (int)Math.Pow(10, 6);
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> lakasok;
        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xLSheet; // Munkalap a munkafüzeten belül
        string[] headers;

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
        private void CreateTabel()
        {
            headers = new string[]
            {
                "Kód",
                "Eladó",
                "Oldal",
                "Kerület",
                "Lift",
                "Szobák száma",
                "Alapterület (m2)",
                "Ár (mFt)",
                "Négyzetméter ár (Ft/m2)"
            };

            for (int i = 0; i < headers.Length; i++)
            {
                xLSheet.Cells[1, i + 1] = headers[i];
            }

            object[,] values = new object[lakasok.Count, headers.Length];

            int sorszamlalo = 0;
            int floorColumn = 6;
            foreach (var lakas in lakasok)
            {
                values[sorszamlalo, 0] = lakas.Code;
                values[sorszamlalo, 1] = lakas.Vendor;
                values[sorszamlalo, 2] = lakas.Side;
                values[sorszamlalo, 3] = lakas.District;
                values[sorszamlalo, 4] = lakas.Elevator ? "Van" : "Nincs";
                values[sorszamlalo, 5] = lakas.NumberOfRooms;
                values[sorszamlalo, 6] = lakas.FloorArea;
                values[sorszamlalo, 7] = lakas.Price;
                values[sorszamlalo, 8] = string.Format("={0}/{1}*{2}",
                    "H" + (sorszamlalo + 2).ToString(),
                    GetCell(sorszamlalo + 2, floorColumn + 1),
                    _million.ToString());
                sorszamlalo++;
            }
            var range = xLSheet.get_Range(
                GetCell(2, 1),
                GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;


        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}

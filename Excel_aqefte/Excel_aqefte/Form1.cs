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
using System.Data.Entity.Migrations.Model;

namespace Excel_aqefte
{
    public partial class Form1 : Form

    {
        List<Flat> flats;
        RealEstateEntities context = new RealEstateEntities();

        Excel.Application xlApp;
        Excel.Workbook xlwb;
        Excel.Worksheet xlws;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }

        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlwb = xlApp.Workbooks.Add(Missing.Value);
                xlws = xlwb.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {

                string errMsg = string.Format("Error:{0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlwb.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlwb = null;
                xlApp = null;

            }
        }

        private void CreateTable()
        {
            string[] headers = new string[]
            {
                "Kód",
                 "Eladó",
                 "Oldal",
                 "Kerület",
                 "Lift",
                 "Szobák száma",
                 "Alapterület (m2)",
                 "Ár (mFt)",
                 "Négyzetméter ár (Ft/m2)"};

            for (int i = 0; i < 8; i++)
            {
                xlws.Cells[1, 1] = headers[0];
                xlws.Cells[1,2]=headers[1]; 
                xlws.Cells[1,3]=headers[2]; 
                xlws.Cells[1,4]=headers[3]; 
                xlws.Cells[1,5]=headers[4]; 
                xlws.Cells[1,6]=headers[5]; 
                xlws.Cells[1,7]=headers[6]; 
                xlws.Cells[1,8]=headers[7]; 
                xlws.Cells[1,9]=headers[8]; 
            }

            object[,] values = new object[flats.Count, headers.Length];
            int counter = 0;
            foreach (Flat f in flats)
            {
                values[counter, 0] = f.Code;
                values[counter, 1] = f.Vendor;
                values[counter, 2] = f.Side;
                values[counter, 3] = f.District;
                if (f.Elevator == true)
                {
                    values[counter, 4] = "Van";
                }
                else
                {
                    values[counter, 4] = "Nincs";
                }
                values[counter, 5] = f.NumberOfRooms;
                values[counter, 6] = f.FloorArea;
                values[counter, 7] = f.Price;
                values[counter, 8] = f.Price / f.FloorArea;
                counter++;

                xlws.get_Range(
                    GetCell(2, 1),
                    GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            }

        }

        private void LoadData()
        {
            flats = context.Flats.ToList();
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend>0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend=(int)((dividend-modulo)/26);
            }
            ExcelCoordinate+=x.ToString();
            return ExcelCoordinate; 
        }
    }
}

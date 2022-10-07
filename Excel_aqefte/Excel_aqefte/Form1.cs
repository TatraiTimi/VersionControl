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
        RealEstateEntities context= new RealEstateEntities();

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
                //CreateTable();
                xlApp.Visible=true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {

                string errMsg = string.Format("Error:{0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlwb.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlwb=null;
                xlApp=null;

            }
        }

        private void LoadData()
        {
            flats=context.Flats.ToList();
        }
    }
}

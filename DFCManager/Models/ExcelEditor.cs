using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace DFCManager.Models
{
    public class ExcelEditor
    {

        private Excel.Application xlApp;
        private Excel.Workbook wb;
        private Excel.Worksheet ws;

        public void initFile(string fileName)
        {
            try
            {
                xlApp = new Excel.Application();
                wb = xlApp.Workbooks.Open(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("opening file error :: "+ex.ToString());
            }
        }

        public void initSheet(string sheetName)
        {
            try
            {  
                ws = (Excel.Worksheet)wb.Worksheets[sheetName];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Worksheet could not be created :: "+ex.ToString());
            }
        }

        public void addValues(DFCModel dfc)
        {
            /*
            // Select the Excel cells
            Excel.Range aRange = ws.get_Range("C1", "C1");

            if (aRange == null)
            {
                Console.WriteLine("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
            }

            // Fill the cells in the range of the worksheet with a value.
            Object[] args = { 1 };
            aRange.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, aRange, args);

            Excel.Range last = ws.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = ws.get_Range("C1", last);

            int lastUsedRow = last.Row;
            int lastUsedColumn = last.Column;

            Debug.WriteLine("last used row ::::" + lastUsedRow);
            Debug.WriteLine("last used column ::::" + lastUsedColumn);
            
             */
        }

        public void save()
        {
            try { wb.Save();}
            catch (Exception e) { Debug.WriteLine(e.ToString());}
        }



    }
}
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.Wrappers
{
    public class ExcelFileHandler
    {
        private Microsoft.Office.Interop.Excel.Application excelApp;
        private Workbook currentWorkbook;
        private Sheets currentSheets;
        private Worksheet currentWorksheet;
        private string filePath;
        private Range activeCell;
        private int rowPos = 1;
        private int colPos = 1;

        public ExcelFileHandler(string fileName)
        {
            this.filePath = Environment.CurrentDirectory + "\\" + fileName;

            try
            {
                // Instantiate new Excel Application
                this.excelApp = new Microsoft.Office.Interop.Excel.Application();

                // Create a new Excel Workbook
                this.currentWorkbook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

                // Get list of worksheets. By default there is only one worksheet.
                this.currentSheets = currentWorkbook.Worksheets;

                // Use the Default Worksheet
                this.currentWorksheet = (Worksheet) currentSheets.get_Item("Sheet1");

                activeCell = this.currentWorksheet.Cells[1, 1];
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

            }
        }

        public Worksheet AddNewExcelSheet()
        {
            // Will add a new worksheet after the 
            return this.currentSheets.Add(After: currentWorkbook.Sheets[currentWorkbook.Sheets.Count]);
        }

        /// <summary>
        /// Resets active cell position to 1,1
        /// </summary>
        public void ResetActiveCellPosition()
        {
            this.activeCell = this.currentWorksheet.Cells[1,1];
        }

        /// <summary>
        /// Sets active cell position to any cell in the work sheet
        /// </summary>
        /// <param name="rowPos"></param>
        /// <param name="colPos"></param>
        public void SetActiveCellPosition(int rowPos, int colPos)
        {
            this.rowPos = rowPos;
            this.colPos = colPos;
            this.activeCell = this.currentWorksheet.Cells[rowPos, colPos];
        }

        /// <summary>
        /// Sets value to the active cell position
        /// </summary>
        /// <param name="value"></param>
        public void SetActiveCellValue(string value)
        {
            this.activeCell.Value2 = value;
        }

        /// <summary>
        /// Sets cell value in any cell in the work sheet
        /// </summary>
        /// <param name="rowPos"></param>
        /// <param name="colPos"></param>
        /// <param name="value"></param>
        public void SetCellValue(int rowPos, int colPos, string value)
        {
            ((Range)this.currentWorksheet.Cells[rowPos, colPos]).Value2 = value;
        }

        /// <summary>
        /// Gets cell value in any cell in the work sheet
        /// </summary>
        /// <returns></returns>
        public string GetCellValue()
        {
            return ((Range)this.currentWorksheet.Cells[rowPos, colPos]).Value2;
        }

        /// <summary>
        /// Closes the excel workbook and applications
        /// </summary>
        public void Close()
        {
            if (this.currentWorkbook != null)
                this.currentWorkbook.Close();
            if (this.excelApp != null)
                this.excelApp.Quit();
        }

        /// <summary>
        /// Saves the excel workbook in the filesystem.
        /// </summary>
        public void SaveAs()
        {
            try
            {
                currentWorkbook.SaveAs(this.filePath);
            }
            catch (Exception)
            {
            }
        }
    }
}

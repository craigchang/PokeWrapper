using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokeWrapper.API;
using PokeWrapper.DataContracts;
using PokeWrapper.Wrappers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.UnitTests
{
    [TestClass]
    public class TypeDataContractTest
    {
        [TestMethod]
        public void getAllTypes()
        {
            List<TypeDataContract> typeList = new List<TypeDataContract>();
            TypeDataContract type;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 1; i <= 20; i++)
            {
                type = (TypeDataContract)DataContractGenerator<TypeDataContract>.getInstance(i);
                if (type != null)
                    typeList.Add(type);
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Debug.WriteLine("RunTime: " + elapsedTime);

            generateReport(typeList, elapsedTime);
        }

        public void generateReport(List<TypeDataContract> typeList, string elapsedTime)
        {
            ExcelFileHandler excelFileHandler = null;

            try
            {
                excelFileHandler = new ExcelFileHandler("TypeUnitTestResults.xlsx");

                excelFileHandler.SetCellValue(1, 1, "Id");
                excelFileHandler.SetCellValue(1, 2, "Name");
                excelFileHandler.SetCellValue(1, 3, "Created");
                excelFileHandler.SetCellValue(1, 4, "Modified");
                excelFileHandler.SetCellValue(1, 5, "Time Elapsed");

                int row = 2;
                foreach (TypeDataContract type in typeList)
                {
                    excelFileHandler.SetCellValue(row, 1, type.Id.ToString());
                    excelFileHandler.SetCellValue(row, 2, type.Name);
                    excelFileHandler.SetCellValue(row, 3, ((DateTime)type.Created).ToString("yyyy-MM-dd"));
                    excelFileHandler.SetCellValue(row, 4, ((DateTime)type.Modified).ToString("yyyy-MM-dd"));
                    excelFileHandler.SetCellValue(row, 5, elapsedTime);
                    row++;
                } 

                excelFileHandler.SaveAs();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Unable to create the Excel File for the following reason: " + e.StackTrace);
            }
            finally
            {
                if (excelFileHandler != null)
                    excelFileHandler.Close();
            }
        }
    }
}

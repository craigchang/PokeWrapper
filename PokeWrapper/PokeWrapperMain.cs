using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokeWrapper.DataContracts;
using PokeWrapper.Wrappers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper
{
    class PokeWrapperMain
    {
        public static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            PokedexDataContract pokedex = (PokedexDataContract)DataContractGenerator.getInstance(DataContractType.Pokedex, 1);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Debug.WriteLine("RunTime: " + elapsedTime);

            int dateCompare = DateTime.Compare((DateTime)pokedex.Modified, new DateTime(2013, 11, 10, 0, 0, 0, 0));
            Assert.IsTrue(dateCompare < 0);
            dateCompare = DateTime.Compare((DateTime)pokedex.Created, new DateTime(2013, 11, 10, 0, 0, 0, 0));
            Assert.IsTrue(dateCompare < 0);
            Assert.IsTrue(pokedex.Name == "national");
            Assert.IsTrue(pokedex.PokedexResourceUri == "/api/v1/pokedex/1/");
            Assert.IsTrue(pokedex.PokemonResourceUriList.Count == 778);

            ExcelFileHandler excelFileHandler = new ExcelFileHandler("PokedexUnitTest.xlsx");

            try {
                excelFileHandler.SetCellValue(1, 1, "Created");
                excelFileHandler.SetCellValue(1, 2, "Modified");
                excelFileHandler.SetCellValue(1, 3, "Name");
                excelFileHandler.SetCellValue(1, 4, "Pokedex Resource Uri");
                excelFileHandler.SetCellValue(1, 5, "Pokemon Count");
                excelFileHandler.SetCellValue(1, 6, "Test Results");
                excelFileHandler.SetCellValue(1, 7, "Time Elapsed");

                excelFileHandler.SetCellValue(2, 1, ((DateTime)pokedex.Created).ToString("yyyy-MM-dd"));
                excelFileHandler.SetCellValue(2, 2, ((DateTime)pokedex.Modified).ToString("yyyy-MM-dd"));
                excelFileHandler.SetCellValue(2, 3, pokedex.Name);
                excelFileHandler.SetCellValue(2, 4, pokedex.PokedexResourceUri);
                excelFileHandler.SetCellValue(2, 5, pokedex.PokemonResourceUriList.Count.ToString());
                excelFileHandler.SetCellValue(2, 6, "OK");
                excelFileHandler.SetCellValue(2, 7, elapsedTime);

                excelFileHandler.SaveAs();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Unable to create Excel Application for the following reason: " + e.StackTrace);
            }
            finally
            {
                excelFileHandler.Close();
            }
        }
    }
}

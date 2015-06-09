using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokeWrapper.API;
using PokeWrapper.DataContacts;
using PokeWrapper.DataContracts;
using PokeWrapper.Wrappers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.UnitTests
{
    [TestClass]
    public class PokemonDataContractTest
    {
        [TestMethod]
        public void getPokemonList()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            PokedexDataContract pokedex = DataContractGenerator<PokedexDataContract>.getInstance(1);

            List<PokemonDataContract> pokemonList = pokedex.httpGetPokemonList();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Debug.WriteLine("RunTime: " + elapsedTime);

            generateReport(pokemonList, elapsedTime);
        }

        public void generateReport(List<PokemonDataContract> pokemonList, string elapsedTime)
        {
            ExcelFileHandler excelFileHandler = null;

            try
            {
                excelFileHandler = new ExcelFileHandler("PokemonUnitTestResults.xlsx");

                excelFileHandler.SetCellValue(1, 1, "PokedexId");
                excelFileHandler.SetCellValue(1, 2, "Name");
                excelFileHandler.SetCellValue(1, 3, "Hp");
                excelFileHandler.SetCellValue(1, 4, "Attack");
                excelFileHandler.SetCellValue(1, 5, "SpAtk");
                excelFileHandler.SetCellValue(1, 6, "Defense");
                excelFileHandler.SetCellValue(1, 7, "SpDef");
                excelFileHandler.SetCellValue(1, 8, "Speed");
                excelFileHandler.SetCellValue(1, 9, "EvYield");
                excelFileHandler.SetCellValue(1, 6, "Test Results");
                excelFileHandler.SetCellValue(1, 7, "Time Elapsed");

                int baseRowCount = 2;
                foreach (PokemonDataContract pokemon in pokemonList)
                {
                    excelFileHandler.SetCellValue(baseRowCount, 1, pokemon.PkdxId.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 2, pokemon.Name.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 3, pokemon.Hp.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 4, pokemon.Attack.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 5, pokemon.SpAtk.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 6, pokemon.Defense.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 7, pokemon.SpDef.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 8, pokemon.Speed.ToString());
                    excelFileHandler.SetCellValue(baseRowCount, 9, pokemon.EvYield);
                    baseRowCount++;
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

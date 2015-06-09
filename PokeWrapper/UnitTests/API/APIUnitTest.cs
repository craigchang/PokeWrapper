using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokeWrapper.API;
using PokeWrapper.DataContracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWrapper.UnitTests
{
    [TestClass]
    public class APIUnitTest
    {
        [TestMethod]
        public void PokedexAPI_UnitTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            PokedexDataContract pokedex = Pokedex.getInstance(1);

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
        }
    }
}

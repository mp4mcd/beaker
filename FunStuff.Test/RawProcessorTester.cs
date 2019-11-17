using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FunStuff.Test
{
    [TestClass]
    public class RawProcessorTester
    {
        [TestMethod]
        public void FindMultipleColors()
        {
            string raw = "'My favorite color is red!' she exclaimed, while hailing a yellow taxi.";

            List<string> colorsFound = new RawProcessor().DetectPrimaryColors(raw);

            Assert.IsTrue(colorsFound.Contains("yellow"));
            Assert.IsTrue(colorsFound.Contains("red"));
        }

        [TestMethod]
        public void FindYellow()
        {
            string raw = "Pass some yellow mustard, please.";

            List<string> colorsFound = new RawProcessor().DetectPrimaryColors(raw);

            Assert.IsTrue(colorsFound.Contains("yellow"));
        }


        [TestMethod]
        public void FindBlue()
        {

            string raw = "5601 XL221 blue 622-14-323455-24 rockfish 632";

            List<string> colorsFound = new RawProcessor().DetectPrimaryColors(raw);

            Assert.IsTrue(colorsFound.Contains("blue"));
        }


        [TestMethod]
        public void Bug35()
        {

            string raw = "I listen to the Blues.";

            List<string> colorsFound = new RawProcessor().DetectPrimaryColors(raw);

            Assert.IsTrue(colorsFound.Contains("blue"));
        }
    }



}

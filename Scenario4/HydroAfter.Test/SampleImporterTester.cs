using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;

namespace HydroAfter.Test
{
    [TestClass]
    public class SampleImporterTester
    {

        [TestMethod]
        public void TacomaWontLoad()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("HydroAfter.Test.tacoma1.txt");

            SampleImporter importer = new SampleImporter(stream);
            importer.ImportToDatabase();

        }
    }
}

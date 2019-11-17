using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HydroBefore.Test
{
    [TestClass]
    public class SampleImporterTester
    {

        [TestMethod]
        public void TacomaWontLoad()
        {
            SampleImporter importer = new SampleImporter("tacoma1.txt");
            importer.ImportToDatabase();
        }
    }
}

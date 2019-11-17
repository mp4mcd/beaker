using System;
using System.IO;

namespace HydroBefore
{
    public class SampleImporter
    {        
        string _rawInputFileName;
        public SampleImporter(string rawInputFileName)
        {
            _rawInputFileName = rawInputFileName;
        }        
        
        public void ImportToDatabase()
        {
            // uses a filename
            FileStream stream = new FileStream(_rawInputFileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            
            string wholeFile = reader.ReadToEnd();

            string[] recordArray = GetRecords(wholeFile);

            foreach (string record in recordArray)
            {
                string[] fields = record.Split('\t');

                string sampleDescrpiption = fields[0];
                DateTime sampleTime = Convert.ToDateTime(fields[1]);
                int sampleResult = Convert.ToInt32(fields[2]);
            }
        }

        private string[] GetRecords(string wholeFile)
        {
            string[] delim = { "\r\n" };
            string[] records = wholeFile.Split(delim, StringSplitOptions.None);
            return records;
        }

    }
}

using System;
using System.IO;

namespace HydroAfter
{
    public class SampleImporter
    {
        // uses abstract stream0
        Stream _rawStream;

        public SampleImporter(Stream rawStream)
        {
            _rawStream = rawStream;
        }

        public void ImportToDatabase()
        {
            StreamReader reader = new StreamReader(_rawStream);

            string wholeFile = reader.ReadToEnd();

            string[] recordArray = GetRecords(wholeFile);

            foreach (string record in recordArray)
            {
                string[] fields = record.Split('\t');

                string sampleDescrpiption = fields[0];
                DateTime sampleTime = Convert.ToDateTime(fields[1]);
                //int sampleResult = Convert.ToInt32(fields[2]);
                decimal sampleResult = Convert.ToDecimal(fields[2]);
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
#region corrected code
//decimal sampleResult = Convert.ToDecimal(fields[2]);
#endregion
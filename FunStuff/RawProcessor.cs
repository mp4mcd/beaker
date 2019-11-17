using System.Collections.Generic;

namespace FunStuff
{
    public class RawProcessor
    {
        public List<string> DetectPrimaryColors(string customerInput)
        {
            List<string> colorsFound = new List<string>();

            if (customerInput.Contains("red"))
            {
                colorsFound.Add("red");
            }

            if (customerInput.Contains("yellow"))
            {
                colorsFound.Add("yellow");
            }

            if (customerInput.Contains("blue"))
            {
                colorsFound.Add("blue");
            }

            return colorsFound;
        }
        
    }
}

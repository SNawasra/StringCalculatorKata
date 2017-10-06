using StringKataCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataCalculator
{
    public class Delimiters : IDelimiters
    {
        public List<string> GetDelimiters(string stringNumbers)
        {
            List<string> delimiters = new List<string>() { ",", "\n" }; ;

            if (stringNumbers.StartsWith("//"))
            {
                string startofDelimiter = stringNumbers[2].ToString();
                if (startofDelimiter.StartsWith("["))
                {
                    string delimiterSection = stringNumbers.Substring(2, stringNumbers.IndexOf("\n") - 2);
                    string[] splits = delimiterSection.Split(']');

                    for (int i = 0; i < splits.Length - 1; i++)
                    {
                        delimiters.Add(splits[i].Remove(0, 1));
                    }
                }
                else
                {
                    delimiters.Add(startofDelimiter);
                }
            }

            return delimiters.OrderByDescending(xc => xc.Length).ToList();
        }
    }
}

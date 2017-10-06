using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataCalculator
{
    public class StringKataCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;
            List<int> parsedNumbers = ParseStringNumbers(numbers);
            CheckNegativeNumbers(parsedNumbers);
            return ParseStringNumbers(numbers).Where(n => n > 0 && n < 1000).Sum();
        }

        private List<int> ParseStringNumbers(string numbers)
        {
            List<int> validIntegers = new List<int>();
            var delimiters = GetDelimiters(numbers);

            string[] numbersList = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            for (int i = 0; i < numbersList.Length; i++)
            {
                int value = 0;
                if (int.TryParse(numbersList[i], out value)) validIntegers.Add(value);
            }

            return validIntegers;
        }


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

        private void CheckNegativeNumbers(List<int> parsedNumbers)
        {
            List<int> negativeNumbers = parsedNumbers.Where(n => n < 0).Select(n => n).ToList();
            if (negativeNumbers.Any())
            {
                throw new Exception(string.Format("negatives not allowed {0}", string.Join(",", negativeNumbers)));
            }
        }
    }
}

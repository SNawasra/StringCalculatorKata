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
            return ParseStringNumbers(numbers).Sum();
        }

        private List<int> ParseStringNumbers(string numbers)
        {
            List<int> validIntegers = new List<int>();
            var delimiters  = new List<String>() {"\n" };
            var newDelimiters = Parse(numbers);

            if(newDelimiters != null && newDelimiters.Count > 0)
            {
                delimiters.AddRange(newDelimiters);
            }
            else
            {
                delimiters.Add(",");
            }


            string[] numbersList = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            for (int i = 0; i < numbersList.Length; i++)
            {
                int value = 0;
                if (int.TryParse(numbersList[i], out value)) validIntegers.Add(value);
            }

            return validIntegers;
        }

        public List<string> Parse(string stringNumbers)
        {
            List<string> delimiters = new List<string>();

            if (stringNumbers.StartsWith("//"))
            {
                string delimiter = stringNumbers[2].ToString();
                delimiters.Add(delimiter);
            }

            return delimiters;
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

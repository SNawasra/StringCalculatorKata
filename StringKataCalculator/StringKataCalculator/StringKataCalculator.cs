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
            return ParseStringNumbers(numbers).Sum();
        }

        private List<int> ParseStringNumbers(string numbers)
        {
            List<int> validIntegers = new List<int>();
            var delimiters  = new List<String>() { ",", "\n" }.ToArray();
            string[] numbersList = numbers.Split(delimiters, StringSplitOptions.None);

            for (int i = 0; i < numbersList.Length; i++)
            {
                int value = 0;
                if (int.TryParse(numbersList[i], out value)) validIntegers.Add(value);
            }

            return validIntegers;
        }
    }
}

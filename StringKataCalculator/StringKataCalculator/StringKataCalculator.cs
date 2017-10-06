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
            int sum = parsedNumbers.Sum();
            return sum;
        }

        private List<int> ParseStringNumbers(string numbers)
        {
            List<int> validIntegers = new List<int>();
            string[] numberList = numbers.Split(',');

            for (int i = 0; i < numberList.Length; i++)
            {
                int value = 0;
                if (int.TryParse(numberList[i], out value)) validIntegers.Add(value);
            }

            return validIntegers;
        }
    }
}

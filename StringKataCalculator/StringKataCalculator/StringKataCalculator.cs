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
            int sum = ParseStringNumbers(numbers);
            return sum;
        }

        private int ParseStringNumbers(string numbers)
        {
            string[] numberList = numbers.Split(',');

            if (numberList == null) return 0;
            else if (numberList.Length == 0) return 0;
            else if (numberList.Length == 1) 
            {
                int value = 0;
                int.TryParse(numberList[0], out value);          
                return value;
            }
            else
            {
                int value1 = 0;
                int value2 = 0;
                int.TryParse(numberList[0], out value1);
                int.TryParse(numberList[1], out value2);
                return value1 + value2;
            }
        }
    }
}

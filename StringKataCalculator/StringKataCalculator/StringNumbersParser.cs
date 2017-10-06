using StringKataCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataCalculator
{
    public class StringNumbersParser : IStringNumbersParser
    {
        private IDelimiters _delimiters;
        public StringNumbersParser(IDelimiters delimiters)
        {
            _delimiters = delimiters;

        }

        public List<int> Parse(string numbers)
        {
            List<int> validIntegers = new List<int>();
            var delimiters = _delimiters.GetDelimiters(numbers);

            string[] numbersList = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            for (int i = 0; i < numbersList.Length; i++)
            {
                int value = 0;
                if (int.TryParse(numbersList[i], out value)) validIntegers.Add(value);
            }

            return validIntegers;
        }
    }
}

using StringKataCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataCalculator
{
    public class StringKataCalculator : IStringKataCalculator
    {
        private IStringNumbersParser _stringNumbersParser;
        public StringKataCalculator(IStringNumbersParser stringNumbersParser)
        {
            _stringNumbersParser = stringNumbersParser;
        }

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;
            var parsedNumbers = _stringNumbersParser.Parse(numbers);
            CheckNegativeNumbers(parsedNumbers);
            return parsedNumbers.Where(n => n > 0 && n < 1000).Sum();
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

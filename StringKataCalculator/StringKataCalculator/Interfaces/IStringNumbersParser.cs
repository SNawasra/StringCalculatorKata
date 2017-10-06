using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataCalculator.Interfaces
{
    public interface IStringNumbersParser
    {
        List<int> Parse(string numbers);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverterLibrary
{
    internal class TemparatureValidator
    {
        const double AbsoluteZero = -273.15;
        const double MaxTemperature = 5500;
        public bool Validate(double temp) {
            if(temp < AbsoluteZero || temp > MaxTemperature)
                return false;
            return true;
        }
    }
}

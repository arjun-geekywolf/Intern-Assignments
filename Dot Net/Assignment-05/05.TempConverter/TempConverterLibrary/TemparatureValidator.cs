using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverterLibrary
{
    internal class TemparatureValidator
    {
        public bool Validate(double temp) {
            if(temp < -273.15 || temp > 5500)
                return false;
            return true;
        }
    }
}

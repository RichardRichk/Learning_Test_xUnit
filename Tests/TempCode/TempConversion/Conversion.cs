using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConversion
{
    public static class Conversion
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            var fahrenheit = ((celsius * 1.8) + 32);

            return fahrenheit;
        }
    }
}

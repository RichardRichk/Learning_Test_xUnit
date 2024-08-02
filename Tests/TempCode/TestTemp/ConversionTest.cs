using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempConversion;

namespace TestTemp
{
    public class ConversionTest
    {
        [Fact]
        public void TestConversion() 
        {
            var celsius = 26.2;

            var resultFahrenheit = 79.16;

            var calcFahrenheit = Conversion.CelsiusToFahrenheit(celsius);

            Assert.Equal(resultFahrenheit, calcFahrenheit);

        }
    }
}

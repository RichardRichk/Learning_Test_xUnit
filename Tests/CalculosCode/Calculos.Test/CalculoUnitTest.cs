using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {

        ///AAA : Act, Arrange, Assert
        /// AAA : Agir, Organizar, Assertir
        [Fact]
        public void TestarMetodoSomar()
        {
            //Arrange : Organizar
            var x1 = 4.1;
            var x2 = 5.9;

            var valorEsperado = 10;

            //ACT : Agir
            var soma = Calculo.Somar(x1, x2);

            //Assert: Provar
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void TestarSubtrair() 
        {
            var x1 = 33;
            var x2 = 3;

            var valorEsperado = 30;

            var subtracao = Calculo.subtracao(x1, x2);

            Assert.Equal(valorEsperado, subtracao);
        }

        [Fact]
        public void TestarMultiplicar()
        {
            var x1 = 4;
            var x2 = 5;

            var valorEsperado = 20;

            var multiplicacao = Calculo.Multiplicar(x1,x2);

            Assert.Equal(valorEsperado , multiplicacao);
        }

        [Fact]
        public void TestarDividir() 
        {
            var x1 = 76.3407;
            var x2 = 24.3;

            var valorEsperado = 3.1415925925925925;

            var divisao = Calculo.Divide(x1,x2);

            Assert.Equal(valorEsperado, divisao);
        }
    }
}

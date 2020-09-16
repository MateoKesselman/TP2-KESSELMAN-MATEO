using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EJ1.Test
{
    public class PuntoTests
    {
        [Fact]
        public void Test_Calcular_Distancia_Desde()
        {
            //ARRANGE
            var punto1 = new Punto(7, 8);
            var punto2 = new Punto(3, 4);

            //ACT
            var distancia = punto1.CalcularDistanciaDesde(punto2);

            //ASSERT
            Assert.Equal(5.66, distancia, 2);
        }
    }
}

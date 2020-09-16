using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EJ1.Test
{
    public class TrianguloTests
    {
        [Fact]
        public void Test_Area()
        {
            //ARRANGE
            var triangulo = new Triangulo(new Punto(1,2), new Punto(4, 5), new Punto(7, 9));

            //ACT
            var area = triangulo.Area;

            //ASSERT
            Assert.Equal(1.50, area, 2) ;
        }

        [Fact]
        public void Test_Perimetro()
        {
            //ARRANGE
            var triangulo = new Triangulo(new Punto(1, 2), new Punto(4, 5), new Punto(7, 9));

            //ACT
            var perimetro = triangulo.Perimetro;

            //ASSERT
            Assert.Equal(18.46, perimetro, 2);
        }
    }
 }
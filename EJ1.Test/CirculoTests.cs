using System;
using Xunit;

namespace EJ1.Test
{
    public class CirculoTests
    {
        [Fact]
        public void Test_Area()
        {
            //ARRANGE
            var circulo = new Circulo(0,0,10);

            //ACT
            var area = circulo.Area;

            //ASSERT
            Assert.Equal(314.16, area, 2);
        }

        [Fact]
        public void Test_Area_Otro_Origen()
        {
            //ARRANGE
            var circulo = new Circulo(1, 1, 10);

            //ACT
            var area = circulo.Area;

            //ASSERT
            Assert.Equal(314.16, area, 2);
        }

        [Fact]
        public void Test_Perimetro()
        {
            //ARRANGE
            var circulo = new Circulo(new Punto(0,0), 10);

            //ACT
            var perimetro = circulo.Perimetro;

            //ASSERT
            Assert.Equal(62.83, perimetro, 2);
        }

        [Fact]
        public void Test_Perimetro_Otro_Origen()
        {
            //ARRANGE
            var circulo = new Circulo(new Punto(7, 7), 10);

            //ACT
            var perimetro = circulo.Perimetro;

            //ASSERT
            Assert.Equal(62.83, perimetro, 2);
        }



    }       
}

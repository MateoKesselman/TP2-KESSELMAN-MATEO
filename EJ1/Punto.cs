using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    public class Punto
    {
        private double iX;
        private double iY;

        //CONSTRUCTOR
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        //PROPIEDADES
        public double X
        { 
            get { return this.iX; }
            set { this.iX = value; }
        }

        public double Y
        {

            get { return this.iY; }
            set { this.iY = value; }
        }

        public double CalcularDistanciaDesde (Punto pPunto)
        {
            double a = Math.Pow((pPunto.X - this.X), 2);
            double b = Math.Pow((pPunto.Y - this.Y), 2);
            return Math.Sqrt(a + b);
        }
    }
}
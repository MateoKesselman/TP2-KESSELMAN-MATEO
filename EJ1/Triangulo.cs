using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    public class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        //CONSTRUCTOR
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        //PROPERTIES
        public Punto Punto1
        {
            get { return this.iPunto1; }
            set { this.iPunto1 = value; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
            set { this.iPunto2 = value; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
            set { this.iPunto3 = value; }
        }

        public double Perimetro
        {
            get
            {
                double L1 = Punto2.CalcularDistanciaDesde(Punto1);
                double L2 = Punto2.CalcularDistanciaDesde(Punto3);
                double L3 = Punto1.CalcularDistanciaDesde(Punto3);
                return L1 + L2 + L3;
            }
        }

        public double Area //FORMULA DE HERÓN
        {
            get {
                double L1 = Punto2.CalcularDistanciaDesde(Punto1);
                double L2 = Punto2.CalcularDistanciaDesde(Punto3);
                double L3 = Punto1.CalcularDistanciaDesde(Punto3);
                double sPer = (L1 + L2 + L3) / 2;
                return Math.Sqrt(sPer * (sPer - L1) * (sPer - L2) * (sPer - L3));
            }
        }
    }
}

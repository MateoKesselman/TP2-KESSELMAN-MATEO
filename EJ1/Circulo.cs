using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    public class Circulo
    {
        private double iRadio;
        private Punto iCentro;

        //CONSTRUCTORES
        public Circulo (Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;
        }

        public Circulo (double pX, double pY, double pRadio)
        {
 
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX,pY);
        }

        //PROPERTIES

        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        public double Area
        {
            get { return (Math.PI * (Math.Pow(this.iRadio, 2))); }      
        }

        public double Perimetro
        {
            get { return (Math.PI * (2 * this.iRadio)); }
        }

    }
}
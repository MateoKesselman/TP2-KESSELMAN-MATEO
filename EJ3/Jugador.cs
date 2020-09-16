using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    public class Jugador
    {
        private string iNombre;
        private int iEdad;
        private string iNacionalidad;

        public Jugador (string pNombre, int pEdad, string pNacionalidad)
        {
            this.iNombre = pNombre;
            this.iEdad = pEdad;
            this.iNacionalidad = pNacionalidad;
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public int Edad
        {
            get { return this.iEdad; }
            set { this.iEdad = value; }
        }

        public string Nacionalidad
        {
            get { return this.iNacionalidad; }
            set { this.iNacionalidad = value; }
        }
    }
}

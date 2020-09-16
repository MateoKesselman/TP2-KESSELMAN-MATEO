using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{
    public class Moneda
    {
        private string iCodigoISO;
        private string iNombre;
        private string iSimbolo;

        //CONSTRUCTOR
        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            this.iCodigoISO = pCodigoISO;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }

        //PROPERTIES
        public string CodigoISO
        {
            get { return this.iCodigoISO; }
            set { this.iCodigoISO = value; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
        public string Simbolo
        {
            get { return this.iSimbolo; }
            set { this.iSimbolo = value; }
        }
    }

}
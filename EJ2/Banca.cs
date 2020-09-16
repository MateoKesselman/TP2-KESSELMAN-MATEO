using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{
    public class Banca
    {
        private string iNumero;
        private string iTitular;
        private Cuenta iCuentaEnDolares;
        private Cuenta iCuentaEnPesos;

        //CONSTRUCTOR
        public Banca (string pNumero, string pTitular)
        {
            this.iNumero = pNumero;
            this.iTitular = pTitular;
        }
        //PROPERTIES
        public Cuenta CuentaEnPesos
        {
            get { return this.iCuentaEnPesos; }
            set { this.iCuentaEnPesos = value;  }
        }
        public Cuenta CuentaEnDolares
        {
            get { return this.iCuentaEnDolares; }
            set { this.iCuentaEnDolares = value; }
        }
        public string Numero
        {
            get { return this.iNumero; }
            set { this.iNumero = value; }
        }
        public string Titular
        {
            get { return this.iTitular; }
            set { this.iTitular = value; }
        }

    }
}

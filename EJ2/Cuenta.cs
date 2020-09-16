using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{
    public class Cuenta
    {
        private double iSaldo;
        private Moneda iMoneda;

        //CONSTRUCTORES
        public Cuenta (Moneda pMoneda)
        {
            this.iSaldo = 0;
            this.iMoneda = pMoneda;
        }
        public Cuenta (double pSaldoInicial, Moneda pMoneda)
        {
            this.iSaldo = pSaldoInicial;
            this.iMoneda = pMoneda;
        }

        //PROPERTIES
        public double Saldo
        {
            get { return this.iSaldo; }
        }
        
        public void AcreditarSaldo (double pSaldo)
        {
            this.iSaldo = this.iSaldo + pSaldo;
        }
       
        public bool DebitarSaldo (double pSaldo)
        {
          
            bool debitarSaldo = false;

            if (pSaldo <= this.iSaldo)
            {
                this.iSaldo = this.iSaldo - pSaldo;
                debitarSaldo = true;
            }

            return debitarSaldo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{
    public class Facade
    {
        private RepositorioBanca repositorio = new RepositorioBanca();

        public bool VerificarExistenciaDeCuenta(string pNumero)
        {
            bool verificarExistenciaDeCuenta = false;
            Banca cuentaUnif = repositorio.Obtener(pNumero);
            
            if (cuentaUnif != null)
            {
                verificarExistenciaDeCuenta = true;
            }

            return verificarExistenciaDeCuenta;
        }

        public void CrearCuentaUnificada(string pNumero, string pTitular)
        {
            Banca cuentaUnificada = new Banca(pNumero,pTitular);
            var cuentaEnPesos = new Cuenta(new Moneda("ARS","Peso","$"));
            var cuentaEnDolares = new Cuenta(new Moneda("USD", "Dolar", "U$D"));
            cuentaUnificada.CuentaEnPesos = cuentaEnPesos;
            cuentaUnificada.CuentaEnDolares = cuentaEnDolares;
            repositorio.Agregar(cuentaUnificada);
        }

        public void AcreditarCuentaEnPesos (string pNumero, double pSaldo)
        {
             Banca cuentaUnif = repositorio.Obtener(pNumero);
             Cuenta cuentaEnP = cuentaUnif.CuentaEnPesos;
             cuentaEnP.AcreditarSaldo(pSaldo);
        }

        public bool DebitarCuentaEnPesos(string pNumero, double pSaldo)
        {
            bool debitarCuentaEnPesos = false;
            Banca cuentaUnif = repositorio.Obtener(pNumero);
            Cuenta cuentaEnP = cuentaUnif.CuentaEnPesos;

            if (pSaldo <= cuentaEnP.Saldo)
            {
                cuentaEnP.DebitarSaldo(pSaldo);
                debitarCuentaEnPesos = true;
            }

            return debitarCuentaEnPesos;
        }

        public double ObtenerSaldoCuentaEnPesos(string pNumero)
        {
            Banca cuentaUnif = repositorio.Obtener(pNumero);
            Cuenta cuentaEnP = cuentaUnif.CuentaEnPesos;
            return cuentaEnP.Saldo;
        }

        public void AcreditarCuentaEnDolares(string pNumero, double pSaldo)
        {
            Banca cuentaUnif = repositorio.Obtener(pNumero);
            Cuenta cuentaEnD = cuentaUnif.CuentaEnDolares;
            cuentaEnD.AcreditarSaldo(pSaldo);
        }

        public bool DebitarCuentaEnDolares(string pNumero, double pSaldo)
        {
            bool debitarCuentaEnDolares = false;
            Banca cuentaUnif = repositorio.Obtener(pNumero);
            Cuenta cuentaEnD = cuentaUnif.CuentaEnDolares;

            if (pSaldo <= cuentaEnD.Saldo)
            {
                cuentaEnD.DebitarSaldo(pSaldo);
                debitarCuentaEnDolares = true;
            }

            return debitarCuentaEnDolares;
        }

        public double ObtenerSaldoCuentaEnDolares(string pNumero)
        {
            Banca cuentaUnif = repositorio.Obtener(pNumero);
            Cuenta cuentaEnD = cuentaUnif.CuentaEnDolares;
            return cuentaEnD.Saldo;
        }

        public bool TransferirPesosACuentaEnDolares(string pNumero, double pSaldo)
        {
            bool transferirPesosACuentaEnDolares = false;

            Banca cuentaUnif = repositorio.Obtener(pNumero);
            Cuenta cuentaEnD = cuentaUnif.CuentaEnDolares;
            Cuenta cuentaEnP = cuentaUnif.CuentaEnPesos;

            if (pSaldo <= cuentaEnP.Saldo)
            {
                cuentaEnP.DebitarSaldo(pSaldo);
                cuentaEnD.AcreditarSaldo(pSaldo/140);
                transferirPesosACuentaEnDolares = true;
            }

            return transferirPesosACuentaEnDolares;
        }
        public bool TransferirDolaresACuentaEnPesos(string pNumero, double pSaldo)
        {
            bool transferirDolaresACuentaEnPesos = false;

            Banca cuentaUnif = repositorio.Obtener(pNumero);
            Cuenta cuentaEnD = cuentaUnif.CuentaEnDolares;
            Cuenta cuentaEnP = cuentaUnif.CuentaEnPesos;

            if (pSaldo <= cuentaEnD.Saldo)
            {
                cuentaEnD.DebitarSaldo(pSaldo);
                cuentaEnP.AcreditarSaldo(pSaldo*135);
                transferirDolaresACuentaEnPesos = true;
            }

            return transferirDolaresACuentaEnPesos;
        }
    }
}
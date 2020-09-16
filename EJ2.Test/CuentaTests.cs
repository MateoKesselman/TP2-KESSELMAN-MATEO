using NuGet.Frameworks;
using System;
using Xunit;

namespace EJ2.Test
{
    public class CuentaTests
    {
        [Fact]
        public void Test_Acreditar_Saldo()
        {
            //ARRANGE
            var Cuenta = new Cuenta(400, new Moneda("ARS","Peso Argentino", "$"));

            //ACT
            Cuenta.AcreditarSaldo(250);
            double saldo = Cuenta.Saldo;

            //ASSERT
            Assert.Equal(650,saldo);

        }

        [Fact]
        public void Test_Debitar_Saldo_Efectuado()
        {
            //ARRANGE
            var Cuenta = new Cuenta(4000, new Moneda("ARS", "Peso Argentino", "$"));

            //ACT
            Cuenta.DebitarSaldo(2500);
            double saldo = Cuenta.Saldo;

            //ASSERT
            Assert.Equal(1500, saldo);

        }

        [Fact]
        public void Test_Debitar_Saldo_No_Efectuado()
        {
            //ARRANGE
            var Cuenta = new Cuenta(400, new Moneda("ARS", "Peso Argentino", "$"));

            //ACT
            Cuenta.DebitarSaldo(2500);
            double saldo = Cuenta.Saldo;

            //ASSERT
            Assert.Equal(400, saldo);
        }
    }
}

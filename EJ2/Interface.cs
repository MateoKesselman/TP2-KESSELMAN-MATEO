using System;

namespace EJ2
{
    public class Interface
    {
        static void Main(string[] args)
        {
            int nNumero = 6;
            var facade = new Facade();
            while (nNumero != 0)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ BIENVENIDO AL BANCO NACIÓN ------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ 1_CREAR CUENTA UNIFICADA---------------------------");
                Console.WriteLine(" ------------------ 2_REALIZAR OPERACIÓN EN UNA CUENTA EXISTENTE-------");
                Console.WriteLine(" ------------------ 3_REALIZAR TRANSFERENCIA --------------------------");
                Console.WriteLine(" ------------------ 0_SALIR -------------------------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();

                Console.Write("INTRODUZCA NÚMERO:");
                nNumero = int.Parse(Console.ReadLine());

                switch (nNumero)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("INGRESE NUEVO NÚMERO DE CUENTA UNIFICADO (DNI): ");
                        string numeroCuenta = Console.ReadLine();
                        Console.Write("INGRESE NOMBRE DEL TITULAR: ");
                        string nombreTitular = Console.ReadLine();
                        facade.CrearCuentaUnificada(numeroCuenta,nombreTitular);
                        break;
                    case 2:
                        int cuentaElegida = 3;
                        int operación = 0;
                        Console.Clear();
                        Console.Write("INGRESE NÚMERO UNIFICADO DE CUENTA (DNI): ");
                        string pNumCuenta = Console.ReadLine();

                        while (cuentaElegida != 0)
                        {
                            cuentaElegida = 3;
                            operación = 0;
                            while ((cuentaElegida != 1) && (cuentaElegida != 2)&&(cuentaElegida != 0))
                            {
                                Console.Clear();
                                Console.WriteLine(" ----------------------------------------------------------------------");
                                Console.WriteLine(" ------------------ 1_CUENTA EN PESOS ---------------------------------");
                                Console.WriteLine(" ------------------ 2_CUENTA EN DOLARES -------------------------------");
                                Console.WriteLine(" ------------------ 0_SALIR -------------------------------------------");
                                Console.WriteLine(" ----------------------------------------------------------------------");
                                Console.WriteLine();
                                Console.Write("INTRODUZCA NÚMERO:");
                                cuentaElegida = int.Parse(Console.ReadLine());
                            }

                                if (cuentaElegida != 0)
                                {
                                    while ((operación != 1) && (operación != 2) && (operación != 3))
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" ----------------------------------------------------------------------");
                                        Console.WriteLine(" ------------------ 1_ACREDITAR SALDO ---------------------------------");
                                        Console.WriteLine(" ------------------ 2_DEBITAR SALDO -----------------------------------");
                                        Console.WriteLine(" ------------------ 3_MOSTRAR SALDO -----------------------------------");
                                        Console.WriteLine(" ----------------------------------------------------------------------");
                                        Console.WriteLine();
                                        Console.Write("INTRODUZCA NÚMERO:");
                                        operación = int.Parse(Console.ReadLine());
                                    }
                                }
                                Console.Clear();

                                if (cuentaElegida == 1)
                                {
                                    if (operación == 1)
                                    {
                                        Console.Write("INGRESE SALDO A ACREDITAR: ");
                                        double pSaldo = Convert.ToDouble(Console.ReadLine());
                                        facade.AcreditarCuentaEnPesos(pNumCuenta, pSaldo);
                                    }
                                    else if (operación == 2)
                                    {
                                        Console.Write("INGRESE SALDO A DEBITAR: ");
                                        double pSaldo = Convert.ToDouble(Console.ReadLine());
                                        bool control = facade.DebitarCuentaEnPesos(pNumCuenta, pSaldo);
                                        Console.Clear();
                                        if (control)
                                        {
                                            Console.WriteLine("LA OPERACIÓN FUE REALIZADA CON ÉXITO");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("SALDO INSUFICIENTE PARA REALIZAR LA OPERACIÓN");
                                            Console.ReadKey();
                                        }
                                }
                                    else if (operación == 3)
                                    {
                                        double result = facade.ObtenerSaldoCuentaEnPesos(pNumCuenta);
                                        Console.WriteLine("SALDO DISPONIBLE: " + result);
                                        Console.ReadKey();
                                    }
                                }
                                else if (cuentaElegida == 2)
                                {
                                    if (operación == 1)
                                    {
                                        Console.Write("INGRESE SALDO A ACREDITAR: ");
                                        double pSaldo = Convert.ToDouble(Console.ReadLine());
                                        facade.AcreditarCuentaEnDolares(pNumCuenta, pSaldo);
                                }
                                    else if (operación == 2)
                                    {
                                        Console.Write("INGRESE SALDO A DEBITAR: ");
                                        double pSaldo = Convert.ToDouble(Console.ReadLine());
                                        bool control = facade.DebitarCuentaEnDolares(pNumCuenta, pSaldo);
                                        Console.Clear();
                                        if (control)
                                        {
                                            Console.WriteLine("LA OPERACIÓN FUE REALIZADA CON ÉXITO");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("SALDO INSUFICIENTE PARA REALIZAR LA OPERACIÓN");
                                            Console.ReadKey();
                                        }
                                }
                                    else if (operación == 3)
                                    {
                                        double result = facade.ObtenerSaldoCuentaEnDolares(pNumCuenta);
                                        Console.WriteLine("SALDO DISPONIBLE: " + result);
                                        Console.ReadKey();
                                    }

                                }                 
                            
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("INGRESE NÚMERO UNIFICADO DE CUENTA (DNI): ");
                        string pNumeroCuenta = Console.ReadLine();
                        int op = 3;
                        while (op != 0)
                        { 
                            while ((op != 1) && (op != 2) && (op != 0))
                            {
                                Console.Clear();
                                Console.WriteLine(" ----------------------------------------------------------------------");
                                Console.WriteLine(" ------------ 1_TRANSFERIR PESOS A LA CUENTA EN DOLARES ---------------");
                                Console.WriteLine(" ------------ 2_TRANSFERIR DOLARES A LA CUENTA EN PESOS ---------------");
                                Console.WriteLine(" ------------ 0_SALIR -------------------------------------------------");
                                Console.WriteLine(" ----------------------------------------------------------------------");
                                Console.WriteLine();
                                Console.Write("INTRODUZCA NÚMERO:");
                                op = int.Parse(Console.ReadLine());
                            }

                            if (op == 1)
                            {
                                Console.Clear();
                                double resultado = facade.ObtenerSaldoCuentaEnPesos(pNumeroCuenta);
                                Console.WriteLine("SALDO EN PESOS DISPONIBLE: " + resultado);
                                Console.Write("INGRESE SALDO EN PESOS A TRANSFERIR A LA CUENTA EN DOLARES (140 PESOS = 1 DOLAR): ");
                                double pSaldo = Convert.ToDouble(Console.ReadLine());
                                bool control = facade.TransferirPesosACuentaEnDolares(pNumeroCuenta, pSaldo);
                                Console.Clear();
                                if (control)
                                {
                                    Console.WriteLine("LA OPERACIÓN FUE REALIZADA CON ÉXITO");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("SALDO INSUFICIENTE PARA REALIZAR LA OPERACIÓN");
                                    Console.ReadKey();
                                }
                                op = 3;
                            }
                            else if (op == 2)
                            {
                                Console.Clear();
                                double resultado = facade.ObtenerSaldoCuentaEnDolares(pNumeroCuenta);
                                Console.WriteLine("SALDO EN DOLARES DISPONIBLE: " + resultado);
                                Console.Write("INGRESE SALDO EN DOLARES A TRANSFERIR A LA CUENTA EN PESOS (1 DOLAR = 135 PESOS): ");
                                double pSaldo = Convert.ToDouble(Console.ReadLine());
                                bool control = facade.TransferirDolaresACuentaEnPesos(pNumeroCuenta, pSaldo);
                                Console.Clear();
                                if (control)
                                {
                                    Console.WriteLine("LA OPERACIÓN FUE REALIZADA CON ÉXITO");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("SALDO INSUFICIENTE PARA REALIZAR LA OPERACIÓN");
                                    Console.ReadKey();
                                }
                                op = 3;
                            }     
                        }
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("FINALIZADO");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("INGRESÓ UNA OPCIÓN INCORRECTA");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
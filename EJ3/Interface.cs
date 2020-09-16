using System;

namespace EJ3
{
    public class Interface
    {
        static void Main(string[] args)
        {
            int nNumero = 6;
            while (nNumero != 0)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ BIENVENIDO AL AHORCADO ----------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ 1_CREAR CUENTA ------------------------------------");
                Console.WriteLine(" ------------------ 2_REALIZAR OPERACIÓN ------------------------------");
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
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
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

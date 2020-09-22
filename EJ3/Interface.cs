using System;

namespace EJ3
{
    public class Interface
    {
        static void Main(string[] args)
        {
            int nNumero = 4;
            int maxCantFallos = 10;
            Facade facade = new Facade();

            while (nNumero != 0)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ BIENVENIDO AL AHORCADO ----------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ 1_JUGAR -------------------------------------------");
                Console.WriteLine(" ------------------ 2_MODIFICAR CANTIDAD MÁXIMA DE FALLOS (ACTUAL " + maxCantFallos + ")");
                Console.WriteLine(" ------------------ 3_RECORDS -----------------------------------------");
                Console.WriteLine(" ------------------ 0_SALIR -------------------------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();

                Console.Write(" INTRODUZCA NÚMERO:");
                nNumero = int.Parse(Console.ReadLine());

                switch (nNumero)
                {
                    case 1:
                        bool control = true;
                        Console.Clear();
                        Console.WriteLine(" ----------------------------------------------------------------------");
                        Console.Write(" INGRESE NOMBRE: ");
                        string nNombre = Console.ReadLine();
                        Console.WriteLine(" ----------------------------------------------------------------------");
                        Console.Write(" INGRESE EDAD: ");
                        int nEdad = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ----------------------------------------------------------------------");
                        Console.Write(" INGRESE NACIONALIDAD: ");
                        string nNacionalidad = Console.ReadLine();
                        while (control)
                        {
                            facade.JugarPartida(nNombre, nEdad, nNacionalidad, maxCantFallos);
                            Console.Clear();
                            Console.Write("DESEA JUGAR DE NUEVO (S/N): ");
                            char opción = Char.ToUpper(Console.ReadKey().KeyChar);
                            if (opción != 'S')
                            {
                                control = false;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" ----------------------------------------------------------------------");
                        Console.WriteLine(" ----- LA CANTIDAD MÁXIMA DE FALLOS PARA NO PERDER EL JUEGO ES " + maxCantFallos + " -----");
                        Console.WriteLine(" ----------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.Write(" MODIFICAR (S/N): ");
                        char op = Char.ToUpper(Console.ReadKey().KeyChar);
                        if (op == 'S')
                        {
                            Console.Clear();
                            Console.Write("INGRESE NUEVO VALOR: ");
                            maxCantFallos = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine(" ----------------------------------------------------------------------");
                            Console.WriteLine(" ----------------- EL VALOR FUE MODIFICADO CON ÉXITO ------------------");
                            Console.WriteLine(" ----------------------------------------------------------------------");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" ----------------------------------------------------------------------");
                            Console.WriteLine(" ------------------- DICHO VALOR NO FUE MODIFICADO --------------------");
                            Console.WriteLine(" ----------------------------------------------------------------------");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        facade.Listar();
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



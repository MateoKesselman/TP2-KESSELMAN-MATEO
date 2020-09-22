using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    public class Facade
    {
       private RepositorioPartidas repositorioPartidas = new RepositorioPartidas();

       public void JugarPartida (string pNombre, int pEdad, string pNacionalidad, int pMaxCantFallos)
        {
            Jugador jugador = new Jugador(pNombre,pEdad,pNacionalidad);
            Partida partida = new Partida(jugador, pMaxCantFallos);
            partida.AsignarPalabraAleatoria();
            int cantLetrasPalabra = partida.Palabra.Length;
            int errores = 0;
            char[] charArrayPalabra = partida.Palabra.ToCharArray();
            char[] charArrayPantalla = new char[cantLetrasPalabra];
            char[] charArrayLetrasErroneas = new char[27];
            int cantLetrasErroneas = 0;
            bool acierto = false;


            for (int i = 0; i < cantLetrasPalabra; i++)
            {
                charArrayPantalla[i] = '_';
            }

            while ((errores < pMaxCantFallos) && (partida.Estado == false))
            {
                acierto = false;

                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ---------- CANTIDAD MÁXIMA DE FALLOS PARA NO PERDER EL JUEGO " + pMaxCantFallos + " ------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();
                Console.Write(" LETRAS ERRÓNEAS: ");

                for (int i = 0; i < cantLetrasErroneas; i++)
                {
                    Console.Write(charArrayLetrasErroneas[i] + " ");
                }

                Console.WriteLine(); Console.WriteLine();
                Console.Write(" ERRORES: ");
                Console.WriteLine(errores);Console.WriteLine(); Console.WriteLine();

                for (int i = 0; i < cantLetrasPalabra; i++)
                {
                    Console.Write(" ");
                    Console.Write(charArrayPantalla[i]);
                }

                Console.WriteLine(); Console.WriteLine();
                Console.Write(" INGRESE LETRA: ");
                char caracter = Char.ToUpper(Console.ReadKey().KeyChar);

                for (int i = 0; i < cantLetrasPalabra; i++)
                {

                    if (caracter == charArrayPalabra[i])
                    {
                        charArrayPantalla[i] = charArrayPalabra[i];
                        acierto = true;
                    }
                }

                if (acierto == false)
                {
                    errores++;
                    charArrayLetrasErroneas[cantLetrasErroneas] = caracter;
                    cantLetrasErroneas++;
                }

                partida.Estado = true;
                for (int i = 0; i < cantLetrasPalabra; i++)
                {
                    if (charArrayPantalla[i] == '_')
                    {
                        partida.Estado = false;
                    }
                }
            }

            if (partida.Estado == true)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ---------------------------- !!! GANASTE !!! -------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine(" LA PALABRA ERA '" + partida.Palabra + "'");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ---------------------------- !!! PERDISTE !!! ------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" LA PALABRA ERA '" + partida.Palabra + "'");
                Console.ReadKey();
            }
                repositorioPartidas.Agregar(partida);
        }

        public void Listar ()
        {
            int cant = repositorioPartidas.Cantidad;

            if (cant != 0)
            {

                for (int i = 0; i < cant; i++)
                {
                    Partida partida = repositorioPartidas.Obtener(i);
                    Console.WriteLine(" NOMBRE: " + partida.Jugador.Nombre);
                    Console.WriteLine(" EDAD: " + partida.Jugador.Edad);
                    Console.WriteLine(" NACIONALIDAD: " + partida.Jugador.Nacionalidad);
                    Console.WriteLine(" PALABRA DEL JUEGO: " + partida.Palabra);
                    Console.WriteLine(" CANTIDAD MÁXIMA DE ERRORES: " + partida.CantidadMaxFallos);
                    if (partida.Estado == true)
                    {
                        Console.WriteLine(" GANÓ LA PARTIDA");
                    }
                    else
                    {
                        Console.WriteLine(" PERDIÓ LA PARTIDA");
                    }
                    Console.WriteLine(" ----------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ---------------------------- NO HAY PARTIDAS -------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
            }
            Console.ReadKey();
        }

    }
}
//LLEVA SOLO LOS MÉTODOS QUE REPRESENTAN LAS OPERACIONES DEL SISTEMA
//DEBO INGRESAR SOLAMENTE LOS DATOS PRIMITIVOS COMO PARÁMETROS (QUE PROVIENEN DESDE LA INTERFAZ)
//DENTRO DEL MÉTODO DE FACHADA CREAR LOS OBJETOS QUE INTERACTÚEN ENTRE SI
//Y LUEGO DEVOLVER LA INFORMACIÓN

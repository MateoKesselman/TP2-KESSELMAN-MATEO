using System;
using System.Runtime.CompilerServices;

namespace EJ1
{
    class Interface
    {
        static void Main(string[] args)
        {
            int nNumero = 6;
            while (nNumero != 0)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ BIENVENIDO A FIGURAS GEOMÉTRICAS ------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ 1_DISTANCIA ENTRE DOS PUNTOS ----------------------");
                Console.WriteLine(" ------------------ 2_PERÍMETRO DE UN CÍRCULO -------------------------");
                Console.WriteLine(" ------------------ 3_PERÍMETRO DE UN TRIÁNGULO -----------------------");
                Console.WriteLine(" ------------------ 4_ÁREA DE UN CÍRCULO ------------------------------");
                Console.WriteLine(" ------------------ 5_ÁREA DE UN TRIÁNGULO ----------------------------");
                Console.WriteLine(" ------------------ 0_SALIR -------------------------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();

                Console.Write(" INTRODUZCA NÚMERO:");
                nNumero = int.Parse(Console.ReadLine());

                switch (nNumero)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("INGRESE COORDENADA X DEL PRIMER PUNTO");
                        double pX1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL PRIMER PUNTO");
                        double pY1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA X DEL SEGUNDO PUNTO");
                        double pX2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL SEGUNDO PUNTO");
                        double pY2 = Convert.ToDouble(Console.ReadLine());
                        var facade = new Facade();
                        double result = facade.ObtenerDistanciaEntreLosDosPuntos(pX1, pY1, pX2, pY2);
                        Console.Clear();
                        Console.WriteLine("LA DISTANCIA ENTRE LOS PUNTOS (" + pX1 + " , " + pY1 + ") Y (" + pX2 + " , " + pY2 + ") ES " + Math.Round(result, 2));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("INGRESE COORDENADA X DEL PUNTO CENTRO");
                        double pX = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL PUNTO CENTRO");
                        double pY = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE RADIO DEL CIRCULO");
                        double pRadio = Convert.ToDouble(Console.ReadLine());
                        var facade2 = new Facade();
                        double result2 = facade2.ObtenerPerimetroDelCirculo(pX, pY, pRadio);
                        Console.Clear();
                        Console.WriteLine("EL PERÍMETRO DEL CÍRCULO CUYO RADIO ES " + pRadio + " Y TIENE POR CENTRO EL PUNTO (" + pX + " , " + pY + ") ES " + Math.Round(result2, 2));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("INGRESE COORDENADA X DEL PRIMER PUNTO");
                        double pX1t = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL PRIMER PUNTO");
                        double pY1t = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA X DEL SEGUNDO PUNTO");
                        double pX2t = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL SEGUNDO PUNTO");
                        double pY2t = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA X DEL TERCER PUNTO");
                        double pX3t = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL TERCER PUNTO");
                        double pY3t = Convert.ToDouble(Console.ReadLine());
                        var facade3 = new Facade();
                        double result3 = facade3.ObtenerPerimetroDelTriangulo(pX1t, pY1t, pX2t, pY2t, pX3t, pY3t);
                        Console.Clear();
                        Console.WriteLine("EL PERÍMETRO DEL TRIÁNGULO CUYOS PUNTOS SON (" + pX1t + " , " + pY1t + ") (" + pX2t + " , " + pY2t + ") Y (" + pX3t + " , " + pY3t + ") ES " + Math.Round(result3, 2));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("INGRESE COORDENADA X DEL PUNTO CENTRO");
                        double pXc = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL PUNTO CENTRO");
                        double pYc = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE RADIO DEL CIRCULO");
                        double pRadioc = Convert.ToDouble(Console.ReadLine());
                        var facade4 = new Facade();
                        double result4 = facade4.ObtenerAreaDelCirculo(pXc, pYc, pRadioc);
                        Console.Clear();
                        Console.WriteLine("EL ÁREA DEL CÍRCULO CUYO RADIO ES " + pRadioc + " Y TIENE POR CENTRO EL PUNTO (" + pXc + " , " + pYc + ") ES " + Math.Round(result4, 2));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("INGRESE COORDENADA X DEL PRIMER PUNTO");
                        double pX1tt = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL PRIMER PUNTO");
                        double pY1tt = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA X DEL SEGUNDO PUNTO");
                        double pX2tt = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL SEGUNDO PUNTO");
                        double pY2tt = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA X DEL TERCER PUNTO");
                        double pX3tt = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL TERCER PUNTO");
                        double pY3tt = Convert.ToDouble(Console.ReadLine());
                        var facade5 = new Facade();
                        double result5 = facade5.ObtenerAreaDelTriangulo(pX1tt, pY1tt, pX2tt, pY2tt, pX3tt, pY3tt);
                        Console.Clear();
                        Console.WriteLine("EL ÁREA DEL TRIÁNGULO CUYOS PUNTOS SON (" + pX1tt + " , " + pY1tt + ") (" + pX2tt + " , " + pY2tt + ") Y (" + pX3tt + " , " + pY3tt + ") ES " + Math.Round(result5, 2));
                        Console.ReadKey();
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

//LA INTERFAZ GRÁFICA SOLO DEBE ENCARGARSE DE SU RESPONSABILIDAD
// ES DECIR DE ALGUNA MANERA CAPTURAR LOS DATOS DEL USUARIO
// VALIDARLOS DE ALGUNA MANERA, PASARSELOS A LA FACHADA
// Y DESPUÉS CON EL VALOR OBTENIDO DE LA FACHADA, DEVOLVER LA INFO
// Y PRESENTARLO DE UNA MANERA ADECUADA DE ACUERDO A LA INTERFAZ
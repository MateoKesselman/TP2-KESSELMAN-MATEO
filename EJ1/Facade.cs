using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    public class Facade
    {
       public double ObtenerDistanciaEntreLosDosPuntos (double pX1, double pY1, double pX2, double pY2)
        {
            var punto1 = new Punto(pX1,pY1);
            var punto2 = new Punto(pX2, pY2);
            return punto1.CalcularDistanciaDesde(punto2);
        }

        public double ObtenerPerimetroDelTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            var triangulo = new Triangulo(new Punto(pX1, pY1), new Punto(pX2, pY2), new Punto(pX3, pY3));
            return triangulo.Perimetro;
        }

        public double ObtenerAreaDelTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            var triangulo = new Triangulo(new Punto(pX1, pY1), new Punto(pX2, pY2), new Punto(pX3, pY3));
            return triangulo.Area;
        }

        public double ObtenerPerimetroDelCirculo(double pX, double pY, double pRadio)
        {
            var circulo = new Circulo(pX,pY,pRadio);
            return circulo.Perimetro;
        }

        public double ObtenerAreaDelCirculo(double pX, double pY, double pRadio)
        {
            var circulo = new Circulo(pX, pY, pRadio);
            return circulo.Area;
        }

    }
}
//LLEVA SOLO LOS MÉTODOS QUE REPRESENTAN LAS OPERACIONES DEL SISTEMA
//DEBO INGRESAR SOLAMENTE LOS DATOS PRIMITIVOS COMO PARÁMETROS (QUE PROVIENEN DESDE LA INTERFAZ)
//DENTRO DEL MÉTODO DE FACHADA CREAR LOS OBJETOS QUE INTERACTÚEN ENTRE SI
//Y LUEGO DEVOLVER LA INFORMACIÓN
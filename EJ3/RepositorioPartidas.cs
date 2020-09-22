using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    public class RepositorioPartidas
    {
        Partida[] arrayPartidas = new Partida[100];

        private int cantidad = 0;
        private int capacidad = 100;

        public void Agregar(Partida pPartida)
        {
            if (cantidad < capacidad)
            {
                arrayPartidas[cantidad] = pPartida;
                cantidad++;
            }
        }

        public Partida Obtener(int pPosicion)
        { 
         return arrayPartidas[pPosicion];
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

    }
}

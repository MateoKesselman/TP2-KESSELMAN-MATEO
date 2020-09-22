using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace EJ3
{
    public class Partida
    {
        private Jugador iJugador;
        private string iPalabra;
        private int iCantidadMaxFallos;
         // private Timer iFechaYHoraInicio;
         // private Timer iFechaYHoraFin;
         // private Timer iDuracion;
        private bool iEstado;

        public Partida(Jugador pJugador, int pCantidadMaxFallos)
        {
            this.iJugador = pJugador;
            this.iPalabra = "";
            this.iCantidadMaxFallos = pCantidadMaxFallos;
        //  this.iFechaYHoraInicio = pFechaYHoraInicio;
        //  this.iFechaYHoraFin = pFechaYHoraFin;
        //  this.iDuracion = 0;
            this.iEstado = false;
        }

        public Jugador Jugador
        {
            get { return this.iJugador; }
            set { this.iJugador = value; }
        }

        public string Palabra
        {
            get { return this.iPalabra; }
            set { this.iPalabra = value; }
        }

        public bool Estado
        {
            get { return this.iEstado; }
            set { this.iEstado = value; }
        }

        public int CantidadMaxFallos
        {
            get { return this.iCantidadMaxFallos; }
            set { this.iCantidadMaxFallos = value; }
        }

        string[] arrayPalabras = new string[30];

        public void InicializarArregloPalabras()
        {
            arrayPalabras[0] = "ACTITUD";
            arrayPalabras[1] = "OPORTUNIDAD";
            arrayPalabras[2] = "RELACION";
            arrayPalabras[3] = "AHORCADO";
            arrayPalabras[4] = "EFICACIA";
            arrayPalabras[5] = "SOBRESALIENTE";
            arrayPalabras[6] = "CELULAR";
            arrayPalabras[7] = "EXTRAORDINARIO";
            arrayPalabras[8] = "EXCELENTE";
            arrayPalabras[9] = "FELICIDAD";
            arrayPalabras[10] = "RINOCERONTE";
            arrayPalabras[11] = "TIBURON";
            arrayPalabras[12] = "BALLENA";
            arrayPalabras[13] = "IMAGINACION";
            arrayPalabras[14] = "BIBLIOGRAFIA";
            arrayPalabras[15] = "ELECTRICIDAD";
            arrayPalabras[16] = "AMARGO";
            arrayPalabras[17] = "LAPTOP";
            arrayPalabras[18] = "MANDARINA";
            arrayPalabras[19] = "CHOCOLATE";
            arrayPalabras[20] = "POCHOCLO";
            arrayPalabras[21] = "COMPUTADORA";
            arrayPalabras[22] = "MARATON";
            arrayPalabras[23] = "INGENIERIA";
            arrayPalabras[24] = "MEDICINA";
            arrayPalabras[25] = "COLORADO";
            arrayPalabras[26] = "VIOLETA";
            arrayPalabras[27] = "ARGENTINA";
            arrayPalabras[28] = "AMERICA";
            arrayPalabras[29] = "MEXICO";
        }

        public void AsignarPalabraAleatoria()
        {
            Random aleatorio = new Random();
            this.InicializarArregloPalabras();
            this.iPalabra = arrayPalabras[aleatorio.Next(0, 29) + 1];
        }


    }
}


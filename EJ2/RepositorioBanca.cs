﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{
    public class RepositorioBanca
    {
        Banca[] array = new Banca[30];

        int capacidad = 30;
        int cantidad = 0;

        public Banca Obtener(string pNumero)
        {
            Banca Result = null;

            for (int i = 0; i < cantidad; i++)
            {
                if (array[i].Numero == pNumero)
                {
                    Result = array[i];
                }
            }
            return Result;
        }

        public void Agregar(Banca pBanca)
        {
            if (cantidad < capacidad)
            {
                array[cantidad] = pBanca;
                cantidad++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("NO ES POSIBLE AÑADIR MÁS CUENTAS");
                Console.ReadKey();
            }

        }
    }
}
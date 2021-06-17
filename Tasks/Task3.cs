﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    public class Task3
    {
        /*
         * Dada a lista de inteiros, retorne o somatório de todos os itens com valor POSITIVO da lista     
         * LEMBRANDO que 0 (zero) NÃO é um número positivo
         */
        public static int GetSum(List<int> list)
        {
            int result = 0;
            foreach (int item in list)
            {
                if (item <= 0)
                    Console.WriteLine("Só é permitido números maiores do que zero");
                result = list.Sum();
            }
            return result;
        }
    }
}

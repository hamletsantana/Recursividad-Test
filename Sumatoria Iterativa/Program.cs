﻿using System;

namespace Sumatoria_Iterativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumatoria Iterativa");
            Console.Write ("Inserte un número para buscar la sumatoria: ");
            int numero = int.Parse(Console.ReadLine());
            
            int sumatoria = Sumatoria(numero);

            Console.WriteLine(sumatoria);
        }

        static int Sumatoria(int num)
        {
            int sumatoria = 0;
            for (int i = 0; i <= num; i++)
            {
                sumatoria += i;
            }

            return sumatoria;
            
        }
    }
}

using System;

namespace Sumatoria_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumatoria usando recursion");
            Console.Write ("Inserte un número para buscar la sumatoria: ");
            int numero = int.Parse(Console.ReadLine());
            int sumatoria = Sumatoria(numero);
            Console.WriteLine(sumatoria);
        }

        static int Sumatoria(int num)
        {

            if (num == 1)
            {
                return num;
            }
            else 
            {
                return num + Sumatoria(num-1);
            }

        }
    }
}

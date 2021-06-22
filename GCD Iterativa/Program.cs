using System;

namespace GCD_Iterativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número: ");
            int numero = int.Parse(Console.ReadLine());
        }

        static int Par(int num)
        {
            if (num & 1 )
            {
                Console.WriteLine("Es par");
            }
            else 
            {
                Console.WriteLine ("Es impar");
            }
        }
    }
}

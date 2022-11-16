using System;

namespace Ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*25. Fer un programa que sumi les xifres que té un número enter*/

            long num, i = 1, cont = 0, acumulador= 0, suma =0;

            Console.WriteLine("cifra: ");
            num = long.Parse(Console.ReadLine());

            while (num != 0)
            {
                acumulador = num % 10;
                num = num / 10;

                suma += acumulador;
                

                
                
                
            }

            Console.WriteLine(suma);
        }
    }
}
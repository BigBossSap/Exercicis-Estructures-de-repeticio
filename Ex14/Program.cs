using System;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14. Fer un programa que demani un número N i calculi la suma del 1 al N. Per
   exemple si donem el 4 ha de calcular 1+2+3+4=10
   */

            int n;
            int calcul, calcul2;
            int i = 1;
            do
            {
                Console.WriteLine("n: ");
                n = Convert.ToInt32(Console.ReadLine());

                calcul = n / i;
                calcul2 = calcul + (calcul*i);
                Console.WriteLine($"{calcul2}");
                i++;

            }

            while (i > n);


        }
    }
}

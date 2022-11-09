using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*15. Fer un programa que demani un número N i calculi el producte del 1 al N. Per
 exemple si donem el 4 ha de calcular 1*2*3*4=24
 */


            int n;
            int i=1;
            int factorial = 1;

            Console.WriteLine("numero:");
            n = Convert.ToInt32(Console.ReadLine());

            while (i<=n)
            {
                factorial = factorial * i;
                i++;
                
            }


            Console.WriteLine(i);
        }
    }
}

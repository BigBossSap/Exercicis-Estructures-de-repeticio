using System;

namespace Ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 17. Fer un programa que compti els divisors d’un número. Per exemple si donem el
   12 ha d’escriure: 6
   */

            int i;
            int divisors=0;
            int num;

            Console.WriteLine("num");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i<99; i++)
                if (num % i == 0)
                    divisors++;
            Console.WriteLine(divisors);
        }
    }
}

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




            int num, cont = 0, i = 1;


            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= num)
            {
                if (num % i == 0)
                    cont++;

                i++;
            }
            Console.WriteLine(cont);

        }
    }
}
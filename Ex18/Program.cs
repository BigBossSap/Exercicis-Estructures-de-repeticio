using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*18. Fer un programa que digui si un número és primer. Són primers els que tenen
    només dos divisors, el 1 i ell mateix.
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

            if (cont ==2)
                Console.WriteLine("si");
            else
                Console.WriteLine("no");












        }
    }
}

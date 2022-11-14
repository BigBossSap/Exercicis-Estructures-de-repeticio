using System;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*21.Dir si un número és perfecte.Ho son els que la suma dels divisors excepte ell mateix
 coincideix amb el número.Per exemple 6 = 1 + 2 + 3 */

            int num1, sumadivisors = 0, i= 1;

            Console.WriteLine("num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
           
            while (i<=num1/2)
            {
                if (num1 % i == 0)
                    sumadivisors += i;
                i++;
                
            }

            if (sumadivisors==num1)
                Console.WriteLine("Es perfecte");
            else
                Console.WriteLine("No es perfecte");





        }
    }
}

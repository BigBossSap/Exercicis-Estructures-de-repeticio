using System;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*21.Dir si un número és perfecte.Ho son els que la suma dels divisors excepte ell mateix
 coincideix amb el número.Per exemple 6 = 1 + 2 + 3 */

            int divisors=0, i = 1, num;

            Console.WriteLine("num:");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= num/2)
            {
                if (num % i == 0)
                {

                    divisors = divisors + i;

                }

                i++;
            }

                if (divisors == num)
                    Console.WriteLine("SI");
                else
                    Console.WriteLine("NO");

            


           
           
        }
    }
}

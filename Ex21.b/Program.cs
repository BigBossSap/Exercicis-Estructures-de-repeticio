using System;

namespace Ex21.b
{
    class Program
    {
        static void Main(string[] args)
        {
            /*21.Dir si un número és perfecte.Ho son els que la suma dels divisors excepte ell mateix
 coincideix amb el número.Per exemple 6 = 1 + 2 + 3 */

            int num1=1, sumadivisors = 0, i = 1, j=0;

            while (j < 5)
            {

                while (i <= num1 / 2)
                {
                    if (num1 % i == 0)
                        sumadivisors += i;
                    i++;

                }

                if (sumadivisors == num1)
                {
                    Console.WriteLine(num1);
                    j++;
                }
                num1++;
                

            }



        }
    }
}

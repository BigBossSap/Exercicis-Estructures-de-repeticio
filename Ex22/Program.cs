using System;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {

            /*22. Calcular l’arrel entera de un número. arrel (30) = 5
*/

            int i = 1;
            int divisors = 0;
            int num;

            Console.WriteLine("num");
            num = Convert.ToInt32(Console.ReadLine());


            while (num % i == 0)
            {
                divisors++;
                
                Console.WriteLine(divisors);
                i++;
            }
            
        }
    }
}

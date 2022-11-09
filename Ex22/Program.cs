using System;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {
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

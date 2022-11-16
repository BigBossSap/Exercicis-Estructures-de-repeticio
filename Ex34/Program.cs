using System;

namespace Ex34
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Fer un programa un número N i escrigui els seus factors primers*/

            int n, i=2;
            

            Console.WriteLine("num: ");
            n = int.Parse(Console.ReadLine());

            while (n > 1)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    n = n / i;
                }
                else
                    i++;


               

                





            }
        }
    }
}

using System;

namespace Ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*24. Fer un programa que compti quantes xifres té un número enter*/

            long num; 
            long i = 1, cont =0;

            Console.WriteLine("cifra: ");
            num = long.Parse(Console.ReadLine());

            while (num/i*10!=0)
            {
                num = num / 10;
                
                cont++;
                i = i * 10;
            }

            Console.WriteLine(cont);
        }
    }
}

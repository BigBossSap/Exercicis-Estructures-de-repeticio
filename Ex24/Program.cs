using System;

namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 25. Fer un programa que sumi les xifres que té un número enter*/

            int i = 0;
            int cont = 0;
            int num;
            int suma =0;

            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                num = num / 10;
                
                cont++;
            }

            Console.WriteLine(suma);


        }
    }
}

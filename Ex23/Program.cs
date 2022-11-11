using System;

namespace Ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*24. Fer un programa que compti quantes xifres té un número enter*/

            int i = 0;
            int cont = 0;
            int num;

            Console.WriteLine("num: ");
            num= Convert.ToInt32(Console.ReadLine());

            while (num >0)
            {
                num = num / 10;
                
               cont++; 
            }

            Console.WriteLine(cont);
        }
    }
}

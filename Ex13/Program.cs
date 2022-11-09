using System;
using System.Net;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13.Calcula la divisió entera a base de restes. 20 / 3 = 6 * 3 + 2.Quocient 3 i sobren 2,
doncs puc restar 6 vegades el 3*/

            int i = 1;
            int num1, num2 = 0;
            int resultat = 0;
            int suma = 0;
            int divisio;

            Console.WriteLine("num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            do
            {


                divisio = num1 / num2;
                resultat = num1 - (divisio*num2);
                i++;
                divisio = resultat;
                Console.WriteLine($"{resultat} - ({num1})");


            }
            while (i < divisio);

        }
    }
}

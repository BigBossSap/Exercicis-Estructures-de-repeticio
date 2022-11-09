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

            int divisio = 0;
            int numerador, denominador;
            int resto;
           
           

            Console.WriteLine("num1: ");
            numerador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2: ");
            denominador = Convert.ToInt32(Console.ReadLine());

            
            resto = numerador;

            while (resto >= denominador) {

                divisio++;
                resto = resto - denominador;
                
                
            }

            Console.WriteLine($"El resultat de dividir {numerador} entre {denominador} es {divisio} y resta {resto}");







        }
    }
}

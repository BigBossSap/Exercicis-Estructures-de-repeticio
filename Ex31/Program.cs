using System;
using System.Diagnostics.CodeAnalysis;

namespace Ex31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*31. Fer un programa que escrigui els 20 primers termes de la successió de
   Fibonacci. La successió és 1, 1, 2, 3, 5, 8, 13, 21, 34, ...La Sucesión o Algoritmo de Fibonacci se 
   caracteriza por el hecho de que cada número en ella es igual a la suma de los anteriores:

   0, 1, 1, 2, 3, 5, 8, 13, 21….. */

            int i = 1, seguent, primer=-1, segon=1;

            for (i = 0; i <= 20; i++)
            {
                
                    seguent = primer + segon;
                    primer = segon;
                    segon= seguent;
                

                Console.WriteLine(seguent);



            }

            



        }
    }
}

﻿using System;

namespace Ex28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*28. Fer un programa que digui si un número és apilable: Ho són el 0, 1, 3, 6, 10, 15,
   21, ...
   */
            int i = 0,num, suma=0;
            Console.WriteLine("num:");
            num = int.Parse(Console.ReadLine());


           while (i <= num)
            {

                suma += i;
                i++;

                if (suma == num)
                    Console.WriteLine("SI");           
                else
                    Console.WriteLine( "no");

            }

            
            

            

        }
    }
}

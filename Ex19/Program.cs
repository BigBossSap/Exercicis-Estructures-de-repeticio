﻿using System;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 19. Fer un programa que calculi el màxim comú divisor de dos números. El màxim
   comú divisor és el divisor de tots dos més gran que hi hagi. Si no trobem cap
   divisor, el 1 sempre ho serè.*/

            int i, num1, num2;

            Console.WriteLine("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (i = 1; num1 % i == 0 && num2 % i == 0; i++);
            {


                
            }



        }
    }
}
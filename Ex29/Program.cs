using System;

namespace Ex29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*28. Fer un programa que digui si un número és apilable: Ho són el 0, 1, 3, 6, 10, 15,
   21, ...
   */
            int i = 0, num, suma = 0, j = 1, aplicable = 0;
           


            while (j <= 1000)
            {

                while (i <= j)
                {

                    suma += i;
                    i++;

                    if (suma == j)
                    {
                        
                        aplicable += suma;
                        Console.WriteLine(aplicable);

                    }

                    

                }
                j++;
                


            }
        }


    }
}   
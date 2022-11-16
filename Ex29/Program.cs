using System;

namespace Ex29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*29. Fer un programa que escrigui els apilables entre 1 i 1000

   */
            int i = 0, suma = 0, j = 1, aplicable = 0;
           


            while (j <= 1000)
            {

                while (i <= j)
                {

                    suma += i;
                    i++;
                    

                    if (suma == i)
                    {
                        
                        aplicable += suma;
                        Console.WriteLine(i);

                    }

                    

                }
                
                


            }
        }


    }
}   
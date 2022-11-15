using System;
using System.Security.Cryptography;

namespace Ex27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 27. Fer un programa que llanci 1000000 de monedes (s’inventi 0 o 1) i digui quin %
  de cares i creus ha tret.
  */

            double tirada = 1, cara = 0, creu = 0;

            while (tirada<1000000)
            {
                
               Random random = new Random();
                int resultado = random.Next(0, 2);
                tirada++;
              

                if (resultado ==1)
            
                    cara++;


                
                else if (resultado==0)
                    creu++;

                

                
            }

            Console.WriteLine($"cara: {cara}, creu {creu}");

            double percentCara = (cara / 1000000) * 100;
            double percentCreu = (creu / 1000000) * 100;

            Console.WriteLine($"cara: {Math.Round(percentCara,2)}, creu {Math.Round(percentCreu,2)}");


        }
    }
}

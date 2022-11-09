using System;
using System.Data;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10.Demanar 10 números per teclat i que els sumi */

            int i = 0;
            int num;
            int acumulador = 0;
            


            do
            {

                Console.WriteLine("Numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                acumulador = num + acumulador;
                Console.WriteLine($"Suma actual: {acumulador} ({i})");

                i++;
                
                

            }
            while (i < 10);






            }




        }
    }


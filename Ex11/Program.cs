using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11. Demanar 10 enters i dir quants eren positius, quants negatius i quantes vegades
                 hi havia el zero */

            int i = 0;
            int num;
            int negativos=0, positivos=0, zero=0;

            while (i < 10)
            {
                i++;
                Console.WriteLine("Numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                    negativos++;
                else if (num > 0)
                    positivos++;
                else if (num == 0)
                    zero++;
            }

            Console.WriteLine($"{negativos} negativos, {positivos} positivos y {zero} ceros." );

            
            
            }
        }
    }


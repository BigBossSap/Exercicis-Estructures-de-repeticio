using System;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 12. Demanar 2 números i calcular el producte a base se sumes. Per exemple 5*3=5 + 5 + 5 */

            /* int i = 1;
             int producte = 0;

             int num1, num2, suma;*/

            /*do
            {
                Console.WriteLine("num1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("num2: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                producte = num2 * (num1 / num2);
                suma = num1*producte);
                Console.WriteLine($"El producto calculado a partir de sumas de {num1} * {num2} es {num2} + {num2} + {num2} y es igual a: {suma}");
                i++;


            }

            while (i <= num2);
            */

            int i = 1;
            int num1, num2;         
            int suma = 0;

            Console.WriteLine("num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num2>num1)
            {
                int aux = num2;
                num2 = num1;
                num1 = aux;
            }
            
            do
            {

                

                suma = num1 + suma;
                i++;
                Console.Write($"{num1} +");
                
               
                
            }
            while (i <= num2);


            Console.WriteLine($"{suma}"); //num1 es per saber la linea






        }



           


        }
    }


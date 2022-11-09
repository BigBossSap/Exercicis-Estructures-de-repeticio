using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*16. Fer un programa que demani un número N i escrigui els seus divisors. Per
 exemple si donem el 12 ha d’escriure: 1 2 3 4 6 12
 */

            int i, num;
            int contador=0;

            Console.WriteLine("num: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i=0; num<=num; i++)
            {
                
                
                if (num%2==0)
                {
                    Console.WriteLine(i);
                    contador++;
                }
                
                
                Console.WriteLine(i);


            }

        }
    }
}

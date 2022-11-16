using System;

namespace Ex35.b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Demanar un número i mostrar-lo en binari
   */

            int num, resto, mult=1;
            int binari = 0;

            Console.Write("num: ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {

                resto = num % 2;
                num = num / 2;
                binari = resto + binari * mult;
                mult *= 10;





            }

            Console.WriteLine(binari);



        }
    }
}

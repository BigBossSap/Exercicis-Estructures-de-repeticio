using System;

namespace Ex35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Demanar un número i mostrar-lo en binari
   */

            int num, resto,divisio=0;
            string binari = "";

            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());

            while (num!=1)
            {

                resto = num % 2;
                divisio = num / 2;

                num = divisio;

                binari = resto + binari; 
                
                
                
                

            }

            binari = divisio + binari;
            Console.WriteLine(binari);


        }
    }
}

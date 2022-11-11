using System;

namespace Ex22
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 22. Calcular l’arrel entera de un número. arrel (30) = 5  8 elevat a 2 + num
*/

            int i = 1;

            int arrel, arrelC;
            int num;

            Console.WriteLine("num");
            num = Convert.ToInt32(Console.ReadLine());


            while (i <= num)
            {
                arrel = num / num;
                arrelC = arrel + num;
                Console.WriteLine(arrelC);
                i++;
            }






        }
    }
}        
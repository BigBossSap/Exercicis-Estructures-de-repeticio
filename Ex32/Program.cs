using System;

namespace Ex32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*32. Fer un programa que demani un número N i escrigui l’Nèssim terme de la
    successió*/

            int i = 1, j = 0, seguent, primer = 0, segon = 1, n;
            Console.WriteLine("n: ");
            n=int.Parse(Console.ReadLine());




            for (i = 0; i <= 20; i++)
            {
 
                
                seguent = primer + segon;
                primer = segon;
                segon = seguent;

                if (i==n)

                Console.WriteLine(primer);



            }

        }
    }
}

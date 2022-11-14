using System;

namespace Ex02EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, termes, i = 1, potencia=1, fractan=1;

            Console.WriteLine("x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("termes: ");
            termes = Convert.ToDouble(Console.ReadLine());


            while (i<=termes)
            {
                fractan = (double)Math.Pow(x, i) / i + 1;
                i++;
                fractan = fractan + (double)Math.Pow(x, i) / i + 1;
                i++;
                fractan = fractan - (double)Math.Pow(x, i) / i + 1;





            }

            Console.WriteLine(fractan);





        



        }
    }
}

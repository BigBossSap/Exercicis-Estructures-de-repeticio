using System;

namespace Ex02EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {

            /*2.- Fer un mètode en C# que calculi l’arctangent d’un angle X entre -1 i 1 a partir de la sèrie de Taylor:
 
Ens ha de demanar el nombre de termes a sumar i la X. No cal controlar que l’angle estigui entre -1  i 1.
*/
            //x=1 entre -1, temres vegades;
            double x, termes, i = 0, fractan = 0, simbol = 1, exponent =1;
            

            Console.WriteLine("x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("termes: ");
            termes = Convert.ToDouble(Console.ReadLine());


            while (i<=termes)
            {
                

                fractan = simbol * Math.Pow(x, exponent) / exponent;
                i++;
                exponent += 2;
                simbol *= -1;
                fractan += fractan;
                





            }

            Console.WriteLine(fractan);





        



        }
    }
}

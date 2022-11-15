using System;

namespace Ex33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*33. Fer un programa que calculi el MCD per l’algorisme d’Euclides.
 a. Euclides diu que si un número és múltiple de l’altre, el petit és el MCD:
 De 24 i 6 el MCD és 6
 b. Euclides diu que si no són múltiple un de l’altre, el MCD que hem de
 buscar és el del petit i el residu de la divisió entera entre tots dos: De
 40 i 24 el MCD que hem de buscar és el de 24 i 16
 */


            int  mcd, residu = 0, num1,num2,a,b;

            Console.WriteLine("num1: ");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("num2: ");
            num2 = int.Parse(Console.ReadLine());

            a = Math.Max(num1, num2);
            b = Math.Min(num1, num2);

            while (b!=0)
            {
                residu = a % b;
                
                a = b;
                b = residu;

                



            }

            
            Console.WriteLine(a);

            





        }
    }
}

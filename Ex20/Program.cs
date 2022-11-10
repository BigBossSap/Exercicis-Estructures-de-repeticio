using System;

namespace Ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*20. Fer un programa que calculi el mínim comú múltiple de dos números. El mínim
   comú múltiple és el múltiple de tots dos més petit que hi hagi. com a molt, el
   producte de tots dos ho serè.
   */

            int num1, num2, residu, a, b, mcm;



            Console.WriteLine("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            a = Math.Max(num1, num2);
            b = Math.Min(num1, num2);

            do
            {
                residu = a % b;  // Ex. residu de 56(a)/15(b)=11(residu), pasem b(15)  a la a(56) que desapareix, i pasem el residu(11) a la b,
                                 // tornem repetir la operacio fins que el residu sigui 0 que pasara a la b, i la a sera el nostre mcd.   

                a = b;
                b = residu;

            } while (b != 0);

            int mcd = a;

            mcm = (a * b) / mcd;



            Console.WriteLine(mcm);









        }
    }
}

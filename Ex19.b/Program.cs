using System;

namespace Ex19.b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, residu,a, b;

           

            Console.WriteLine("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            a = Math.Max(num1, num2);
            b=  Math.Min(num1, num2);

            do
            {
                residu = a % b;  // Ex. residu de 56(a)/15(b)=11(residu), pasem b(15)  a la a(56) que desapareix, i pasem el residu(11) a la b,
                                 // tornem repetir la operacio fins que el residu sigui 0 que pasara a la b, i la a sera el nostre mcd.   

                a = b;
                b = residu;

            } while (b != 0);

            int mcm = a;

            Console.WriteLine(a);

        }
    }
}

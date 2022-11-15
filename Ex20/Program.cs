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

            int i = 1, num1, num2, mcd = 0, mcm=0;

            Console.WriteLine("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (i <= num1 && i <= num2)


            {
                if (num1 % i == 0 && num2 % i == 0) {

                    mcd = i;
                    mcm = (num1 * num2 / mcd);
                        }




                i++;

            }

            Console.WriteLine(mcm);



















        }
    }
}

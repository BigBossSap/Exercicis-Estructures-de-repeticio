using System;

namespace Ex20.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num1, num2, mcm=0;

            Console.WriteLine("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            i = num1 * num2;


         

            while (i >= num1 && i >= num2)
            {
                if (i % num1 == 0 && i % num2 == 0)
                    mcm = i;
                i--;
            }

            Console.WriteLine(mcm);

        }
    }
}

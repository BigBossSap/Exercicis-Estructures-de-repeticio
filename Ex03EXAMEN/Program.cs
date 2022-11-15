using System;

namespace Ex03EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int bits, i = 0, uns=0, zeros=0;

            do
            {
                Console.WriteLine("Bits: ");
                bits = Convert.ToInt32(Console.ReadLine());
                i++;

                if (bits == 0)

                    zeros++;

                else if (bits == 1)

                    uns++;

               


            } while (i < 7);

            if (zeros > uns)
                Console.WriteLine(1);
            else

                Console.WriteLine(0);



        }
    }
}

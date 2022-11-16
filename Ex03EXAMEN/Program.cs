using System;

namespace Ex03EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int bits, i = 0, uns=0, zeros=0, cifra=0;
            Console.WriteLine("Bits: ");
            bits = Convert.ToInt32(Console.ReadLine());

            do
            {
                

                cifra = bits % 10;
                bits = bits / 10;
                i++;


                if (cifra == 0)

                    zeros++;

                else if (cifra == 1)

                    uns++;
             
               


            } while (i < 7);

            if (uns%2!=0)
                Console.WriteLine(1);
            else

                Console.WriteLine(0);



        }
    }
}

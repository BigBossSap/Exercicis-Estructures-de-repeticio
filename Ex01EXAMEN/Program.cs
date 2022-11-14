using System;

namespace Ex01EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {
         
        int num, i=0, menor=0, major=0, segonMajor=0, segonMenor=0;



            Console.WriteLine("num:" );
            num = Convert.ToInt32(Console.ReadLine());

            major = num;
            menor = num;

            while (num!=0)
            {
                if (num > major)
                {
                    segonMajor = major;
                    major = num;
                }

                else if (num > segonMajor && num< major)
                    segonMajor = num;

                if (num < menor)
                {
                    segonMenor = menor;
                    menor = num;
                }

                else if (num < segonMenor && num>menor)
                    segonMenor = num;


                Console.WriteLine("num:");
                num = Convert.ToInt32(Console.ReadLine());

                
            }

            Console.WriteLine (segonMenor);
            Console.WriteLine(segonMajor);



        }
    }
}

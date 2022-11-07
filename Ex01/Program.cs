using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Programa que validi una nota (0..10) amb while. Que demani una nota, i si no
   està entre 0 i 10 que la torni a demanar, i si no està ....
   */
            double nota;
            nota = Convert.ToDouble(Console.ReadLine());
            while (nota < 0 || nota > 10)
            {

                Console.WriteLine("Nota incorrecta!");
                nota = Convert.ToDouble(Console.ReadLine());
            }
            

            Console.WriteLine("Nota aceptada!");




        }
    }
}

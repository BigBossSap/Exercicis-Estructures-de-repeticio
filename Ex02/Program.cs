using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Programa que validi una nota(0..10) amb dowhile*/

            double nota;

            do
            {

                Console.WriteLine("Escribe una nota: ");
                nota = Convert.ToDouble(Console.ReadLine());

            }

            while (nota < 0 || nota > 10);
            


            Console.WriteLine("Nota aceptada!");


        }
    }
}

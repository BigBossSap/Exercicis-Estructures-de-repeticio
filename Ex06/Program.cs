using System;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Que ens demani quantes vegades volem escriure hola, i que ho faci
   */
            int num;
            int i = 0;

            Console.WriteLine("¿Cuantas veces quieres escribir 'hola'?");
            num = Convert.ToInt32(Console.ReadLine());

            while (i<num) {

                Console.WriteLine($"Hola! ({i})" );
                i++;
            }

        }
    }
}

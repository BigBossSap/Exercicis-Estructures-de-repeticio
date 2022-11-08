using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Programa que validi una resposta s/n amb while. Que demani una resposta s ó n,
i si no és s ó n que la torni a demanar, i si no està ....*/

            char lletra;

            Console.WriteLine(" Escriu s o n: ");
            lletra = Console.ReadKey().KeyChar;
            while (lletra != 's' && lletra != 'n') 

            {
                Console.WriteLine(" Escriu s o n: ");
                lletra = Console.ReadKey().KeyChar;
            }

            
        }
    }
}

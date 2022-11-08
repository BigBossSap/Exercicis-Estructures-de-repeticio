using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3.4. Programa que validi una resposta s/n amb dowhile
*/

            char lletra;
            do
            {
                Console.WriteLine(" Escriu s o n: ");
                lletra = Console.ReadKey().KeyChar;
            }

            while (lletra != 's' && lletra != 'n');
        }
    }
}

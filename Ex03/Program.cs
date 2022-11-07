using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            char lletra;
            do
            {
                Console.WriteLine("Escriu s o n");
                lletra = Console.ReadKey().KeyChar;
            }

            while (lletra == 's');
        }
    }
}

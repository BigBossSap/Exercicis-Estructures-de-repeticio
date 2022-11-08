using System;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*8. Escriure els 20 primers números parells (2, 4, 6, 8, ..., 40)
*/

            int i = 2;

            while (i < 42)
            {
                Console.WriteLine($"{i}");
                i=i+2;
            }
        }
    }
}

using System;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9. Escriure els 20 primers quadrats perfectes (0, 1, 4, 9, 16, ...)
 */

            int i = 0;
            int cuadradoPerfecto;

            while (i < 21)
            {
                cuadradoPerfecto = i * i;
                Console.WriteLine($"{cuadradoPerfecto} ({i})");
                i++;
            }
        }
    }
}

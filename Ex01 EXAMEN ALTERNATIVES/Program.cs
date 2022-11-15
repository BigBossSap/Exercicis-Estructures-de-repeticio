using System;

namespace Ex01_EXAMEN_ALTERNATIVES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data1, data2, any1, any2;

            Console.WriteLine("data: ");
            data1 = int.Parse(Console.ReadLine());
            Console.WriteLine("data2: ");
            data2 = int.Parse(Console.ReadLine());

            any1 = data1 % 10000;
            any2 = data2 % 10000;

            if (any1<any2)
                Console.WriteLine($"La primera persona, del {any1}, te mes edat");
            else
                Console.WriteLine($"La segona persona, del {any2}, te mes edat");

        }
    }
}

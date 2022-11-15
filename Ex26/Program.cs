using System;

namespace Ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*26. Fer un programa que miri si un número enter qualsevol és capicua*/

            int i = 0, num, aux, digit;
            string numeroReves = "";

            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());
            aux = num;
            while (num !=0)
            {

                // La facil es agafar numero fer bucle girarlo i compararlo amb ell mateix! fer servir string i concatenar( string num:""; )
                
                
                digit = num % 10;
                num /= 10;
                numeroReves = numeroReves + digit;


            }

            Console.WriteLine(numeroReves);
        
            if (aux==Convert.ToInt32(numeroReves))
                Console.WriteLine("Cap i Cua");
            else
                Console.WriteLine("no es Cap i Cua");

        }
    }
}

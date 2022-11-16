using System;

namespace Ex26.c
{
    class Program
    {
        static void Main(string[] args)
        {
            /*26. Fer un programa que miri si un número enter qualsevol és capicua, sense string*/

            int i = 0, num, aux, digit, numeroReves = 0, xifres=0, numComp=0, numComp2=0;


            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());
            aux = num;
            int aux2 = num;
            
            while (num!=0)
            {
                
                num = num / 10;
                xifres++;

            }
            Console.WriteLine(xifres);

            while (i<=xifres)
            {
                numComp=aux2 % 10;

                aux2 = aux2 / 10 * i;


                i++;
                Console.WriteLine(numComp);
                Console.WriteLine(aux2 );
                
            }
            
            
            
            
            
            /*while (num != 0)
            {

                // La facil es agafar numero fer bucle girarlo i compararlo amb ell mateix! fer servir string i concatenar( string num:""; )
               

                digit = num % 10;
                num /= 10;
                
                if(digit=)



            }

            Console.WriteLine(numeroReves);

            if (aux == Convert.ToInt32(numeroReves))
                Console.WriteLine("Cap i Cua");
            else
                Console.WriteLine("no es Cap i Cua");*/

        }
    }
}

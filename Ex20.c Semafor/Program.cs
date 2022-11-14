using System;

namespace Ex20.c_Semafor
{
    class Program
    {
        static void Main(string[] args)
        {

            bool semafor = true;
            int i, num1, num2, aux; 

            Console.WriteLine("num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2) {
                aux = num2;
                num1 = num2;
                num2 = aux;
            }
            int mcm = num1 * num2;
            i = num2;

            while (semafor){
            
                if ( i%num1==0 && i%num2==0)
                {
                    mcm = i;
                    semafor = false;
                }

                i = i + num2;

              

            }

            Console.WriteLine(mcm);






        }
    }
}

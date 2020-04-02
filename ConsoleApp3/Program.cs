using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ht; int ph;
            int he; int pt = 0;
            int het;int phe;
            Console.WriteLine(" dijite dos numeros ");
            Console.WriteLine(" dijite el primer numero ");
            ht = Convert.ToInt32(Console.ReadLine( ));
            Console.WriteLine(" dijite el segundo numero ");
            ph = Convert.ToInt32(Console.ReadLine());          

            if (ht > 40)
            {
                he = ht - 40;
                if (he > 8)
                {
                    het = he - 8;
                    phe = ph * 2 * 8 + ph * 3 * het;
                }
                else
                {
                     phe = ph * 2 * he;
                }
                 pt = ph * 40 + phe; 

            }
            else
            {
                pt = ph * ht;
            }
            Console.WriteLine(pt);

             



        }
    }
}

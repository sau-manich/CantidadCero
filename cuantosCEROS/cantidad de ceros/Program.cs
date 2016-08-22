using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantidad_de_ceros
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, num, dig, x;
            c = 0;
            x = 0;
            Console.WriteLine("introdusca el valor");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                c++;
                dig = num % 10;
                if (dig == 0)
                {
                    x = x + 1;
                }
               
                num = num / 10;
            } while (num != 0);
            Console.WriteLine("la cantidad de ceros son " + x);
            Console.ReadKey();
        }
    }
}

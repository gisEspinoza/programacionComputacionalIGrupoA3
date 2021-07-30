using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica3007
{
    class Ejemplo1
    {
        static void Main(string[] args)
        {
            //if anidados
            int a = 10, b = 20;

            if (a != b) //evalua si a es diferente de b
            {
                if (a < b)
                {
                    Console.WriteLine("a es menor a b");
                }
                else if(a>b)
                {
                    Console.WriteLine("a es mayor a b");
                }
            }
            else
                Console.WriteLine("a es igual a b");
            

            Console.ReadKey(); //espera que el usuario presione una tecla
        }
    }
}

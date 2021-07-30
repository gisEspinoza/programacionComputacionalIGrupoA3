using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica3007
{
    class Ejemplo2
    {
        static void Main(string[] args)
        {
            //instruccion switch

            int a = 10;

            /* switch (a)
             {
                 case 5:
                     Console.WriteLine("El valor de a es 5");
                     break;
                 case 10:
                     Console.WriteLine("El valor de a es 10");
                     break;
                 default:
                     Console.WriteLine("El valor no es conocido");
                     break;
             }*/

            switch (a)
            {
                case 10:
                    Console.WriteLine("El valor de a es 10");
                    switch (a - 1) //9
                    {
                        case 9:
                            Console.WriteLine("El valor de a es 9");
                            switch (a - 2)//que valor va a imprimir?
                            {
                                case 7:
                                    Console.WriteLine("El valor de a es 7");
                                    break;
                                case 8:
                                    Console.WriteLine("El valor de a es 8");
                                    break;
                                case 9:
                                    Console.WriteLine("El valor de a es 9");
                                    break;
                            }
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("El valor de a es 5");
                    break;
                default:
                    Console.WriteLine("El valor no es conocido");
                    break;
            }


            Console.ReadKey();
        }
     }
}

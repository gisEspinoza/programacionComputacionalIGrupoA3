using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica3007
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jose"; //operador de asignacion =
            string saludo = "Bienvenido ";


            //operadores
            //Console.WriteLine(8 + 7); //sumar valores
            //Console.WriteLine(saludo + nombre); //concatenar


            //declaracion if
            int a = 100, b = 20; //declaracion y asignacion

            if(a < b) //operador de comparacion
            {
                Console.WriteLine("a es menor a b");
            }
            else if (a > b)
            { 
                Console.WriteLine("a es mayor a b");
            }             
            else
            {
                Console.WriteLine("a es igual a b");
            }

            Console.ReadKey();

        }
    }
}

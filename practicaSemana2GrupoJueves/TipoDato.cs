using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaSemana2GrupoJueves
{
    class TipoDato
    {
        static void Main(string[] args) //metodo principal
        {
            /* Console.WriteLine("Esta es la clase TipoDato");
             Console.ReadKey();*/
            //TIPOS DE DATOS

            //ENTEROS
            //1 byte
            byte num = 255;

            //permite negativos, 
            sbyte num1 = -127;

            //int, 4 bytes
            int num2 = 1266666;
            int num3 = -123333333;

            uint num4 = 123; //solo admite positivos

            //long, 8 bytes
            long num5 = -5555555555555555;
            long num6 = 798989898915212121;

            ulong num7 = 97979797979;

            //DECIMALES
            //float, 4 bytes
            float num8 = 25.60888787788787878787f;

            //double, 8 bytes
            double num9 = 25.6d;

            //decimal, 16 bytes
            decimal num10 = 26666.5m;

            //CARACTERES
            //char, solo permite 2 bytes
            //se utilizan para almacenar un caracter
            char caracter = 'd'; //encerrar en comillas simples

            string mensaje = "Programacion Computacional I";

            //TIPO DE DATO IMPLICITO
            //peticion de datos, y declaracion de variables
            Console.Write("Cual es su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Cual es su edad: ");
            //var edad = Console.ReadLine();
            int edad = int.Parse(Console.ReadLine());

            var cantidad = 36.55555d;

            //mostrar la salida
            Console.WriteLine("Hola {0}, tienes {1} años", nombre, edad);

            //mostar el tipo de dato almacenado en las variables
            Console.WriteLine("El tipo de dato para nombre, es {0}",
                nombre.GetType());
            Console.WriteLine("El tipo de dato para edad",
                edad.GetType());
            Console.WriteLine("El tipo de dato para cantidad es {0}",
                cantidad.GetType());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTeorica3007
{
    class Ejemplo3
    {

        //ENUM
        //es una clase especial que representa un grupo de constantes(variables inmutables, solo de lectura)
        public enum Dias{ 
            LUNES, MARTES, MIERCOLES, JUEVES, VIERNES
        }
        static void Main(string[] args) //metodo principal
        {
            //pedir datos al usuario
            Console.WriteLine("Escriba el número correspondiente al día de la semana: ");
            int dia = Int32.Parse(Console.ReadLine()); //conversion de tipo de dato
            //int dia = Convert.ToInt32(Console.ReadLine()); //conversion de tipo de dato

            switch (dia)
            {
                case 1:
                    Console.WriteLine(Dias.LUNES);
                    break;
                case 2:
                    Console.WriteLine(Dias.MARTES);
                    break;
            }


            Console.ReadKey();
        }
    }
}

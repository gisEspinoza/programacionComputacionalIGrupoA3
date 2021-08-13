﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasePractica1008
{
    class Arreglos
    {
        static void Main() 
        {
            //Solicitar el nombre del estudiante
            //solicitar la nota del estudiante
            //IMPRIMIR LA NOTA PROMEDIO DE N NOTAS
            //IMPRIMIR EL NOMBRE DEL ESTUDIANTE CON LA NOTA MAS ALTA

            int[] notas = new int[5];

            //capturar las notas
            for (int i = 0; i < notas.Length; i++)
            {
                //solicitar las notas al usuario
                Console.Write("Escriba la nota {0}: ", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());

            }


            Console.WriteLine("Array desordenado");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota {0}: {1}", i, notas[i]); //imprime los valroes
            }



            //ordenar el arreglo
            // Array.Sort(notas); //el metodo Sort de la clase Array permite ordenar los elementos de un array unidimensional
            Array.Reverse(notas); //permite invertir los elementos de un array

            //recorrer el arreglo de notas
            Console.WriteLine("Array ordenado con el metodo Sort()");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota {0}: {1}", i, notas[i]); //imprime los valroes
            }

            Console.ReadKey();
        }
    }
}

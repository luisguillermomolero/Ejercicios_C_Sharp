using System;
using System.Linq;
using System.Collections;
using System.Text;

namespace AplicacionBase
{
    /*Programa que permite calcular el promedio de un salon de clases*/

    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, cantidad = 0;
            float calif = 0, suma = 0, promedio = 0.0f;
            string valor = "";

            Console.WriteLine("Dame la cantidad de alumnos:");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            for (n = 1; n <= cantidad; n++)
            {
                Console.WriteLine("Dame la calificacion del alumno {0}", n);
                valor = Console.ReadLine();
                calif = Convert.ToSingle(valor);
                suma += calif;
            }
            promedio = suma / cantidad;
            Console.WriteLine("El  promedio  es   {0}",promedio);
        }
    }
}

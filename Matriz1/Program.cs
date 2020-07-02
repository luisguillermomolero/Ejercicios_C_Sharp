using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace AplicacionBase
{
    class Program
    {
        static void Main (string[] args)
        {
            int alumnos, n = 0;
            string valor = "";
            float sumatoria = 0;
            float promedio = 0;
            float minima = 10;
            float maxima = 0;

            Console.WriteLine("Ingrese la cantidad de alumnos");
            valor = Console.ReadLine();
            alumnos = Convert.ToInt32(valor);

            float [] aula = new float [alumnos];

            for (n= 0; n < alumnos; n++)
            {
                Console.WriteLine("Calificación del alumno {0}", n+1);
                valor = Console.ReadLine();
                aula[n] = Convert.ToSingle(valor);
                sumatoria = sumatoria + aula[n];
                if (aula[n] < minima)
                {
                    minima = aula[n];
                }
                else
                    maxima = aula[n];
            }
            promedio = sumatoria / alumnos;
            Console.WriteLine("El promedio es {0}",  promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);
        }
    }
}
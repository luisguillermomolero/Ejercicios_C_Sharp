using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace aplicacionBase
{
    /*Programa para una escuela que debe sacar el promedio de las calificaciones para tres alumnos*/

    class Program
    {static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("***** ANTES DEL CICLO *****");
            for (n = 0; n <= 5; n++)
                Console.WriteLine("{0}", n);
            Console.WriteLine("***** DESPUES DEL CICLO *****");

            Console.WriteLine("***** ANTES DEL CICLO *****");
            for (n = 3; n <= 7; n++)
                Console.WriteLine("{0}", n);
            Console.WriteLine("***** DESPUES DEL CICLO *****");

            Console.WriteLine("***** ANTES DEL CICLO *****");
            for (n = -3; n <= 3; ++n)
                Console.WriteLine("{0}", n);
            Console.WriteLine("***** DESPUES DEL CICLO *****");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    class Program
    {
        static void   Main(string[] args)
        {
            //Paso por valor
            int numero =  5;
            Console.WriteLine("PASO POR VALOR");
            Console.WriteLine("Valor dentro de la función Main {0}",  numero);
            Cambiar(numero);
            Console.WriteLine("Valor dentro de la función Main {0}",  numero);

            //Paso por referencia
            Console.WriteLine();
            Console.WriteLine("PASO POR REFERENCIA");
            Console.WriteLine("Valor dentro de la función Main {0}", numero);
            Referencia(ref numero);
            Console.WriteLine("**** Valor dentro del método CAMBIAR {0} ****", numero);
            Console.WriteLine("Valor dentro de la función Main {0}", numero);

        }
        static void Cambiar(int numero)
        {
            numero = 17;
            Console.WriteLine("**** Valor dentro del método CAMBIAR {0} ****", numero);
        }
        static void Referencia(ref int numero)
        {
            numero = 55;
        }

    }
}

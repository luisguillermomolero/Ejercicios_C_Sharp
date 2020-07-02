using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace AplicacionBase
{
    /*Uso de contadores y acumuladores*/
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, contador = 0, acumulador = 0;

            Console.WriteLine("+++++ ANTES DEL CICLO +++++");
            for (n = 10; n >= 1; n--)
            {
                contador = contador + 1;
                acumulador = acumulador + contador;
                Console.WriteLine("{0}, {1}", contador, acumulador);
            }
            Console.WriteLine("+++++ ANTES DEL CICLO +++++");
        }
    }
}

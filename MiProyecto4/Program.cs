using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacionBase
{
    class Program
    {
        // Esta  es   la  función principal del   programa
        // Aquí inicia  la aplicación 
        static void Main(string[] args)
        {
            // Declaramos  variables
            string entrada = "";
            int a = 0, b = 0, resultado = 0;

            //leemos la cadena
            Console.Write("Escribe tu nombre: ");
            entrada = Console.ReadLine();

            //Mostrar nombre por consola
            Console.WriteLine("Hola {0}, como estas", entrada);

            //capturamos el valor de "a"
            Console.Write("Introduzca el valor de a: ");
            entrada = Console.ReadLine();

            //convertimos a entrada de string a entero
            a = Convert.ToInt32(entrada);

            //capturamos el valor de "b"
            Console.Write("Introduzca el valor de b ");
            entrada = Console.ReadLine();

            //convertimos a entrada de string a entero
            b = Convert.ToInt32(entrada);

            //sumamos los valores de a+b
            resultado = a + b;

            //mostramos el resultado final
            Console.WriteLine("El resultado = {0}", resultado);

        }
    }
}
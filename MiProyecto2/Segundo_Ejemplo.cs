using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionBase
    {
    class Segundo_Ejemplo
    {
        ///<summary>
        /// Aquí se inicia el programa, la siguiente clase es la inicial
        /// </summary>
        /// <remarks>
        /// En este ejeplo se creo un mensaje primero y se declararon variables despues
        /// </remarks>

        static void Main(string[] args)
        {
            // Declarar variables de ejemplo

            int costo;
            int valor;
            int impuesto;
            
            /* Tambien se puede definir así:
            int costo, valor, impuesto; */

            // Aquí le damos valores a las variables, si se inician en 0 son variables, si se les da un valor, serán constantes

            costo = 50;
            valor = 75;
            impuesto = 10;

            /* Otra forma de declarar variables y darle valores en la misma sentencia es así:
            int costo = 50; */


            Console.Write("1.- Precalentar al horno");
            Console.WriteLine("2.- Prueba 2");
            Console.Write("2.- Prueba 2");
            Console.WriteLine("2.- Prueba 2");
            Console.WriteLine("2.- Prueba 2");

            //En la siguiente instrucción se imprime por consola en valor de la variable "costo"

            Console.WriteLine(" Se tiene {0} en la variable", costo);

            //O se puede mostrar de esta manera

            Console.WriteLine(" La primera es {0} y la segunda es {1}", costo, valor);
        }
    }
}

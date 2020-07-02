using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionBase
{
    /// <summary>
    /// Tercera clase: Uso de operadores aritmeticos
    /// </summary>
    /// <remarks>
    /// Ejercicios varios
    /// </remarks>
    
    //Inicio de la clase program
    class Program
    {
        
        // Inicio de la clase principal
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            float resultado = 0;


            /*Otra forma
            int resultado = a + 3;
            float resultado = a + b; */

            //Suma de valores

            Console.WriteLine("Sumas");

            resultado = 3 + 5;
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = a + 3;
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = a + b;
            Console.WriteLine("Resultado = {0}", resultado);

            // Restas
            Console.WriteLine("Restas");

            resultado = a - b;
            Console.WriteLine("Resultado =  {0}",  resultado);

            resultado = b - 5;
            Console.WriteLine("Resultado =  {0}",  resultado);

            resultado = b - a;     // A   la variable b  se   le  resta a
            Console.WriteLine("Resultado =  {0}",  resultado);

            // Multiplicaciones
            Console.WriteLine("Multiplicaciones");

            resultado = a * 5;
            Console.WriteLine("Resultado =  {0}",  resultado);

            resultado = a * 3.5f; //declarar numero como float
            Console.WriteLine("Resultado =  {0}",  resultado);

            resultado = a * b;
            Console.WriteLine("Resultado =  {0}",  resultado);

            // Divisiones
            Console.WriteLine("Divisiones");

            resultado = a / 3;
            Console.WriteLine("Resultado =  {0}",  resultado);

            resultado = a / b;
            Console.WriteLine("Resultado =  {0}",  resultado);

            resultado = b / 2.5f; //declarar numero como float
            Console.WriteLine("Resultado =  {0}",  resultado);

            // Modulo
            Console.WriteLine("Modulo");

            resultado = a % b;
            Console.WriteLine("Resultado =  {0}",  resultado);

            //uso de parentesis

            Console.WriteLine("Uso de parentesis");

            resultado = (25 * 3) + 5;
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = 15 + (654 - 600);
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = (3 * 5) + 2;
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = 3 * (5 + 2);
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = (3 + 7) * (36 + 4 * (2 + 5));
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = 10 * (36 + 4 * 7);
            Console.WriteLine("Resultado = {0}", resultado);

            resultado = 10 * (36 + 28);
            Console.WriteLine("Resultado = {0}", resultado);

            //solicitar datos por consola

            //se declara la variable "cadena" "string"
            string entrada = " ";

            //se captura la cadena por consola

            Console.WriteLine("Escriba su nombre");
            entrada=Console.ReadLine();

            // se muestra el nombre por consola

            Console.WriteLine("Hola {0}, como esta", entrada);

        }
    }
}

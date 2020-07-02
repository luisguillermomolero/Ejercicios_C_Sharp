using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {

            float a = 0, b = 0, resultado = 0;
            string valor = "";
            int opcion = 0;

            Console.WriteLine("1 - Suma"); 
            Console.WriteLine("2 - Resta"); 
            Console.WriteLine("3 - División"); 
            Console.WriteLine("4 - Multiplicación"); 
            Console.Write("Que operación deseas hacer:  "); 
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            /*Esta instrucción elimina el default al final del "Switch" y sale
             * de la aplicación si la opción es mayor a 4 */

            if (opcion > 4)
                Environment.Exit(0);

            Console.Write("Dame el primer  numero:");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);

            Console.Write("Dame el segundo numero:"); 
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);

            switch (opcion)
            {
                case 1:
                    resultado = a + b;
                    Console.WriteLine("El resultado es : {0}", resultado);
                    break;
                case 2:
                    resultado = a - b;
                    Console.WriteLine("El resultado es : {0}", resultado);
                    break;
                case 3:
                    if (b != 0)
                    {
                        resultado = a / b;
                        Console.WriteLine("El resultado es : {0}", resultado);
                    }
                    else
                        Console.WriteLine("Divisor no valido");
                    break;
                case 4:
                    resultado = a * b;
                    Console.WriteLine("El resultado es : {0}", resultado);
                    break;
             /*   default:
                    Console.WriteLine("Opción no valida, Chao");
                    break; */
            }

        }
    }
}
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System;

namespace AplicacionBase
{
    class Program
    {
        /*Programa que permite a traves de una opción específica resulver una
         * operación matemática.  Programa hecho con funciones de C# */
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";
            float resultado;
            float n1, n2 = 0;

            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            Console.WriteLine("Seleccione una opción");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            switch (opcion)
            {
                case 1:
                    {
                        n1 = CapturarValor();
                        n2 = CapturarValor();
                        resultado = n1 + n2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        Environment.Exit(0);
                        break;
                    }
                case 2:
                    {
                        n1 = CapturarValor();
                        n2 = CapturarValor();
                        resultado = n1 - n2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        Environment.Exit(0);
                        break;
                    }
                case 3:
                    {
                        n1 = CapturarValor();
                        n2 = CapturarValor();
                        resultado = n1 * n2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        Environment.Exit(0);
                        break;
                    }
                case 4:
                    {
                        n1 = CapturarValor();
                        n2 = CapturarValor();
                        resultado = n1 / n2;
                        Console.WriteLine("El resultado es {0}", resultado);
                        Environment.Exit(0);
                        break;
                    }

            }
        }
        static float CapturarValor()
        {
            float x = 0;
            string numero = "";

            Console.WriteLine("Ingrese un número");
            numero = Console.ReadLine();
            x = Convert.ToSingle(numero);

            return x;
        }
    }
}
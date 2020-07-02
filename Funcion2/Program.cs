using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AplicacionBase
{
    class Program
    {
        static void Main(String[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - Division");

            Console.WriteLine("Cual es tu opcion:");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                /*Funcion que solo ejecuta código */
                Suma();
            }
            if (opcion == 2)
            {
                /*Funcion que regresa un valor*/
                float resultado = 0;
                resultado = Resta();
                Console.WriteLine("El resultado de la resta es {0}", resultado);
            }
            if (opcion == 3)
            {
                /*Función que recibe valores*/
                float n1 = 0, n2 = 0;
                string numero = "";

                Console.WriteLine("Dame el primer numero"); 
                numero = Console.ReadLine();
                n1 = Convert.ToSingle(numero);

                Console.WriteLine("Dame el segundo numero");
                numero = Console.ReadLine();
                n2 = Convert.ToSingle(numero);

                Multiplicacion(n1, n2);
            }
            if (opcion == 4)
            {
                /*Función que recibe valores y devuelve valores */
                float n1, n2 = 0;
                string numero = "";
                float resultado = 0;

                Console.WriteLine("Dame el primer numero");
                numero = Console.ReadLine();
                n1 = Convert.ToSingle(numero);

                Console.WriteLine("Dame el segundo numero");
                numero = Console.ReadLine();
                n2 = Convert.ToSingle(numero);

                resultado = Division(n1, n2);
                Console.WriteLine("El resultado es {0}", resultado);

            }
        }
        static void Suma()
        {
            /*Funcion que SOLO ejecuta código */

            float a = 0, b = 0, r = 0;
            string numero = "";

            Console.WriteLine("Dame  el primer  numero");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Dame  el segundo  numero");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            r = a + b;
            Console.WriteLine("El resultado es: {0}", r);
        }
        static float Resta()
        {
            /*Funcion que RETORNA un valor*/
            float a = 0, b = 0, r = 0;
            string numero = "";

            Console.WriteLine("Dame  el primer  numero");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Dame  el segundo  numero");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            r = a - b;
            return r;
        }
        static void Multiplicacion(float a, float b)
        {
            /*Función que RECIBE valores*/
            float r = 0;
            r = a * b;
            Console.WriteLine("El resultado es {0}", r);
        }
        static float Division(float a, float b)
        {
            /*Función que recibe valores y devuelve valores */
            float r = 0;
            if(b==0)
            {
                Console.WriteLine("No es posible dividir");
                return 0;   
            }
            else
            {
                r = a / b;
                return r;
            }
        }
    }
}
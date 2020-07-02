using System;
using System.Collections.Generic;
using System.Text;
namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicacion");
            Console.WriteLine("4-Division");
            Console.WriteLine("Cual es tu opcion:");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                Suma();
            }
            if (opcion == 2)
            {
                float resultado = 0;
                resultado = Resta();
                Console.WriteLine("El resultado de la resta es {0}", resultado);
            }
            if (opcion == 3)
            {

                float n1 = 0;
                float n2 = 0;
                n1 = PideFlotante("Dame el primer numero");
                n2 = PideFlotante("Dame el segundo numero");
                Multiplicacion(n1, n2);
            }
            if (opcion == 4)
            {
                float n1 = 0.0f;
                float n2 = 0.0f;
                float resultado = 0.0f;

                n1 = PideFlotante("Dame el primer numero");
                n2 = PideFlotante("Dame el segundo numero");

                resultado = Division(n1, n2);
                Console.WriteLine("El resultadO es {0}", resultado);
            }
        }
        static void Suma()
        {
            float a, b = 0;
            float r = 0;

            a = PideFlotante("Dame el primer numero");
            b = PideFlotante("Dame el segundo numero");

            r = a + b;

            Console.WriteLine("El resultado  es {0}", r);
        }
        static float Resta()
        {
            float a, b = 0;
            float r = 0;

            a = PideFlotante("Dame  el primer  numero");
            b = PideFlotante("Dame  el segundo  numero");

            r = a - b;
            return r;
        }
        static void Multiplicacion(float a, float b)
        {
            float r = 0;
            r = a * b;

            Console.WriteLine("El resultado  es   {0}", r);
        }
        static float Division(float a, float b)
        {
            float r = 0;

            if (b == 0)
            {
                Console.WriteLine("No es  posible dividir  entre cero");
                return 0.0f;
            }
            else
            {
                r = a / b;
                return r;
            }
        }
        static float PideFlotante(string mensaje)
        {
            float numero = 0;
            string valor = "";

            Console.WriteLine(mensaje);
            valor = Console.ReadLine();
            numero = Convert.ToSingle(valor);

            return numero;
        }
    }
}
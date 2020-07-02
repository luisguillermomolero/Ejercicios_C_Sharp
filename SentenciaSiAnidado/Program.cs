using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace AplicacionBase
{
    /*programa que pedirá el tipo de operación aritmética que deseamos ejecutar y 
     * luego los dos números con los que llevar a cabo la operación. 
     * El resultado  se desplegará en la pantalla.*/

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
            Console.Write("Que operación  deseas  hacer:  "); 
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            Console.Write("Dame   el primer  numero:");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);

            Console.Write("Dame   el segundo  numero: "); 
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);

            if (opcion == 1)
                resultado = a + b;
            if (opcion == 2)
                resultado = a - b;
            if (opcion == 3)
                if (b != 0)
                    resultado = a / b;
                else
                    Console.WriteLine("Divisor  no  valido");
            if (opcion == 4)
                resultado = a * b;
            
            Console.WriteLine("El resultado  es:  {0} ", resultado);

        }
    }
}

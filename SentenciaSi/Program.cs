using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionBase
{
    //Programa que permite introducir un número por teclado e identificar si el número es positivo o negativo
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";
                        
            Console.WriteLine("Ingrese un número");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor); //convertir el numero a entero

            if (numero >= 0)
                Console.WriteLine("El número {0} es positivo", numero);

            if (numero < 0)
                Console.WriteLine("El número {0} es negativo", numero);

        }
    }
}

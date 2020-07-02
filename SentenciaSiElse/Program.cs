using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SentenciaSiElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";

            Console.WriteLine("Ingrese un número");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if (numero >= 0)
                Console.WriteLine("El número {0} es positivo", numero);
            else
                Console.WriteLine("El número {0} es negativo", numero);

        }
    }
}

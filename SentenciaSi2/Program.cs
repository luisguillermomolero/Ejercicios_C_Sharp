using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SentenciaSi2
{
    /*Programa que pregunte al usuario el dividendo y el divisor, pero 
    que cuando el divisor sea cero no lleve a cabo la división. */
    class Program
    {

        static void Main(string[] args)
        {
            float dividendo = 0;
            float divisor = 0;
            float resultado = 0;
            string valor = "";

            Console.WriteLine("Ingrese el dividendo");
            valor = Console.ReadLine();
            dividendo = Convert.ToInt32(valor);

            Console.WriteLine("Ingrese el divisor");
            valor = Console.ReadLine();
            divisor = Convert.ToInt32(valor);

            if(divisor !=0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("El resultado es = {0}", resultado);
                
            }
        }
    }
}

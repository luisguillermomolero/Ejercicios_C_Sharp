using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            float dividendo = 0;
            float divisor = 0;
            float resultado = 0;
            string valor = "";

            Console.WriteLine("Dame  el  dividendo:"); 
            valor = Console.ReadLine();
            dividendo = Convert.ToInt32(valor);

            Console.WriteLine("Dame  el divisor:"); 
            valor = Console.ReadLine();
            divisor = Convert.ToInt32(valor);


            if (divisor == 0)
                Console.WriteLine("El divisor  no  es   válido");
            else
            {
                resultado = dividendo / divisor;
                Console.WriteLine("El resultado  de la división es  {0}", resultado);
            }
        }
    }
}
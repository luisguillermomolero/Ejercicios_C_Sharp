using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace AplicacionBase
{
    /*Programa para calcular el factorial de un numero
     * Ejemplo: el factorial de 5 es 5*4*3*2*1 = 120 */

    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, numero = 0, factorial =  1;
            string valor = "";

            Console.WriteLine("Dame  el número al que  se  le saca  el factorial:");
            valor = Console.ReadLine();

            numero = Convert.ToInt32(valor);

            //Calculamos  el factorial en  el ciclo For
            for   (n  =  numero; n  >= 1;  n--)
            factorial *= n;

            // Mostramos el  resultado
            Console.WriteLine("El  factorial de  {0} es  {1}", numero, factorial);
        }
    }
}

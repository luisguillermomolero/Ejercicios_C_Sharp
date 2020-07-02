using System;
using System.Linq;
using System.Collections;
using System.Text;

namespace AplicacionBase
{
    /*Ejemplo de incremento ++ y decremento -- como sufijo y prefijo*/

    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;

            Console.WriteLine("El valor inicial es {0}", numero);

            // Incremento
            numero++;
            Console.WriteLine("Despues del incremento {0}", numero);

            //Decremento
            numero--;
            Console.WriteLine("Despues de decremento {0}", numero);

            //Incremento desde la sentencia
            Console.WriteLine("Incremento en la sentencia {0}", numero++);
            Console.WriteLine("Valor despues de la sentencia {0}", numero);

            //Incremento en la sentencia como prefijo
            Console.WriteLine("Incremento en la sentencia {0}", ++numero);
            Console.WriteLine("Valor después de la sentencia {0}", numero);


            //Decremento desde la sentencia
            Console.WriteLine("Decremento desde la sentencia {0}", numero--);
        }
    }
}

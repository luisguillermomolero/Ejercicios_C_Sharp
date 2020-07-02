using System;
using System.Linq;
using System.Collections;
using System.Text;


namespace CicloWhile
{
    /*programa de control para enfriar una caldera. La caldera debe ser enfriada a 20 grados centígrados. 
     * El ciclo while será usado para reducir la temperatura de uno en uno para cada vuelta del ciclo 
     * hasta que lleguemos a 20 grados centígrados. La ventaja que nos da este ciclo es que si la 
     * temperatura  es menor a 20 grados, ni siquiera se entra al ciclo y no se lleva a cabo ningún 
     * enfriamiento. */

    class Program
    {
        static void Main(string[] args)
        {
            int temperatura = 0;
            string valor = "";

            Console.WriteLine("Por favor, dame la temperatura");
            valor = Console.ReadLine();
            temperatura = Convert.ToInt32(valor);

            while (temperatura > 20)
            {
                temperatura--;
                Console.WriteLine("Temperatura -> {0}", temperatura);
            }
            Console.WriteLine("La temperatura final es {0}", temperatura);
        }
    }
}

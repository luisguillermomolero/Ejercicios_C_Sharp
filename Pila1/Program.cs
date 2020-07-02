using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            //Creación de la pila (Stack)
            Stack miPila = new Stack();

            do
            {
                Console.WriteLine("1 - Push");
                Console.WriteLine("2 - Pop");
                Console.WriteLine("3 - Clear");
                Console.WriteLine("4 - Contains");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("Dame  tu  opcion");

                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    //Solicitamos el número
                    Console.WriteLine("Dame el valor a introducir en la pila");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //Agregamos el valor en la pila
                    miPila.Push(numero);
                }
                if (opcion == 2)
                {
                    //Capturamos el elemento
                    numero = (int)miPila.Pop();

                    //Mostramos el elemento
                    Console.WriteLine("El valor  obtenido es:  {0}", numero);
                }
                if (opcion == 3)
                {
                    //Limpiamos todo la pila
                    miPila.Clear();
                }
                if (opcion == 4)
                {
                    //Pedimos el valor a encontrar dentro de la pila
                    Console.WriteLine("Dame  el  valor a encontrar");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    //HAcemos una busqueda a ver si el valor esta dentro de la pila
                    encontrado = miPila.Contains(numero);

                    // Mostramos el  resultado
                    Console.WriteLine("Encontrado - {0}", encontrado);
                }

                // Mostramos la  informacion del   stack
                Console.WriteLine("El stack  tiene  {0}  elementos", miPila.Count);
                foreach (int n in miPila)
                    Console.Write("  {0},", n);

                Console.WriteLine("");
                Console.WriteLine("————");
            }
            while (opcion != 5);
        }
    }
}
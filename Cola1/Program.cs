using System.Collections;
using System.Text;
using System.Linq;
using System;

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

            //Creacion de la cola
            Queue miFila = new Queue();

            do
            {
                Console.WriteLine("1-   Enqueue");
                Console.WriteLine("2-   Dequeue");
                Console.WriteLine("3-  Clear");
                Console.WriteLine("4- Contains");
                Console.WriteLine("5-  Salir");
                Console.WriteLine("Dame  tu  opcion");

                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    // Pedimos  el  valor a  introducir
                    Console.WriteLine("Dame  el  valor a introducir");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    // Adicionamos  el  valor en  el queue
                    miFila.Enqueue(numero);
                }
                if (opcion == 2)
                {
                    // Obtnemos el  elemento 
                    numero = (int)miFila.Dequeue();
                    // Mostramos el  elemento
                    Console.WriteLine("El valor  obtenido es:  {0}", numero);
                }
                if (opcion == 3)
                {
                    // Limpiamos todos los contenidos del Queue
                    miFila.Clear();
                }
                if (opcion == 4)
                {
                    // Pedimos  el  valor a  encontrar
                    Console.WriteLine("Dame el valor a encontrar");
                    valor = Console.ReadLine();
                    numero = Convert.ToInt32(valor);

                    // Vemos si el elemento   esta
                    encontrado = miFila.Contains(numero);

                    // Mostramos el  resultado
                    Console.WriteLine("Encontrado - {0}", encontrado);
                }
                // Mostramos la informacion de la cola
                Console.WriteLine("La cola tiene {0} elementos", miFila.Count);
                foreach (int n in miFila)
                    Console.Write("  {0},", n);

                Console.WriteLine("");
                Console.WriteLine("————");

            }
            while (opcion != 5);
        }
    }
}
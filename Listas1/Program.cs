using System.Linq;
using System;
using System.Collections;
using System.Text;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 0;
            int cantidad = 0;

            ArrayList datos = new ArrayList();

            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Tenemos inicialmente los datos");
            Imprime(datos);

            //Segunda parte del ejercicio

            //Hacer crecer la lista
            datos.Add(4);
            datos.Add(5);

            //obtener el indice
            indice = datos.Add(10);

            Console.WriteLine("Despues de hacerlo crecer:");
            Imprime(datos);
            Console.WriteLine("El último elemento tiene el indice {0}", indice);
            Console.WriteLine("\n__________________________________");

            //Tercera parte de ejercicio
            //Imprimir un elemento en particular
            Console.WriteLine("El valor en el indice 2 es: {0}", datos[2]);
            Console.WriteLine("\n__________________________________");

            //Modificar un dato
            datos[3] = 55;
            Console.WriteLine("Despues de la modificación, la lista resultante es:");
            Imprime(datos);

            //Obtenemos la cantidad
            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elementos de la lista es {0}", cantidad);
            Console.WriteLine("\n__________________________________");

            //Cuarta parte
            datos.Insert(2, 88);
            Console.WriteLine("Despues de la inserción");
            Imprime(datos);

            //Eliminación de un elemento de la lista
            datos.RemoveAt(4);
            Console.WriteLine("Despues de eliminar el elemento de la posición 4");
            Imprime(datos);

            //Encontrar un numero dentro de la lista
            indice = datos.IndexOf(5);
            Console.WriteLine("El primer número 5 se encuentra en la posición ");
            Console.WriteLine("\n__________________________________");


        }
        static void Imprime (ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0},", n);
            Console.WriteLine("\n__________________________________");
        }
    }
}
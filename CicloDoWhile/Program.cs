using System;

namespace CicloDoWhile
{
    //Programa que transforme de pies y pulgadas a centímetros

    class Program
    {
        static void Main(string[] args)
        {
            float pies = 0, pulgadas = 0, centimetros = 0;
            string respuesta = "", valor = "";

            do
            {
                // Pedimos  los pies 
                Console.WriteLine("Cuántos pies:"); 
                valor =  Console.ReadLine();
                pies = Convert.ToSingle(valor);

                // Pedimos  las  pulgadas 
                Console.WriteLine("Cuántas pulgadas:"); 
                valor =  Console.ReadLine();
                pulgadas = Convert.ToSingle(valor);

                // Convertimos  a  centimetros
                centimetros = ((pies * 12) + pulgadas) * 2.54f;

                // Mostramos el  resultado
                Console.WriteLine("Son {0} centímetros", centimetros);

                // Preguntamos  si otra   conversión
                Console.WriteLine("Deseas hacer otra conversión (si / no) ?");
                respuesta = Console.ReadLine();


            } while (respuesta == "si");

        }
    }
}

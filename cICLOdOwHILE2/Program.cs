using System;
using System.Linq;
using System.Collections;
using System.Text;


namespace AplicacionBase
{
    /*Programa que muestra un menu de opciones para ejecutar operaciones matemática*/

    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0, resultado = 0;
            string valor = "";
            int opcion = 0;

            do
            {
                Console.WriteLine("1.- Suma");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- División");
                Console.WriteLine("4.- Multiplicación");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("Opción? ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion != 5)
                {
                    Console.WriteLine("Ingrese el primero número ");
                    valor = Console.ReadLine();
                    a = Convert.ToSingle(valor);
                    Console.WriteLine("Ingrese el segundo número ");
                    valor = Console.ReadLine();
                    b = Convert.ToSingle(valor);

                    switch (opcion)
                    {
                        case 1:
                            resultado = a + b;
                            Console.WriteLine("El resultado de {0} + {1} es {2}", a, b, resultado);
                            break;
                        case 2:
                            resultado = a - b;
                            Console.WriteLine("El resultado de {0} - {1} es {2}", a, b, resultado);
                            break;
                        case 3:
                            if (b != 0)
                            {
                                resultado = a / b;
                                Console.WriteLine("El resultado de {0} / {1} es {2}", a, b, resultado);
                            }
                            else
                                Console.WriteLine("Divisor  no  válido");
                            break;
                        case 4:
                            resultado = a * b;
                            Console.WriteLine("El resultado de {0} * {1} es {2}", a, b, resultado);
                            break;
                        default:
                            Console.WriteLine("Opción no valida");
                            break;
                    }
                }
            } while (opcion != 5);
        }
    }
}

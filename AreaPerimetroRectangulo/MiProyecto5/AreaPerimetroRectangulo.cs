using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace MiProyecto5
{
    /// <summary>
    /// Hacer un programa de cómputo que calcule el área y el perímetro de un rectángulo dados sus lados.
    /// </summary>

    ///<remarks>
    /// se inicia la clase AreaPerimetroRectangulo
    /// </remarks>

    class AreaPerimetroRectangulo
    {
                // Se inicia la clase principal static void Main

        static void Main(string[] args)
        {
            //Se declarar las variables del programa

            float ancho = 0, alto = 0, area = 0, perimetro = 0;
            string valor = "";

            //solicitar por consola valor del "ancho" del rectangulo
            Console.Write("Ingrese el valor de ancho del rectangulo : ");
            valor = Console.ReadLine();
            ancho = Convert.ToSingle(valor); //se convierte en flotante

            //Solicitar por consola el valor de "alto" del rectangulo
            Console.Write("Ingrese el valor de alto del rectangulo: ");
            valor = Console.ReadLine();
            alto = Convert.ToSingle(valor); //se convierte en flotante

            //Se calcula el área del rectangulo
            area = ancho * alto;

            //se calcula el perimetro del rectangulo
            perimetro = (ancho + alto) * 2;

            Console.WriteLine("El área es = {0}", area);
            Console.Write("El perimetro es = {0}", perimetro);

        }
    }
}
using System;
using System.Text;
using System.Linq;
using System.Collections;

namespace AplcacionBase
{
    class cubo
    {
        public int lado;
        public int area;
        public int volumen;

        public void CalculoArea()
        {
            area = (lado * lado) * 6;
        }
        public void CalculoVolumen()
        {
            volumen = lado * lado * lado;
        }
    }
    class prisma
    {
        public int ancho;
        public int alto;
        public int espesor;
        public int area;
        public int volumen;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            int lado = 0;

            cubo miCubo = new cubo();
            
            Console.WriteLine("Introduzca el lado del cubo");
            valor = Console.ReadLine();
            lado = Convert.ToInt32(valor);

            miCubo.lado = lado;

            miCubo.CalculoArea();
            miCubo.CalculoVolumen();

            Console.Write("El area es igual a {0}, y el volumen igual a {1}", miCubo.area, miCubo.volumen);
        }
    }
}

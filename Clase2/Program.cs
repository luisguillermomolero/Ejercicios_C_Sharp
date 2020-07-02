using System;
using System.Linq;
using System.Text;
using System.Collections;


namespace Clase2
{
    class cubo
    {
        public int lado;
        public int area;
        public int volumen;

        public void CalculaArea()
        {
            area = (lado * lado) * 6;
        }
        public void CalculaVolumen()
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

        public prisma()
        {
            string valor = "";
            Console.WriteLine("Dame  el  ancho"); 
            valor = Console.ReadLine();
            ancho = Convert.ToInt32(valor);

            Console.WriteLine("Dame  el alto");
            valor = Console.ReadLine();
            alto = Convert.ToInt32(valor);

            Console.WriteLine("Dame  el espesor");
            valor = Console.ReadLine();
            espesor = Convert.ToInt32(valor);
        }
        public prisma(int pancho, int palto, int pespesor)
        {
            alto = palto;
            espesor = pespesor;
        }
        public void CalculaVolumen()
        {
            volumen = ancho * alto * espesor;
        }

        public void CalculaArea()
        {
            int a1 = 0, a2 = 0, a3 = 0;

            a1 = 2 * CalculaRectangulo(ancho, alto);
            a2 = 2 * CalculaRectangulo(ancho, espesor);
            a3 = 2 * CalculaRectangulo(alto, espesor);

            area = a1 + a2 + a3;
        }

        public int CalculaRectangulo(int a, int b)
        {
            return (a * b);
        }

        public override string ToString()
        {
            String mensaje =  "";
            mensaje += "Ancho " + ancho.ToString() + "  Alto   " + alto.ToString() + "  Espesor " + espesor.ToString();
            mensaje += " Area " + area.ToString() + " Volumen "  +  volumen.ToString();
            return mensaje;
        }


        public void ImprimeResultado()
        {
            Console.WriteLine("El área  es  {0}, el volumen es  {1}", area, volumen);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cubo miCubo = new cubo();
            cubo tuCubo = new cubo();


            // Instanciamos el  prisma
            prisma miPrisma = new prisma();


            // Instanciamos  con  la  versión sobrecargada
            prisma miPrisma2 = new prisma(3, 5, 7);


            // Asignamos el  valor del   lado miCubo.lado  =  5;
            tuCubo.lado = 8;


            // Invocamos  los métodos miCubo.CalculaArea(); miCubo.CalculaVolumen(); tuCubo.CalculaArea();
            tuCubo.CalculaVolumen();


            // Asignamos los  valores al  prisma
            // Quitar  comentarios  para  versión sin  constructor
            //miPrisma.Ancho  =  10;
            //miPrisma.Alto  =  3;
            //miPrisma.Espesor  =  5;


            // Invocamos  los métodos  del   prisma
            miPrisma.CalculaArea();

            miPrisma.CalculaVolumen();


            miPrisma2.CalculaArea();
            miPrisma2.CalculaVolumen();


            // Desplegamos  los  datos
            Console.WriteLine("Mi  cubo  Area = {0},  Volumen ={1}", miCubo.area,   miCubo.volumen);
            Console.WriteLine("Tu  cubo  Area ={0},  Volumen ={1}", tuCubo.area,  tuCubo.volumen);
            Console.WriteLine(miPrisma.ToString());
            miPrisma.ImprimeResultado();

            Console.WriteLine(miPrisma2.ToString());
        }
    }
}

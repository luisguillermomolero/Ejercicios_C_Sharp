using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionBase
{
    /*programa que nos in- dique si una persona puede conducir un 
     * automóvil, y las condiciones para que lo con- duzca son que 
     * tenga más de 15 ó 18 años y que tenga permiso de sus padres.*/
    class Program
    {
        static void Main(String[] args)
        {
            int edad = 0;
            bool permiso = false;
            string valor = "";

            Console.Write("Dame tu edad:  ");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);

            Console.Write("Tiene permiso de los padres (true / false): ");
            valor = Console.ReadLine();
            permiso = Convert.ToBoolean(valor);

            if (edad > 18 || (edad > 15 && permiso == true)) 
                Console.WriteLine("Es posible conducir");
            else
                Console.WriteLine("No puedes conducir");
        }
    }
}
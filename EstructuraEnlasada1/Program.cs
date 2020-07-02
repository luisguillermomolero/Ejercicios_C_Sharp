using System;
using System.Linq;
using System.Text;
using System.Collections;

namespace EstructuraEnlasada1
{
    class Program
    {
        public struct Direccion
        {
            public string Calle;
            public int Numero;

            public Direccion(string pCalle, int pNumero)
            {
                Calle = pCalle;
                Numero = pNumero;
            }
        }
        public struct Agenda
        {
            public string Nombre;
            public int Edad;
            public String Telefono;
            public Direccion Domicilio;

            public Agenda(string pNombre, int pEdad, string pTelefono, string pCalle, int pNumero)
            {
                Nombre = pNombre;
                Edad = pEdad;

                if (pTelefono.Length > 8)
                    Telefono = pTelefono;
                else
                    Telefono = "Teléfono no  valido";
                Domicilio = new Direccion(pCalle, pNumero);
            }
            public Agenda(String pNombre, int pEdad)
            {
                Nombre = pNombre; Edad = pEdad;
                Telefono = "Sin teléfono";
                Domicilio = new Direccion("Sin dirección", 0);
            }
            public Agenda(String pNombre)
            {
                Nombre = pNombre;
                Console.WriteLine("Dame  la  edad:");
                Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame  el  teléfono:");
                Telefono = Console.ReadLine();

                if (Telefono.Length < 8)
                    Telefono = "Sin teléfono";
                Domicilio = new Direccion("Sin dirección", 0);

            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Edad: {1}, Telefono: {2}", Nombre, Edad, Telefono);
                return (sb.ToString());
            }
        }
        static void Main(string[] args)
        {
            Agenda amigo = new Agenda("Juan", 25, "(555) 123 - 4567", "Av.Principal", 105);
            Agenda amigo1 = new Agenda("Pedro", 32, "(555)", "Calle Bolivar", 350);
            Agenda amigo2 = new Agenda("Luis", 28);
            Agenda amigo3 = new Agenda("Maria");
            Console.WriteLine(amigo.ToString());
            Console.WriteLine(amigo1.ToString());
            Console.WriteLine(amigo2.ToString());
            Console.WriteLine(amigo3.ToString());
        }
    }
}
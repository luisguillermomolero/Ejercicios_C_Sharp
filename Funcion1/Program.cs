using System.Linq;
using System.Collections;
using System.Text;
using System;

namespace AplicacionBase
{
    public class Program
    {
        public static void Main()
        {
            int value = 20;
            Console.WriteLine("En la clase principal, el valor es = {0}", value);
            ModifyValue(value);
            Console.WriteLine("Devolviendonos a la clase principal, el valor es = {0}", value);
        }
        static void ModifyValue(int i)
        {
            i = 30;
            Console.WriteLine("En la función ModifyValue, el valor es = {0}", i);
            return;
        }
    }
}
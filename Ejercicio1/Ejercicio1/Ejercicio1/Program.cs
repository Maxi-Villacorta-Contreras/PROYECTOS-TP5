using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que valide si una nota esta entre 0 y 10, sino esta entre 0 y 10 la nota se pedira de nuevo hasta que la nota sea correcta.
            int nota;
            Console.WriteLine("Ingrese una nota: ");
            nota = Convert.ToInt32(Console.ReadLine());
            while (nota>10)
            {
                Console.WriteLine("Ingrese nuevamente la nota: ");
                nota = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Su nota es: " + nota);
            Console.ReadKey();
        }
    }
}

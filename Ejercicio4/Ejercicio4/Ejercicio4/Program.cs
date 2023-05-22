using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa en el cual se ingrese un numero y mientras ese numero sea mayor de 10, se pedira el numero de nuevo.
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num>10)
            {
                Console.WriteLine("Ingrese el numero de nuevo: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Su numero es " + num);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que calcule cuántos dígitos tiene un número entero positivo. (pista: se puede hacer dividiendo varias veces entre 10).
            int num;
            int aux;
            int contador = 0;
            do
            {
                Console.WriteLine("Escribir un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                aux = num / 10;
                contador++;
            } while (num > 0);
            Console.WriteLine("Digitos que tiene son ({0})", contador);
            Console.ReadKey();
        }
    }
}

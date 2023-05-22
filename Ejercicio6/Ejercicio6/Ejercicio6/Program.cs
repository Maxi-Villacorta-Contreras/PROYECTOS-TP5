using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que solicite al usuario números decimales mientras que el usuario escriba números mayores al primero que se ingresó. Por ejemplo: si el usuario ingresa como primer número un 3.1, y luego ingresa un 4, el programa debe solicitar un tercer número.El programa continuará solicitando valores sucesivamente mientras los valores ingresados sean mayores que 3.1, caso contrario, el programa finaliza.
            decimal numdecimal;
            decimal num = 0;
            decimal aux;
            int contador = 0;
            Console.WriteLine("Ingrese un numero decimal: ");
            numdecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese un numero entero mayor que el decimal: ");
            num = Convert.ToDecimal(Console.ReadLine());
            do
            {
                contador++;
                Console.WriteLine("Ingrese un numero que esta entre ({0}) ({1})", numdecimal, num);
                aux = Convert.ToDecimal(Console.ReadLine());
            }
            while (aux > numdecimal && aux < num);
            Console.WriteLine("El numero que finalizo el programa({0}), el numero minimo ({1}) y el numero maximo ({2})", aux, numdecimal, num);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que solicite dos números enteros (mínimo y máximo). A continuación, se debe pedir al usuario que ingrese números enteros situados entre el máximo y mínimo.Cada vez que un número se encuentre entre ese intervalo, se sumara uno a una variable.El programa terminará cuando se escriba un número que no pertenezca a ese intervalo, y al finalizar se debe mostrar por pantalla la cantidad de números ingresados dentro del intervalo.
            int numeromax;
            int numeromin;
            int usuario;
            int contador = 0;
            Console.WriteLine("Ingrese un numero minimo: ");
            numeromin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero maximo: ");
            numeromax = Convert.ToInt32(Console.ReadLine());
            do
            {
                contador++;
                Console.WriteLine("Se repetia los numeros que estan entre los numeros minimo ({0}) y maximo ({1})", numeromin, numeromax);
                usuario = Convert.ToInt32(Console.ReadLine());
            }
            while (usuario > numeromin && usuario < numeromax);
            Console.WriteLine("Los numeros intervalos que se muestra en pantalla es ({0}) y que finalizo el usuario ({1}) ", contador, usuario);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dada una secuencia de numeros ingresados por teclado que finaliza con la entrada de un numero negativo, por ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,......,-1; realizar un programa que calcule el promedio de los numeros ingresados.
            int numnegativo = 0;
            int sum = 0;
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese cualquier numero: ");
                numnegativo = Convert.ToInt32(Console.ReadLine());
                sum = sum + numnegativo;
                contador = contador++;
            }
            while ((numnegativo > 0));
            Console.WriteLine("El promedio del numero es: " + sum);
            Console.ReadKey();
        }

    }
}

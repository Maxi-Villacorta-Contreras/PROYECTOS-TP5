using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa en el cual se ingrese un valor limite positivo, y a continuacion solicite numeros al usuario hasta que la suma de los numeros introducidos supere el limite inicial.
            int numpos = 0;
            int totalpos = 0;
            int aux = 0;
            int aux2 = 0;
            int aux3 = 0;
            Console.WriteLine("Ingrese un limite positivo: ");2
            numpos = Convert.ToInt32(Console.ReadLine());
            while(aux<numpos)
            {
                Console.WriteLine("Ingrese un limite positivo: ");
                numpos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero positivo: ");
                aux2 = Convert.ToInt32(Console.ReadLine());
                aux = totalpos + aux2;
            }
            Console.ReadKey();
        }
    }
}

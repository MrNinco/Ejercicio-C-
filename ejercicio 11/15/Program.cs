using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, resultado;
            Console.WriteLine("Escriba un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            resultado = numero1 / 2;
            if (resultado >= 100)
            {
                Console.WriteLine("Su numero es: "+ resultado);
                Console.WriteLine("Su numero es mayor");
            }
            else
            {
                Console.WriteLine("Su numero es: " + resultado);
                Console.WriteLine("Su numero es menor");
            }
            Console.ReadLine();
        }
    }
}

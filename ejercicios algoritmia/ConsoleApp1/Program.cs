using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, resultado;
            Console.WriteLine("Escribe el primer valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine("La suma es: "+ resultado);
            Console.ReadLine();

        }
    }
}

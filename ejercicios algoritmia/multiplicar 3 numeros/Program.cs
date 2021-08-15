using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicar_3_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, resultado;
            Console.WriteLine("Escriba el primer valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el tercer valor: ");
            valor3 = int.Parse(Console.ReadLine());
            resultado = valor1 * valor2 * valor3;
            Console.WriteLine("la multiplicacion es: "+ resultado);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_cuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, resultado;
            Console.Write("Escriba el numero de un lado del cuadrado: ");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero del otro lado del cuadrado: ");
            lado2 = int.Parse(Console.ReadLine());
            resultado = lado1 * lado2;
            Console.WriteLine("EL area del cuadrado es: "+ resultado);
            Console.ReadLine();
        }
    }
}

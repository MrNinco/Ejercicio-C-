using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porcentaje_x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int porcentaje1 = 30;
            int porcentaje2 = 60;
            int porcentaje3 = 90;
            int numero, resultado;
            Console.WriteLine("Escriba el numero para el 30%: ");
            numero = int.Parse(Console.ReadLine());
            resultado = porcentaje1 * numero / 100;
            Console.WriteLine("Resultado de 30%: " + resultado);
            Console.ReadLine();
            Console.WriteLine("Escriba el numero para el 60%: ");
            numero = int.Parse(Console.ReadLine());
            resultado = porcentaje2 * numero / 100;
            Console.WriteLine("Resultado de 60%: " + resultado);
            Console.ReadLine();
            Console.WriteLine("Escriba el numero para el 90%: ");
            numero = int.Parse(Console.ReadLine());
            resultado = porcentaje3 * numero / 100;
            Console.WriteLine("Resultado de 90%: " + resultado);
            Console.ReadLine();
        }
    }
}

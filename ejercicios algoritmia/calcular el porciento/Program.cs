using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_el_porciento
{
    class Program
    {
        static void Main(string[] args)
        {
            int porcentaje = 20;
            int divisor = 100;
            int resultado, numero;
            Console.Write("escriba el numero: ");
            numero = int.Parse(Console.ReadLine());

            resultado = porcentaje * numero / divisor;
            Console.WriteLine("El porcentaje es: "+ resultado);
            Console.ReadLine();
            
        }
    }
}

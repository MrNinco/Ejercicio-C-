using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, Tn, promedio;
            Console.WriteLine("Escriba el primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el tercero numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el cuarto numero: ");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el quinto numero: ");
            n5 = Convert.ToInt32(Console.ReadLine());
            Tn = n1 + n2 + n3 + n4 + n5;
            promedio = Tn / 5;
            Console.WriteLine("Total de numeros es: {0}", Tn);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadLine();

        }
    }
}

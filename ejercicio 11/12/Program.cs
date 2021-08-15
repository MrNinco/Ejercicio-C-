using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero1;
            Console.WriteLine("Escriba un numero: ");
            Numero1 = int.Parse(Console.ReadLine());
            if (Numero1>=20)
            {
                Console.WriteLine("Su numero es: " + Numero1);
                Console.WriteLine("Su numero es positivo");
            }
            else
            {
                Console.WriteLine("Su numero es: " + Numero1);
                Console.WriteLine("Su numero es negativo");
            }
            Console.ReadLine();
        }
    }
}

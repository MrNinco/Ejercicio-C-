using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Escriba el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            if (numero1>numero2)
            {
                Console.WriteLine("Su numero es: " + numero1);
                Console.WriteLine("Su numero es mayor");
            }
            else
            {
                Console.WriteLine("Su numero es: " + numero1);
                Console.WriteLine("Su numero es menor");
            }
            Console.ReadLine();
        }
    }
}

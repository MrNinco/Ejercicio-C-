using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio;
            Console.WriteLine("Escriba el precio: ");
            precio = int.Parse(Console.ReadLine());
            if (precio<=10000)
            {
                Console.WriteLine("Usted tiene el 10% de descuento");
            }
            Console.WriteLine("Escriba el precio: ");
            precio = int.Parse(Console.ReadLine());
            if (precio>=50000)
            {
                Console.WriteLine("Usted tiene el 30% de descuento");
            }
            Console.WriteLine("Escriba el precio: ");
            precio = int.Parse(Console.ReadLine());
            if (precio>50000)
            {
                Console.WriteLine("Usted tiene el 50% de descuento");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_unitario, cantidad, total, total_descuento, total_descuento15;
            Console.WriteLine("Escriba el valor unitario: ");
            valor_unitario = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
            total = valor_unitario * cantidad;
            Console.WriteLine("Su total sin descuento es: {0}", total);
            total_descuento = total * 35 / 100;
            Console.WriteLine("Su total sin descuento es: " + total_descuento);
            total_descuento15 = total * 15 / 100;
            Console.WriteLine("Su total sin descuento es: " + total_descuento15);
            if (total>=20000)
            {
                Console.WriteLine("Su descuento es de 35%");
                Console.WriteLine("Su total con descuento es: " + total_descuento);
            }
            else
            {
                Console.WriteLine("Su descuento es del 15%");
                Console.WriteLine("su total con descuento es: " + total_descuento15);
            }
        }
    }
}

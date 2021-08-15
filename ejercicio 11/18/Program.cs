using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor_compra = 100000, cant_productos = 10, total;
            Console.WriteLine("Descuento del 20%");
            Console.WriteLine("Valor compra: "+ valor_compra);
            Console.WriteLine("cantidad productos: "+cant_productos);
            total = valor_compra * 20 / 100;
            Console.WriteLine("Total de la compra: " + total);
            Console.ReadLine();
        }
    }
}

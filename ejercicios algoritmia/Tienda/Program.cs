using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantiPro, valorpro, total, valorIVA, totalconIVA;
            int iva = 16;
            Console.WriteLine("Escriba la cantidad de productos: ");
            cantiPro = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor del producto: ");
            valorpro = int.Parse(Console.ReadLine());
            total = cantiPro * valorpro;
            valorIVA = total * iva / 100;
            totalconIVA = valorIVA + total;
            Console.WriteLine("Total sin IVA: {0}", total);
            Console.WriteLine("Valor IVA: {0}", valorIVA);
            Console.WriteLine("Total con IVA: {0}", totalconIVA);
            Console.ReadLine();
        }
    }
}

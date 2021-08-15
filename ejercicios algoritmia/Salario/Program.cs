using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int salarioH= 3000;
            int horaslab = 12;
            int saludpen = 25;
            int total, descuento, salariototal;
            Console.WriteLine("Escriba las horas trabajadas: ");
            horaslab = int.Parse(Console.ReadLine());
            total = horaslab * salarioH;
            descuento = total * saludpen / 100;
            salariototal = total - descuento;
            Console.WriteLine("Total sin descuentos: {0}", total);
            Console.WriteLine("Descuento del 25%: {0} ", descuento);
            Console.WriteLine("Total del sueldo: {0}", salariototal);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Escriba una de las siguientes opciones: ");
            Console.WriteLine("1. Calcular distancia");
            Console.WriteLine("2. Calcular Velocidad");
            Console.WriteLine("3. Calcular tiempo");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: Console.WriteLine("Calcular distancia"); break;
                case 2: Console.WriteLine("2. Calcular Velocidad"); break;
                case 3: Console.WriteLine("3. Calcular tiempo"); break;
                default: Console.WriteLine("Usted no elijio nada"); break;
            }
            Console.ReadKey();
        }
    }
}

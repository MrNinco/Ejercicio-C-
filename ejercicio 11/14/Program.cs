using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int grado;
            Console.WriteLine("Escriba el grado del estudiante: ");
            grado = int.Parse(Console.ReadLine());
            if (grado<=6)
            {
                Console.WriteLine("Su grado es: " + grado);
                Console.WriteLine("Si recibe refrigerio: ");
            }
            else
            {
                Console.WriteLine("Su grado es: "+ grado);
                Console.WriteLine("No recibe refrigerio ");
            }
            Console.ReadLine();
        }
    }
}

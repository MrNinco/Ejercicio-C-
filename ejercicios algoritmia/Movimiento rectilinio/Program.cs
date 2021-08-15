using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimiento_rectilinio
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidad, tiempo, resultado;
            Console.WriteLine("Escirba la velocidad: ");
            velocidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el tiempo: ");
            tiempo = int.Parse(Console.ReadLine());
            resultado = velocidad * tiempo;
            Console.WriteLine("La distacia recorrida es: " + resultado);
            Console.ReadLine();

        }
    }
}

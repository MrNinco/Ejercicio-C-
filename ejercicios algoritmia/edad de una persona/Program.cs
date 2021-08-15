using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edad_de_una_persona
{
    class Program
    {
        static void Main(string[] args)
        {
            int añonacimiento, añoactual, edad;
            Console.WriteLine("Escriba el año actual: ");
            añoactual = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el año de nacimiento: ");
            añonacimiento = int.Parse(Console.ReadLine());
            edad = añoactual - añonacimiento;
            Console.Write("La edad es: " + edad);
            Console.ReadLine();
        }
    }
}

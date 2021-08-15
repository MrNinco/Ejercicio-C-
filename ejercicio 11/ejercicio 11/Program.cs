using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Año_Nacimiento, Año_Actual = 2021, Edad;
            Console.WriteLine("Escriba el año de nacimiento: ");
            Año_Nacimiento = int.Parse(Console.ReadLine());
            Edad = Año_Actual - Año_Nacimiento;
            if (Edad >= 18)
            {
                Console.WriteLine("Su edad es: " + Edad);
                Console.WriteLine("Es usted mayor de edad: ");
            }

            else
            {
                Console.WriteLine("Su edad es: " + Edad);
                Console.WriteLine("Es usted menor de edad: ");
            }
            Console.ReadLine();
        }
    }
}

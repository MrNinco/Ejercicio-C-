using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, estatura, peso;
            Console.WriteLine("Escriba su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad>=18)
            {
                Console.WriteLine("Usted es mayor de edad ");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad ");
            }
            Console.WriteLine("Escriba su estatura:");
            estatura = int.Parse(Console.ReadLine());
            if (estatura>=180)
            {
                Console.WriteLine("Su estatura es mayor a 180cm ");
            }
            else
            {
                Console.WriteLine("su estatura es menor a 180cm ");
            }
            Console.WriteLine("Escriba su peso: ");
            peso = int.Parse(Console.ReadLine());
            if (peso >= 80)
            {
                Console.WriteLine("Su peso mayor a 80kg ");
            }
            else
            {
                Console.WriteLine("Su peso es menor a 80kg ");
            }
            Console.ReadLine();
        }
    }
}

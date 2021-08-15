using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            string aprobo;
            int edad, nota1, nota2, nota3, definitiva, Año_Nacimiento, Año_Actual = 2021, Edad;
            Console.WriteLine("Digite su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad ");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad ");
            }
            Console.WriteLine("Escriba si aprobo o no la materia: ");
            aprobo = Console.ReadLine();
            switch (aprobo)
            {
                case "si": Console.WriteLine("Felicitaciones usted a aprobado "); break;
                case "no": Console.WriteLine("Usted no ha aprobado "); break;
                default: Console.WriteLine("Eso no es una respued de si o no "); break;
            }
            Console.WriteLine("Escriba la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la tercera nota: ");
            nota3 = int.Parse(Console.ReadLine());
            definitiva = nota1 + nota2 + nota3 / 3;
            if (definitiva <= 50)
            {
                Console.WriteLine("Su definitiva es: " + definitiva);
                Console.WriteLine("Usted ha reprobado ");
            }
            else
            {
                Console.WriteLine("Su definitiva es: " + definitiva);
                Console.WriteLine("Usted ha aprobado ");
            }
            Console.WriteLine("Escriba el año de nacimiento: ");
            Año_Nacimiento = int.Parse(Console.ReadLine());
            Edad = Año_Actual - Año_Nacimiento;
            if (Edad >= 18)
            {
                Console.WriteLine("Su edad es: " + Edad);
                Console.WriteLine("Es usted mayor de edad ");
            }

            else
            {
                Console.WriteLine("Su edad es: " + Edad);
                Console.WriteLine("Es usted menor de edad ");
            }
            Console.ReadLine();
        }
    }
}

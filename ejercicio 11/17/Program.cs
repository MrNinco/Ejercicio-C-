using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, nombre_estudiante, materia, nota1, nota2, nota3,  definitiva;
            Console.WriteLine("Escriba el codigo del estudiante: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el nombre del estudiante: ");
            nombre_estudiante = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la materia: ");
            materia = int.Parse(Console.ReadLine());
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
                Console.WriteLine("Usted ha aprobado ");
            }
                else
            {
                Console.WriteLine("Su definitiva es: " + definitiva);
                Console.WriteLine("Usted ha reprobado ");
            }
            Console.ReadLine();


        }
    }
}

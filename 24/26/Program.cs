using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un numero del 1 al 6: ");
            numero = int.Parse (Console.ReadLine());
            switch (numero)
            {
                case 1: Console.WriteLine("Su numero es impar"); break;
                case 2: Console.WriteLine("Su numero es par"); break;
                case 3: Console.WriteLine("Su numero es impar"); break;
                case 4: Console.WriteLine("Su numero es par"); break;
                case 5: Console.WriteLine("Su numero es impar");break;
                case 6: Console.WriteLine("Su numero es par"); break;
                default:Console.WriteLine("Su numero no esta en el rango "); break;
            }
            switch (numero)
            {
                case -1: Console.WriteLine("Su numero es negativo"); break;
                case -2: Console.WriteLine("Su numero es positivo"); break;
                case -3: Console.WriteLine("Su numero es negativo"); break;
                case -4: Console.WriteLine("Su numero es negativo"); break;
                case -5: Console.WriteLine("Su numero es negativo"); break;
                case -6: Console.WriteLine("Su numero es negativo"); break;
                default: Console.WriteLine("Su numero no esta en el rango "); break;
            }
            Console.ReadKey();
        }
    }
}

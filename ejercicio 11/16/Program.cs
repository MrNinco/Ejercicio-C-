﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, suma, resta;
            int numero2;
            Console.WriteLine("Escriba el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            resta = numero1 - numero2;
            suma = numero2 + numero1;
            if (numero1<=numero2)
            {
                Console.WriteLine("Su resultado es: " + suma);
            }
            else
            {
                Console.WriteLine("Su resultado es: " + resta);
            }
            Console.ReadLine();

        }
    }
}

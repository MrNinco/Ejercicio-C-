using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            string vocal;
            Console.WriteLine("Digita una vocal: ");
            vocal = Console.ReadLine();
            switch(vocal)
            {
                case "A": Console.WriteLine("Haz elegido la vocal A"); break;
                case "E": Console.WriteLine("Haz elegido la vocal E"); break;
                case "I": Console.WriteLine("Haz elegido la vocal I"); break;
                case "O": Console.WriteLine("Haz elegido la vocal O"); break;
                case "U": Console.WriteLine("Haz elegido la vocal U"); break;
                default: Console.WriteLine("Eso no es una vocal "); break;
            }
            Console.ReadKey();
        }
    }
}

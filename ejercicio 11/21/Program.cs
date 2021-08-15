using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Esciba la temperatura: ");
            temp = int.Parse(Console.ReadLine());
            if (temp>35)
            {
                Console.WriteLine("Que dia tan caluroso ");
            }
            else
            {
                Console.WriteLine("Que clima tan delicioso ");
            }
            if (temp<15)
            {
                Console.WriteLine("Que semana tan fria ");
            }
            Console.ReadLine();
        }
    }
}

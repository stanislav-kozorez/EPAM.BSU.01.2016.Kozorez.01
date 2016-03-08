using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logic Pow: {0} ", Task1.Root(3, 1/20.0));
            Console.WriteLine("Math Pow: {0} ", Math.Pow(3, 20));
            Console.ReadKey();
        }
    }
}

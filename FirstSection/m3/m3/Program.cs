using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Num 1 = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Insert Num 2 = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("========");
            Console.WriteLine("Plus  = " + (a+b));
            Console.WriteLine("Tafrigh  = " + (a - b));
            Console.WriteLine("Zarb  = " + (a * b));
            Console.WriteLine("Taghsim  = " + (a / b));
            Console.WriteLine("Mod  = " + ((a + b)/2));
        }
    }
}

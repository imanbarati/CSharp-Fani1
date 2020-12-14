using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Num = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("========");
            Console.WriteLine("Tavan2 = " + (Math.Pow(a, 2)));
        }
    }
}

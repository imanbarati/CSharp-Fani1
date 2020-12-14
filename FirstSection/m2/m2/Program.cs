using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Num = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("========");
            Console.WriteLine("Ghadr = " + (Math.Abs(a)));
        }
    }
}

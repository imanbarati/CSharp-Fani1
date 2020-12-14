using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Shoaa = ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("========");
            Console.WriteLine("Mohit = " + (2*Math.PI*a));
            Console.WriteLine("Masahat = " + (a*Math.Pow(Math.PI,2)));
        }
    }
}

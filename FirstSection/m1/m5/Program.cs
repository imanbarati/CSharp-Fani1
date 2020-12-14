using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0;
            Console.Write("Insert Num = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("========");
            while (a >0)
            {
                a /= 10;
                k++;
            }
            Console.WriteLine("Tedad = " + k);
        }
    }
}

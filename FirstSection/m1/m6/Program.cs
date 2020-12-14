using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m6
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=0,c=1;
            Console.Write("Insert Num = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("========");
            while (a > 0)
            {
                c *= a;
                b+=a;
                a--;
            }
            Console.WriteLine("Sigma = " + b);
            Console.WriteLine("Faktoriel = " + c);
        }
    }
}

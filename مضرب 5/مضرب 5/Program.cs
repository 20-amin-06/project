using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace مضرب_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter first number :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number :");
            b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                Console.WriteLine(":");
                for (int i = a; i < b; i+=5)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine(":");
                for (int i = b; i < a; i += 5)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}

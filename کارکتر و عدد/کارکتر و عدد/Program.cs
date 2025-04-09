using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace کارکتر_و_عدد
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            char f;
            Console.WriteLine("enter first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter character(=,-,*,/):");
            f = char.Parse(Console.ReadLine());
            if (f=='+')
            {
                c = a + b;
                Console.WriteLine("anser=" + c);
            }
            else if (f=='-')
            {
                c = a - b;
                Console.WriteLine("anser=" + c);
            }
            else if (f=='*')
            {
                c = a * b;
                Console.WriteLine("anser=" + c);
            }
            else if (f=='/')
            {
                if (b == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    c = a / b;
                    Console.WriteLine("anser=" + c);
                }
                }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}

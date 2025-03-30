using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace مرتب_کردن_عدد_از_کوچیک_به_بزرگ
{
    class Program
    {
        static void Main(string[] args)
        {//         مرتب کردن سه عدد از کوچیک به بزرگ
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int d;
                d = a;
                a = b;
                b = d;
            }
            if (a > c)
            {
                int d;
                d = a;
                a = c;
                c = d;
            }
            if (b > c)
            {
                int d;
                d = b;
                b = c;
                c = d;
            }
            
            
            Console.WriteLine("{0},{1},{2}",a,b,c);
            Console.ReadKey();
           
        }
    }
}

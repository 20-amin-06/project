using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تست_تساعد_حسابی_سه_عدد
{
    class Program
    {
        static void Main(string[] args)
        {  //         تست تساعد حسابی :
            double a, b, c, d , e;
                Console.WriteLine("enter num1:");
            a = double.Parse(Console.ReadLine());
                Console.WriteLine("enter num2:");
            b = double.Parse(Console.ReadLine());
                Console.WriteLine("enter num3:");
            c = double.Parse(Console.ReadLine());
            d = a - b;
            e = b - c;
            if (d>e||e>d)
            {
                Console.WriteLine("the progression is not arithmetic");
            }
            else
            {
                Console.WriteLine("the progression is arithmetic");
            }
            Console.ReadKey();
        }
    }
}

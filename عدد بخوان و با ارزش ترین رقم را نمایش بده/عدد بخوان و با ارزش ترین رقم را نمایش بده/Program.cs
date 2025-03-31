using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace عدد_بخوان_و_با_ارزش_ترین_رقم_را_نمایش_بده
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter number");
            a = int.Parse(Console.ReadLine());
            if (a>10&a<100)
            {
                a /= 10;
                Console.WriteLine(a);
            }
            if (a>100&a<1000)
            {
                a /= 100;
                Console.WriteLine(a);
            }
            if (a > 1000 & a < 10000)
            {
                a /= 1000;
                Console.WriteLine(a);
            }
            if (a > 10000 & a < 100000)
            {
                a /= 10000;
                Console.WriteLine(a);
            }
            if(a>99999)
            {
                Console.WriteLine("ERROR");
            }
            Console.ReadKey();

        }
    }
}

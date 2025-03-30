using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace محاسبه_سن_تا_اول1404
{
    class Program
    {
        static void Main(string[] args)
        {  //     محاسبه سن تا تاریخ 1404/1/1
            int y, m, d;
            Console.WriteLine("enter year of birth");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter birth month");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter birthday");
            d = int.Parse(Console.ReadLine());
            y = 1404 - y;
            if (m > 1)
            {
                y = y - 1;
                m = (m - 1) - 12;
            }
            else
            {
                m = m - 1;
            }

            if (d > 1)
            {
                m = m - 1;
                d = 30 - (d - 1);
            }
            else
            {
                d = d - 1;
            }
            if (m < 0)
            {
                m = 12 + m;
                y = y - 1;
            }
            Console.WriteLine("your old:");
            Console.WriteLine("{0},{1},{2}", y + "year", m + "month", d + "day");
            Console.ReadKey();
        }
    }
}

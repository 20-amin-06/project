using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace اختلاف_سن
{
    class Program
    {
        static void Main(string[] args)
        {//          محاسبه اختلاف سن دو شخص
            int y, m, d, y1, m1, d1, y2, m2, d2;
            Console.WriteLine("year of older person one");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("month of older person one");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("day of brith older person");
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("year of brith smaller person");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("month of brith smaller person");
            m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("day of brith smaller person");
            d2 = int.Parse(Console.ReadLine());
            y = y2 - y1;
            m = m2 - m1;
            d = d2 - d1;
            if (d<0)
            {
                m--;
                d = d + 30;
            }
            if (m<0)
            {
                y--;
                m = m + 12;
            }
            Console.WriteLine("age difference:");
            Console.WriteLine("{0},{1},{2}", y + "year", m + "month", d + "day");
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        public void dayOfWeeks(String day,String month,String year)
        {
            int d = int.Parse(day);
            int m = int.Parse(month);
            int y = int.Parse(year);
            int y0 = y - (14 - m) / 12;
            Console.WriteLine($"y0 = y - (14 - m) / 12 : {y - (14 - m) / 12}");
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            Console.WriteLine($"y0 + y0 / 4 - y0 / 100 + y0 / 400 :{x}");
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            Console.WriteLine($"m + 12 * ((14 - m) / 12) - 2 :{m0}");
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine($"(d + x + 31 * m0 / 12) % 7 : {d0}");
        }
    }
}

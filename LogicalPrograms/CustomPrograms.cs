using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        public static void temperaturConversion()
        {
            int f = int.Parse(Console.ReadLine());
            double cel = (f - 32) * 5 / 9;
            Console.WriteLine($"Fahrenheit to Celsius : {cel}");
            double fer = (f * 9 / 5) + 32;
            Console.WriteLine($"Celsius to Fahrenheit : {fer}");

        }
    }
}

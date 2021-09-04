using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        public static void Coupons()
        {
            HashSet<int> odd = new HashSet<int>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int rand = new Random().Next(10000, 99999);
                odd.Add(rand);
            }
            foreach (int i in odd)
            {
                Console.WriteLine(i);
            }
        }
    }
}

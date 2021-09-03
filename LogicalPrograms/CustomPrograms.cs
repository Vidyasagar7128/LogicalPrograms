using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        int sum = 0;
        public void fibonacci()
        {
            Console.WriteLine("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                this.sum = this.sum + i;
                Console.WriteLine(this.sum);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        int sum = 0;
        int number = int.Parse(Console.ReadLine());
        public void perfectNumber()
        {
            for (int i = 1; i < this.number; i++)
            {
                if (this.number % i == 0)//1,2,3,4
                {
                    this.sum = this.sum + i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Addition : {this.sum}");
            if(this.number == this.sum)
            {
                Console.WriteLine($"{this.number} : is Perfect Number");
            }
            else
            {
                Console.WriteLine($"{this.number} : is Not Perfect Number");
            }
        }
    }
}

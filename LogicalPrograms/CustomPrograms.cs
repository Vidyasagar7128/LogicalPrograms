using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        int count = 0;
        int number = int.Parse(Console.ReadLine());
        public void primeNumber()
        {
            for (int i = 1; i <= this.number; i++)
            {
                if (this.number % i == 0)
                {
                    this.count = this.count + 1;
                }
            }
            if (this.count == 2)
            {
                Console.WriteLine($"{number} : Number is Prime..");
            }
            else
            {
                Console.WriteLine($"{number} : Number is not Prime..");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CustomPrograms
    {
        int reminder=0;
        int rev = 0;
        int number = int.Parse(Console.ReadLine());
        public void reversNumber()
        {
            while (this.number != 0)
            {
                this.reminder = this.number % 10;
                this.rev = this.rev * 10 + this.reminder;
                this.number = this.number / 10;
            }
            Console.WriteLine($"{this.rev}");
        }
    }
}

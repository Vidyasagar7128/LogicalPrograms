using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            double n = 327;
            double l = 0.00001;
            CustomPrograms customPrograms = new CustomPrograms();
            Console.WriteLine(customPrograms.squareRoot(num1,num2));
        }
    }
}

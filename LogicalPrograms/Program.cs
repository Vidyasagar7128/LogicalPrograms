using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            CustomPrograms customPrograms = new CustomPrograms();
            customPrograms.Watch();
            customPrograms.start();
            customPrograms.elapsedTime();


        }
    }
}

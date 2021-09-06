using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monthly Payment : ");
            CustomPrograms.monthlyPayment(args[0],args[1],args[2]);
        }
    }
}

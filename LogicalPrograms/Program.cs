using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            CustomPrograms obj = new CustomPrograms();
            obj.dayOfWeeks(args[0],args[1],args[2]);
        }
    }
}

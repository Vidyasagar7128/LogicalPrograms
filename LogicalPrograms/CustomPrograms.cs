using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace LogicalPrograms
{
	class CustomPrograms
	{
       public static void decimalToBinary()
        {
            int var = -1, rem, binary = 0, i = 1;
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {  
                rem = num % 2;
                num = num / 2;
                binary = binary + (rem * i);
                i = i * 10;
                var++;
                Console.WriteLine(Math.Pow(2, var));
            }
            Console.WriteLine(binary);
        }
    }
}

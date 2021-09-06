using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace LogicalPrograms
{
	class CustomPrograms
	{
       public static void monthlyPayment(String principal,String rate,String year)
       {
            double P = double.Parse(principal);
            double R = double.Parse(rate);
            int Y = int.Parse(year);
            int n = 12*Y;
            double r = R / (12 * 100);
            double payment = P * r / 1 - Math.Pow((1+r),-n);
            Console.WriteLine(payment);
       }
    }
}

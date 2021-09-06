using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace LogicalPrograms
{
    class CustomPrograms
    {
       public double squareRoot(double n, double l)
        {
            double x = n;
            double root;
            int count = 0;
            while (true)
            {
                count++;

                root = 0.5 * (x + (n / x));

                if (Math.Abs(root - x) < l)
                    break;
                x = root;
            }
            return root;
        }
    }
}

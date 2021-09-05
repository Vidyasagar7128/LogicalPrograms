using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace LogicalPrograms
{
    class CustomPrograms
    {
        public DateTime startTimer;
        public DateTime stopTimer;
        public void Watch()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(i + " ");
            }
            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            Console.WriteLine("total time elapsed(in millisec) is: " + time);
        }
        public void start()
        {
            startTimer = DateTime.Now;
            Console.WriteLine("start time is: " + startTimer);
        }
        public void elapsedTime()
        {
            stopTimer = DateTime.Now;
            Console.WriteLine("stop time is: " + stopTimer);
        }
    }
}

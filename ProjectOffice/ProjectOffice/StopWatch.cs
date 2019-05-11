using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectOffice
{
    public static class StopWatch
    {
        public static Stopwatch watch = Stopwatch.StartNew();
        public static long elapsedMS = watch.ElapsedMilliseconds;

        public static void StopTheWatch()
        {
            watch.Stop();
            Console.WriteLine("\nRunning time: {0} ms", elapsedMS);
        }
    }
}

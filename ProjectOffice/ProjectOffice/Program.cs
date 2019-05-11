using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ProjectOffice
{
    class Program
    {
        
        static void Main()
        {
            var watch = Stopwatch.StartNew();
            var office = new Office();
            var export = new Export();
            



            export.ExportOutToTxt(office);



            Console.Write("Press any key to exit . . . ");

            watch.Stop();
            var elapsedMS = watch.ElapsedMilliseconds;

            Console.WriteLine("\nRunning time: {0} ms", elapsedMS);
            Console.ReadKey();
        }
    }
} 
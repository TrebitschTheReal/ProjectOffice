using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectOffice
{
    class Program
    {
        
        static void Main()
        {
            var office = new Office();
            var export = new Export();

            export.ExportOutToTxt(office);


            Console.Write("Press any key to exit . . . ");
            Console.ReadKey();
        }
    }
} 
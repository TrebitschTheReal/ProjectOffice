using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectOffice
{
    class Export
    {
        private static string accesPath = "E:\\maszekolgatunk\\employees.txt";

        public void ExportOutToTxt(Office office)
        {
            StreamWriter sw = new StreamWriter(accesPath);

            for (int i = 0; i < office.Employees.GetLength(0); i++)
            {
                sw.WriteLine(office.Employees[i].Name);
                sw.WriteLine(office.Employees[i].Position);
                sw.WriteLine(office.Employees[i].Wage + " Ft.");
                sw.WriteLine(office.Employees[i].Productivity);
                sw.WriteLine(office.Employees[i].MonitorType);
                sw.WriteLine("==============================");
                sw.WriteLine("\n");
            }
            sw.Close();
            Console.WriteLine("Exporting done to {0}", accesPath);
        }
    }
} 

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
        StreamWriter sw = new StreamWriter(@"E:\maszekolgatunk\employees.txt");
        public void ExportOutToTxt(Office office)
        {
            for (int i = 0; i < office.Employees.GetLength(0); i++)
            {
                sw.WriteLine(office.Employees[i].Name);
                sw.WriteLine(office.Employees[i].Post);
                sw.WriteLine(office.Employees[i].Wage + " Ft.");
                sw.WriteLine(office.Employees[i].Productivity);
                sw.WriteLine(office.Employees[i].MonitorType);
                sw.WriteLine("==============================");
                sw.WriteLine("\n");
            }
            sw.Close();
            Console.WriteLine("Done!");
        }
    }
} 

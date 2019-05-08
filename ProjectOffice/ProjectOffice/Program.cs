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
            Console.WriteLine(office.OfficeBox[0].Name);
            Console.WriteLine(office.OfficeBox[0].Post);
            Console.WriteLine(office.OfficeBox[0].MonitorType);
            Console.WriteLine("\n");
            Console.WriteLine(office.OfficeBox[1].Name);
            Console.WriteLine(office.OfficeBox[1].Post);
            Console.WriteLine(office.OfficeBox[1].MonitorType);







            //var sw = new StreamWriter(@"E:\maszekolgatunk\employees.txt");
            //for (int i = 0; i < office.Employees.GetLength(0); i++)
            //{
            //    for (int j = 0; j < office.Employees.GetLength(1); j++)
            //    {
            //        sw.WriteLine(office.Employees[i, j].Name);
            //        sw.WriteLine(office.Employees[i, j].Post);
            //        sw.WriteLine(office.Employees[i, j].Wage + " Ft.");
            //        sw.WriteLine(office.Employees[i, j].Productivity);
            //        sw.WriteLine("\n");
            //    }
            //}
            //sw.Close();
            //Console.WriteLine("Done!");
            //Console.ReadKey();

            Console.ReadKey();
        }
    }
}
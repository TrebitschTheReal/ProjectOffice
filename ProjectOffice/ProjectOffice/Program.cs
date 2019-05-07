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
            var office = new OfficeBox();

            var sw = new StreamWriter(@"E:\maszekolgatunk\employees.txt");

            for (int i = 0; i < office.Employees.GetLength(0); i++)
            {
                for (int j = 0; j < office.Employees.GetLength(1); j++)
                {
                    sw.WriteLine(office.Employees[i, j].Name);
                    sw.WriteLine(office.Employees[i, j].Post);
                    sw.WriteLine(office.Employees[i, j].Wage + " Ft.");
                    sw.WriteLine(office.Employees[i, j].Productivity);
                    sw.WriteLine("\n");
                }
            }

            sw.Close();

            Console.WriteLine("Done!");
            Console.ReadKey();

        }
    }
}

/*
Tömb mérete: 8x10

Ember(neve, beosztása, teljesítménye, bérezése)
Számítógép konfig(monitor gyártója és felbontása, processzor típusa és "ereje", memória típusa és "ereje")

Employee.cs - > paraméterből kapjon értéket. A paraméter legyen egy változó ami véletlenszerűen generálja a paramétert így elég egy példányból is cucc
PC.cs ->szintén zenészt

OfficeBox.cs

OfficeBox -> példányosítani egy pc és egy employee-t
*/ 

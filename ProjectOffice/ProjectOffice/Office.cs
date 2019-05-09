using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Office
    {
        private Employee[] employees = new Employee[80];
        private Random r = new Random();

        public Office()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                int employeeSex = r.Next(1, 3);
                string employeName = GenerateName(employeeSex);
                string post = GeneratePost();
                int wage = GenerateWage();
                string monitor = GenerateMonitorType();
                employees[i] = new Employee(monitor, employeeSex, employeName, post, wage);
            }
        }

        public Employee[] Employees
        {
            get { return employees; }
        }

        protected string GenerateName(int employeeSex)
        {
            string choosedName = "";

            string[] maleNames = new string[7] { "Józsi", "Feri", "Péter", "Laci", "Béla", "János", "Pista" };
            string[] femaleNames = new string[7] { "Izabella", "Niki", "Viki", "Margit", "Rozália", "Agónia", "Begónia" };

            if (employeeSex == 1)
            {
                choosedName = maleNames[r.Next(0, maleNames.Length)];
                return choosedName;
            }
            choosedName = femaleNames[r.Next(0, femaleNames.Length)];
            return choosedName;
        }
        protected string GeneratePost()
        {
            string choosedPost = "";

            string[] posts = new string[5] { "junior software developer", "senior software developer", "team lead", "tester", "helpdesk" };

            choosedPost = posts[r.Next(0, 5)];

            return choosedPost;
        }
        protected int GenerateWage()
        {
            int wage = r.Next(200000, 800000);
            return wage;
        }
        private string GenerateMonitorType()
        {
            string choosedMonitor = "";
            string[] monitorTypes = new string[4] { "Benq", "Asus", "Samsung", "Philips" };
            choosedMonitor = monitorTypes[r.Next(0, monitorTypes.Length)];
            return choosedMonitor;
        }

    }
}

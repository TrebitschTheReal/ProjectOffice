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
                string post = GeneratePosition();
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
            string[] maleNames = new string[11] { "József", "Ferenc", "Péter", "László", "Béla", "János", "István", "Sándor", "Aladár", "Dénes", "Géza" };
            string[] femaleNames = new string[11] { "Izabella", "Nikolett", "Viktória", "Margit", "Rozália", "Agónia", "Begónia", "Henrietta", "Petra", "Franciska", "Bernadett" };

            string choosedName = "";
            char firstName = femaleNames[r.Next(0, femaleNames.Length)].ToCharArray()[0];
            string lastName = "";

            if (employeeSex == 1)
            {
                lastName = maleNames[r.Next(0, maleNames.Length)];
                choosedName = firstName + ". " + lastName;
                return choosedName;
            }
            else
            {
                lastName = femaleNames[r.Next(0, maleNames.Length)];
                choosedName = firstName + ". " + lastName;
                return choosedName;
            }

        }
        protected string GeneratePosition()
        {
            string choosedPost = "";

            string[] positions = new string[8] { "Junior software developer", "Senior software developer", "Team lead", "Tester", "Help desk technician", "IT Support Technician", "Network administrator", "HR management" };

            choosedPost = positions[r.Next(0, 5)];

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
            string[] monitorTypes = new string[6] { "Benq", "Asus", "Samsung", "Philips", "LG", "Acer" };
            choosedMonitor = monitorTypes[r.Next(0, monitorTypes.Length)];
            return choosedMonitor;
        }

    }
} 

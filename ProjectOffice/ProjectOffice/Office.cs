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
        private string[] positions = new string[8] { "Tester", "Help desk technician", "IT support technician", "HR management", "Network administrator", "Junior software developer", "Senior software developer", "Team lead" };

        public Office()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                int employeeSex = r.Next(1, 3);
                string employeName = GenerateName(employeeSex);
                string position = GeneratePosition();
                int wage = GenerateWage(position);
                string monitor = GenerateMonitorType();
                employees[i] = new Employee(monitor, employeeSex, employeName, position, wage);
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
            choosedPost = positions[r.Next(0, positions.Length)];



            return choosedPost;
        }
        protected int GenerateWage(string position)
        {
            double baseWage = 130000;
            double moneyMultiplier = 1;
            double moneyMultiplierRate = 0;
            int wage = 0;

            foreach (string element in positions)
            {
                moneyMultiplierRate += 0.4;

                if(element == position)
                {
                    moneyMultiplier += moneyMultiplierRate;
                }
            }

            baseWage *= moneyMultiplier;

            wage = (int)baseWage;

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

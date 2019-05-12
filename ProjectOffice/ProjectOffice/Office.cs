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

        public Office()
        {
            GenerateEmployees();
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
            char firstName = femaleNames[StaticRandom.Instance.Next(0, femaleNames.Length)].ToCharArray()[0];
            string lastName = "";

            if (employeeSex == 1)
            {
                lastName = maleNames[StaticRandom.Instance.Next(0, maleNames.Length)];
                choosedName = firstName + ". " + lastName;
                return choosedName;
            }
            else
            {
                lastName = femaleNames[StaticRandom.Instance.Next(0, maleNames.Length)];
                choosedName = firstName + ". " + lastName;
                return choosedName;
            }

        }
        private string GenerateMonitorType()
        {
            string choosedMonitor = "";
            string[] monitorTypes = new string[6] { "Benq", "Asus", "Samsung", "Philips", "LG", "Acer" };
            choosedMonitor = monitorTypes[StaticRandom.Instance.Next(0, monitorTypes.Length)];
            return choosedMonitor;
        }
        private bool IsEnoughOfLeaders()
        {
            byte leaderCnt = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    return false;
                }
                else if (employees[i].Position == "Team lead")
                {
                    leaderCnt++;
                    if (leaderCnt == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void GenerateEmployees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                int employeeSex = StaticRandom.Instance.Next(1, 3);
                string employeName = GenerateName(employeeSex);
                Positions pos = new Positions();
                string position = pos.GeneratePosition();
                if (IsEnoughOfLeaders() == true)
                {
                    position = pos.GeneratePositionWithoutLeader();
                }
                int wage = pos.GenerateWage();
                string monitor = GenerateMonitorType();
                employees[i] = new Employee(monitor, employeeSex, employeName, position, wage);
            }
        }

    }
} 

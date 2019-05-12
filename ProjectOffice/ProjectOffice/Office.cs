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
                Names names = new Names();
                Positions position = new Positions(IsEnoughOfLeaders());
                PC pc = new PC();
                employees[i] = new Employee(pc.ChoosedMonitorType, names.EmployeeSex, names.ChoosedName, position.Position, position.Wage);
            }
        }

    }
} 

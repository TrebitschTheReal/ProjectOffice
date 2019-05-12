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
        private bool productivityMultiplier = false;

        public Office()
        {
            GenerateEmployees();
            this.productivityMultiplier = GenerateProductivity();
            FillProductivityRateToEmployees();
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
                employees[i] = new Employee(names.EmployeeSex, names.ChoosedName, position.Position, position.Wage, productivityMultiplier, pc.MonitorType, pc.ProcessorType, pc.ProcessorPerformance);

            }
        }
        private bool GenerateProductivity()
        {
            for (int i = 1; i <= employees.Length; i++)
            {
                if (employees[i].EmployeeSex == 1 && employees[i - 1].EmployeeSex == 2)
                {
                    return true;
                }
                else if (employees[i].EmployeeSex == 2 && employees[i - 1].EmployeeSex == 1)
                {
                    return true;
                }
            }
            return false;

        }
        private void FillProductivityRateToEmployees()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].ProductivityMultiplier = productivityMultiplier;
                employees[i].Productivity = 2;
            }
        }

    }
} 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Employee
    {
        private string employeeName = "";
        private int employeeSex = 0;
        private string position = "";
        private int wage = 0;
        private string wageInString = "";
        private double productivity = 0.0;

        private string monitorType = "";
        private int monitorResolution = 0;
        private string processorType = "";
        private double processorPerformance = 0.0;
        private string ramType = "";
        private double ramPerformance = 0.0;

        public Employee(string monitorType, int employeeSex, string employeeName, string post, int wage)
        {
            this.employeeSex = employeeSex;
            this.employeeName = employeeName;
            this.position = post;
            this.wage = wage;
            this.wageInString = WageToString(wage);
            this.monitorType = monitorType;
            this.productivity = 100 - (StaticRandom.Instance.Next(0,11) + (wage / 20000)/2);
        }
        public string MonitorType
        {
            get { return monitorType; }
        }
        public string Name
        {
            get { return employeeName; }
        }
        public string Position
        {
            get { return position; }
        }
        public int Wage
        {
            get { return wage; }
        }
        public string WageInString
        {
            get { return wageInString; }
        }
        public double Productivity
        {
            get { return productivity; }
        }

        private string WageToString(int wage)
        {
            string wageInString = wage.ToString();

            if (wageInString.Length == 6)
            {
               wageInString = wageInString.Insert(3, ".");
            }
            else if(wageInString.Length > 6)
            {
               wageInString = wageInString.Insert(4, ".");
            }

            return wageInString;
        }

    }
}

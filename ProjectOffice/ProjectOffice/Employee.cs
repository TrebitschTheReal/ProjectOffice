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
        private byte productivity = 0;
        private bool productivityMultiplier = false;

        private string monitorType = "";
        private int monitorResolution = 0;
        private string processorType = "";
        private int processorPerformance = 0;
        private string ramType = "";
        private double ramPerformance = 0.0;

        public Employee(int employeeSex, string employeeName, string post, int wage, bool productivityMultiplier, string monitorType, string processorType, int processorPerformance)
        {
            this.employeeSex = employeeSex;
            this.employeeName = employeeName;
            this.position = post;
            this.wage = wage;
            this.productivity = CalculateProductivity();
            this.wageInString = WageToString(wage);
            this.monitorType = monitorType;
            this.processorType = processorType;
            this.processorPerformance = processorPerformance;
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
        public byte Productivity
        {
            get { return productivity; }
            set { if(value==2) DoCalculateProductivity(); }
        }
        public bool ProductivityMultiplier
        {
            get { return productivityMultiplier; }
            set { value = productivityMultiplier; }

        }
        public string ProcessorType
        {
            get { return processorType; }
        }
        public int ProcessorPerformance
        {
            get { return processorPerformance; }
        }
        public int EmployeeSex
        {
            get { return employeeSex; }
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
        private byte CalculateProductivity()
        {
            byte productivity = Convert.ToByte(StaticRandom.Instance.Next(0, 101));
            if (productivityMultiplier == true)
            {
                return productivity = 100;
            }
            else
            {
                return productivity;
            }


        }
        private void DoCalculateProductivity()
        {
            if (productivityMultiplier == true)
            {
                productivity = 100;
            }
        }

    }
}

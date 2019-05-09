using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Employee
    {
        private static Random r = new Random();
        private string employeeName = "";
        private int employeeSex = 0;
        private string position = "";
        private int wage = 0;
        private double productivity = 0.0;

        private string monitorType = "";
        private int monitorResolution = 0;
        private string processorType = "";
        private double processorPerformance = 0.0;
        private string ramType = "";
        private double ramPerformance = 0.0;

        public string MonitorType
        {
            get { return monitorType; }
        }

        public Employee(string monitorType, int employeeSex, string employeeName, string post, int wage)
        {
            this.monitorType = monitorType;
            this.employeeSex = employeeSex;
            this.employeeName = employeeName;
            this.position = post;
            this.wage = wage;
            this.productivity = 100 - (r.Next(0,11) + (wage / 20000)/2);
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
        public double Productivity
        {
            get { return productivity; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Employee : PC
    {
        private string employeeName = "";
        private int employeeSex = 0;
        private string post = "";
        private int wage = 0;
        private double productivity = 0.0;

        public Employee(int employeeSex, string employeeName, string post, int wage)
        {
            this.employeeSex = employeeSex;
            this.employeeName = employeeName;
            this.post = post;
            this.wage = wage;
            this.productivity = wage / 18;
        }
        public string Name
        {
            get { return employeeName; }
        }
        public string Post
        {
            get { return post; }
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

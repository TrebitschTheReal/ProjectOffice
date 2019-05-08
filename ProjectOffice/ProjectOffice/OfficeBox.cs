using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class OfficeBox : Employee
    {
        protected Employee worker;

        protected OfficeBox()
        {
            int employeeSex = r.Next(1, 3);
            string employeName = GenerateName(employeeSex);
            string post = GeneratePost();
            int wage = GenerateWage();
            this.worker = new Employee(employeeSex, employeName, post, wage);
        }

        public Employee Worker
        {
            get { return worker; }
        }

    }
}

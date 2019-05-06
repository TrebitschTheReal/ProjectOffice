using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class OfficeBox
    {
        Employee employee = new Employee();

        public OfficeBox[] Employees
        {
            get
            {
                return new Employee[5] {employee, employee, employee, employee, employee};
            }
        }


    }
}

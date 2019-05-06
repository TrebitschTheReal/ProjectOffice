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

        public Employee[,] Employees
        {
            get
            {
                return new Employee[4, 2] { { employee, employee }, { employee, employee }, { employee, employee }, { employee, employee } };
            }
        }
    }
}

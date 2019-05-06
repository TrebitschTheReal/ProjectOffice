using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class OfficeBox
    {
        //Employee employee = new Employee();

        public Employee[,] Employees
        {
            get
            {
                return GenerateEmployees();
            }
        }

        private Employee[,] GenerateEmployees()
        {
            var crew = new Employee[8,10];

            for (int i = 0; i < crew.GetLength(0); i++)
            {
                for (int j = 0; j < crew.GetLength(1); j++)
                {
                    var worker = new Employee();
                    crew[i, j] = worker;
                }
            }

            return crew;
        }
    }
}

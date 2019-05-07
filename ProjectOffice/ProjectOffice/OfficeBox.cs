using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class OfficeBox
    {
        Random r = new Random();
        private Employee[,] AllWorkers;

        public Employee[,] Employees
        {
            get
            {
                return GenerateEmployees();
            }
        }

        private Employee[,] GenerateEmployees()
        {
            int employeeSex = r.Next(1, 3);
            string employeName = GenerateName(employeeSex);
            string post = GeneratePost();
            int wage = GenerateWage();

            var crew = new Employee[8,10];

            for (int i = 0; i < crew.GetLength(0); i++)
            {
                for (int j = 0; j < crew.GetLength(1); j++)
                {
                    var worker = new Employee(employeeSex, employeName, post, wage);
                    crew[i, j] = worker;
                }
            }

            return crew;
        }
        private string GenerateName(int employeeSex)
        {
            string choosedName = "";

            string[] maleNames = new string[7] { "Józsi", "Feri", "Péter", "Laci", "Béla", "János", "Pista" };
            string[] femaleNames = new string[7] { "Izabella", "Niki", "Viki", "Margit", "Rozália", "Agónia", "Begónia" };

            if (employeeSex == 1)
            {
                choosedName = maleNames[r.Next(0, maleNames.Length)];
                return choosedName;
            }
            choosedName = femaleNames[r.Next(0, femaleNames.Length)];
            return choosedName;
        }
        private string GeneratePost()
        {
            string choosedPost = "";

            string[] posts = new string[5] { "junior software developer", "senior software developer", "team lead", "tester", "helpdesk" };

            choosedPost = posts[r.Next(0, 5)];

            return choosedPost;
        }
        private int GenerateWage()
        {
            int wage = r.Next(200000, 800000);
            return wage;
        }
    }
} 

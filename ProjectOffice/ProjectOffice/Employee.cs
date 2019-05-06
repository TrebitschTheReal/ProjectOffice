using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Employee : PC
    {
        private Random r = new Random();
        private string employeeName = "";
        private int employeeSex = 0;
        private string post = "";
        private int wage = 0;
        private double productivity = 0.0;

        public Employee()
        {
            this.employeeSex = r.Next(1, 3);
            this.employeeName = GenerateName(employeeSex);
            this.post = GeneratePost();
            this.wage = GenerateWage();
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

        private string GenerateName(int employeeSex)
        {
            string choosedName = "";

            string[] maleNames = new string[7] { "Józsi", "Feri", "Péter", "Laci", "Béla", "János", "Pista" };
            string[] femaleNames = new string[7] { "Izabella", "Niki", "Viki", "Margit", "Rozália", "Agónia", "Begónia" };

            if(employeeSex == 1)
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

            string[] posts = new string[5] {"junior software developer", "senior software developer", "team lead", "tester","helpdesk"};

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

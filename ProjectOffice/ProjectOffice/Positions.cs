using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Positions
    {
        Random r = new Random();
        private string[] positions = new string[8] { "Tester", "Help desk technician", "IT support technician", "HR management", "Network administrator", "Junior software developer", "Senior software developer", "Team lead" };
        private string position;
        private int baseWage = 170000;
        private double wageMultiplier = 0.0;

        public Positions()
        {
            GeneratePosition();
            GenerateWageMultiplerByPosition();
        }
        public string Position
        {
            get { return position; }
        }
        private void GenerateWageMultiplerByPosition()
        {
            switch (position)
            {
                case "Tester":
                      wageMultiplier = 1.2;
                      break;

                case "Help desk technician":
                    wageMultiplier = 1.3;
                    break;

                case "IT support technician":
                    wageMultiplier = 1.5;
                    break;

                case "HR management":
                    wageMultiplier = 1.7;
                    break;

                case "Network administrator":
                    wageMultiplier = 1.8;
                    break;

                case "Junior software developer":
                    wageMultiplier = 1.9;
                    break;

                case "Senior software developer":
                    wageMultiplier = 2.5;
                    break;

                case "Team lead":
                    wageMultiplier = 4.5;
                    break;
            }
        }
        public int GenerateWage()
        {
            double wageInDouble = baseWage * wageMultiplier;
            int wage = (int)wageInDouble;
            return wage;
        }
        public void GeneratePosition()
        {
            position = positions[r.Next(0, positions.Length)];
        }


    }
}

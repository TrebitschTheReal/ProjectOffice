﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Positions
    {
        private string[] positions = new string[8] { "Tester", "Help desk technician", "IT support technician", "HR management", "Network administrator", "Junior software developer", "Senior software developer", "Team lead" };
        private string position;
        private int baseWage = 170000;
        private double wageMultiplier = 0.0;
        private int wage = 0;

        public Positions(bool isEnoughOfLeaders)
        {
            if(isEnoughOfLeaders == true)
            {
                GeneratePositionWithoutLeader();
                GenerateWageMultiplerByPosition();
                GenerateWage();
            }
            else
            {
                GeneratePosition();
                GenerateWageMultiplerByPosition();
                GenerateWage();
            }

        }
        public string Position
        {
            get { return position; }
        }
        public int Wage
        {
            get { return wage; }
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
        public void GenerateWage()
        {
            double wageInDouble = baseWage * wageMultiplier;
            wage = (int)wageInDouble;
        }
        public void GeneratePosition()
        {
            position = positions[StaticRandom.Instance.Next(0, positions.Length)];
        }
        public void GeneratePositionWithoutLeader()
        {
            position = positions[StaticRandom.Instance.Next(0, positions.Length-1)];
        }


    }
}

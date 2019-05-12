using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Names
    {
        private string[] maleNames = new string[11] { "József", "Ferenc", "Péter", "László", "Béla", "János", "István", "Sándor", "Aladár", "Dénes", "Géza" };
        private string[] femaleNames = new string[11] { "Izabella", "Nikolett", "Viktória", "Margit", "Rozália", "Agónia", "Begónia", "Henrietta", "Petra", "Franciska", "Bernadett" };
        private string choosedName = "";
        private byte employeeSex = 0;

        public Names()
        {
            employeeSex = Convert.ToByte(StaticRandom.Instance.Next(1, 3));
            GenerateName(employeeSex);
        }
        public string ChoosedName
        {
            get { return choosedName; }
        }
        public byte EmployeeSex
        {
            get { return employeeSex; }
        }
        private void GenerateName(int employeeSex)
        {
            char firstName = femaleNames[StaticRandom.Instance.Next(0, femaleNames.Length)].ToCharArray()[0];
            string lastName = "";

            if (employeeSex == 1)
            {
                lastName = maleNames[StaticRandom.Instance.Next(0, maleNames.Length)];
                choosedName = firstName + ". " + lastName;
            }
            else
            {
                lastName = femaleNames[StaticRandom.Instance.Next(0, maleNames.Length)];
                choosedName = firstName + ". " + lastName;
            }
        }
    }
}
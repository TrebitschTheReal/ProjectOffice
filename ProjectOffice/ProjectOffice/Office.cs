using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class Office
    {
        private OfficeBox box;
        private OfficeBox[] officeboxes;

        public Office()
        {
            officeboxes = GenerateOfficeBox();
        }
        public OfficeBox[] OfficeBox
        {
            get { return officeboxes; }
        }
        public OfficeBox[] GenerateOfficeBox()
        {

            for (int i = 0; i < officeboxes.Length; i++)
            {
                officeboxes[i] = box.Worker;
            }
            return officeboxes;
        }


    }
}

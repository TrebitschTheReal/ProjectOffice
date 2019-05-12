using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class PC
    {
        private string[] monitorTypes = new string[6] { "Benq", "Asus", "Samsung", "Philips", "LG", "Acer" };
        private string monitorType = "";
        private int monitorResolution = 0;
        private string processorType = "";
        private double processorPerformance = 0.0;
        private string ramType = "";
        private double ramPerformance = 0.0;

        public PC()
        {
            GenerateMonitorType();
        }
        public string ChoosedMonitorType
        {
            get { return monitorType; }
        }
        private void GenerateMonitorType()
        {
            monitorType = monitorTypes[StaticRandom.Instance.Next(0, monitorTypes.Length)];
        }

    }
}

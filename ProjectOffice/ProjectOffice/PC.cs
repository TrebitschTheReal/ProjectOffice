using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice
{
    class PC
    {
        protected Random r = new Random();

        private string monitorType = "";
        private int monitorResolution = 0;
        private string processorType = "";
        private double processorPerformance = 0.0;
        private string ramType = "";
        private double ramPerformance = 0.0;

        public PC()
        {
            this.monitorType = GenerateMonitorType();

        }

        private string GenerateMonitorType()
        {
            string choosedMonitor = "";
            string[] monitorTypes = new string[4] { "Benq", "Asus", "Samsung", "Philips" };
            choosedMonitor = monitorTypes[r.Next(0, monitorTypes.Length)];
            return choosedMonitor;
        }
        public string MonitorType
        {
            get { return monitorType; }
        }

    }
} 

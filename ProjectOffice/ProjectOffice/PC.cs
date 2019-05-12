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
        private string[] processorTypes = new string[2] { "Intel", "Amd" };
        private int[] processorPerformances = new int[] { 3400, 3500, 3600, 3700 };
        private string monitorType = "";
        private int monitorResolution = 0;
        private string processorType = "";
        private int processorPerformance = 0;
        private string ramType = "";
        private double ramPerformance = 0.0;

        public PC()
        {
            GenerateMonitorType();
            GenerateProcessorType();
            GenerateProcessorPerformance();
        }
        public string MonitorType
        {
            get { return monitorType; }
        }
        public string ProcessorType
        {
            get { return processorType; }
        }
        public int ProcessorPerformance
        {
            get { return processorPerformance; }
        }
        private void GenerateMonitorType()
        {
            monitorType = monitorTypes[StaticRandom.Instance.Next(0, monitorTypes.Length)];
        }
        private void GenerateProcessorPerformance()
        {
              processorPerformance = processorPerformances[StaticRandom.Instance.Next(0, processorPerformances.Length)];
        }
        private void GenerateProcessorType()
        {
            processorType = processorTypes[StaticRandom.Instance.Next(0, processorTypes.Length)];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciZadatak
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if ((currentLoad >= 1.1*this.previousCPULoad)|| currentLoad*1.1 <= this.previousCPULoad)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentRAM = this.AvailableRAM;
            if ((currentRAM >= 1.1*this.previousRAMAvailable)|| currentRAM <= 1.1 * this.previousRAMAvailable)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentRAM;
            return currentRAM;
        }
    }
}

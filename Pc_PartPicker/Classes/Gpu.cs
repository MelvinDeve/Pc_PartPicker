using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker.Classes
{
    class Gpu
    {
        private String chipSet { get; }
        private String gpuMemory { get; }
        private int tdp { get; }


        public Gpu(String chipSet, String gpuMemory, String tdp)
        {
            this.chipSet = chipSet;
            this.gpuMemory = gpuMemory;
            this.tdp = Int32.Parse(tdp);
        }
    }
}

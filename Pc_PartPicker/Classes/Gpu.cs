using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Gpu
    {
        public String name { get; }
        public String chipSet { get; }
        public String gpuMemory { get; }
        public int tdp { get; }
        public double price { get; }


        public Gpu(String name, String chipSet, String gpuMemory, String tdp, double price)
        {
            this.name = name;
            this.chipSet = chipSet;
            this.gpuMemory = gpuMemory;
            this.tdp = Int32.Parse(tdp);
            this.price = price;
        }
    }
}

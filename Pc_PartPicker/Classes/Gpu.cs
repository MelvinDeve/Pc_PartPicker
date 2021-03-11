using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public class Gpu
    {
        public String name;
        public String chipSet;
        public String gpuMemory;
        public int tdp;
        public double price;

        public Gpu(String name, String chipSet, String gpuMemory, String tdp, double price)
        {
            this.name = name;
            this.chipSet = chipSet;
            this.gpuMemory = gpuMemory;
            this.tdp = Int32.Parse(tdp);
            this.price = price;
        }
        public Gpu()
        {

        }
    }
}

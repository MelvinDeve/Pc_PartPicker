using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Memory
    {
        public String speed { get; }
        public int modules { get; }
        public String capacity { get; }



        public Memory(String speed, String modules, String capacity)
        {
            this.speed = speed;
            this.modules = Int32.Parse(modules);
            this.capacity = capacity;
        }
    }
}

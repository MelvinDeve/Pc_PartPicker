using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Memory
    {
        public String name { get; }
        public String speed { get; }
        public int modules { get; }
        public String capacity { get; }
        public double price { get; }

        public Memory(String name, String speed, String modules, String capacity, double price)
        {
            this.name = name;
            this.speed = speed;
            this.modules = Int32.Parse(modules);
            this.capacity = capacity;
            this.price = price;
        }
    }
}

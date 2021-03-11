using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public class Memory
    {
        public String name;
        public String speed;
        public int modules;
        public String capacity;
        public double price;

        public Memory(String name, String speed, String modules, String capacity, double price)
        {
            this.name = name;
            this.speed = speed;
            this.modules = Int32.Parse(modules);
            this.capacity = capacity;
            this.price = price;
        }
        public Memory()
        {

        }
    }
}

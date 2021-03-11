using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Storage
    {
        public String name { get; }
        public String capacity { get; }
        public String intface { get; }
        public double price { get; }

        public Storage(String name,  String capacity, String intface, double price)
        {
            this.name = name;
            this.capacity = capacity;
            this.intface = intface;
            this.price = price;
        }
    }
}

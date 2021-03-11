using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public class Storage
    {
        public String name;
        public String capacity;
        public String intface;
        public double price;

        public Storage(String name,  String capacity, String intface, double price)
        {
            this.name = name;
            this.capacity = capacity;
            this.intface = intface;
            this.price = price;
        }
        public Storage()
        {

        }
    }
}

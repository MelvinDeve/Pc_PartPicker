using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Case
    {
        public String name { get; }
        public String formFactor { get; }
        public double price { get; }

        public Case(String name, String formFactor, double price)
        {
            this.name = name;
            this.formFactor = formFactor;
            this.price = price;
        }
    }
}

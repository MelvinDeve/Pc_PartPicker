using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public class Case
    {
        public String name;
        public String formFactor;
        public double price;

        public Case(String name, String formFactor, double price)
        {
            this.name = name;
            this.formFactor = formFactor;
            this.price = price;
        }
        public Case()
        {

        }
    }
}

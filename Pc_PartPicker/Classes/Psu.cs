using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Psu
    {
        public String name { get; }
        public String efficiencyRating { get; }
        public int wattage { get; }
        public double price { get; }

        public Psu(String name, String efficiencyRating, String wattage, double price)
        {
            this.name = name;
            this.efficiencyRating = efficiencyRating;
            this.wattage = Int32.Parse(wattage);
            this.price = price;
        }
    }
}

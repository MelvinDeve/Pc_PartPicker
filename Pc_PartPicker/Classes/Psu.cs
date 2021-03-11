using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public class Psu
    {
        public String name;
        public String efficiencyRating;
        public int wattage;
        public double price;

        public Psu(String name, String efficiencyRating, String wattage, double price)
        {
            this.name = name;
            this.efficiencyRating = efficiencyRating;
            this.wattage = Int32.Parse(wattage);
            this.price = price;
        }
        public Psu()
        {

        }
    }
}

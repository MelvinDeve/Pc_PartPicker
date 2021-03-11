using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Psu
    {
        public String efficiencyRating { get; }
        public int wattage { get; }

        public Psu(String efficiencyRating, String wattage)
        {
            this.efficiencyRating = efficiencyRating;
            this.wattage = Int32.Parse(wattage);
        }
    }
}

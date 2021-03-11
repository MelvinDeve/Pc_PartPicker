using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker.Classes
{
    class Psu
    {
        private String efficiencyRating { get; }
        private int wattage { get; }

        public Psu(String efficiencyRating, String wattage)
        {
            this.efficiencyRating = efficiencyRating;
            this.wattage = Int32.Parse(wattage);
        }
    }
}

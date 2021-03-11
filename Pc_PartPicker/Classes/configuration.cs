using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{

    static class configuration
    {
        public static Case pcCase {get; set;}
        public static CPU cpu { get; set; }
        public static CPU_Cooler cpuCooler { get; set; }
        public static Gpu gpu { get; set; }

        public static List<Memory> memory { get; set; }
        public static Motherboard motherboard { get; set; }
        public static Psu psu { get; set; }
        public static List<Storage> storage { get; set; }
    }
}

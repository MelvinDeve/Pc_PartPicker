using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class CPU_Cooler
    {
        public String name { get; }
        public String coolingType { get; }
        public String tdpClass { get; }
        public String socketComp { get; }
        public double price { get; }

        public CPU_Cooler(String _name, String _coolingType, String _tdpClass, String _socketComp, double _price)
        {
            name = _name;
            coolingType = _coolingType;
            tdpClass = _tdpClass;
            socketComp = _socketComp;
            price = _price;
        }
    }
}

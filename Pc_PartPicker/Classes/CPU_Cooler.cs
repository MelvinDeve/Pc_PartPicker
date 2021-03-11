using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public class CPU_Cooler
    {
        public String name;
        public String coolingType;
        public String tdpClass;
        public String socketComp;
        public double price;

        public CPU_Cooler(String _name, String _coolingType, String _tdpClass, String _socketComp, double _price)
        {
            name = _name;
            coolingType = _coolingType;
            tdpClass = _tdpClass;
            socketComp = _socketComp;
            price = _price;
        }
        public CPU_Cooler()
        {

        }
    }
}

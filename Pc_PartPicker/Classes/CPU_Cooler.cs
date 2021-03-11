using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class CPU_Cooler
    {
        public String coolingType { get; }
        public String tdpClass { get; }
        public String socketComp { get; }

        public CPU_Cooler(String _coolingType, String _tdpClass, String _socketComp)
        {
            coolingType = _coolingType;
            tdpClass = _tdpClass;
            socketComp = _socketComp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker.Classes
{
    class CPU_Cooler
    {
        private String coolingType { get; }
        private String tdpClass { get; }
        private String socketComp { get; }

        public CPU_Cooler(String _coolingType, String _tdpClass, String _socketComp)
        {
            coolingType = _coolingType;
            tdpClass = _tdpClass;
            socketComp = _socketComp;
        }
    }
}

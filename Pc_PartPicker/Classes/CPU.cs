using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker.Classes
{
    class CPU
    {
        private String coreCount { get; }
        private String threadCount { get; }
        private String coreClock { get; }
        private int TDP { get; }
        private bool integratedGraphics { get; }
        private bool integratedCooler { get; }
        private String Socket { get; }

        public CPU(String _coreCount, String _threadCount, String _coreClock, String _TDP, String _integratedGraphics, String _integratedCooler, String _Socket)
        {
            coreCount = _coreCount;
            threadCount = _threadCount;
            coreClock = _coreClock;
            TDP = Int32.Parse(_TDP);
            if(_integratedGraphics == "YES")
            {
                integratedGraphics = true;
            }else
            {
                integratedGraphics = false;
            }
            if (_integratedCooler == "YES")
            {
                integratedCooler = true;
            }
            else
            {
                integratedCooler = false;
            }
            Socket = _Socket;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class CPU
    {
        public String name { get; }
        public String coreCount { get; }
        public String threadCount { get; }
        public String coreClock { get; }
        public String boostClock { get; }
        public int TDP { get; }
        public bool integratedGraphics { get; }
        public bool integratedCooler { get; }
        public String Socket { get; }
        public double price { get; }

        public CPU(String _name, String _coreCount, String _threadCount, String _coreClock, String _boostClock, String _TDP, String _integratedGraphics, String _integratedCooler, String _Socket, double _price)
        {
            name = _name;
            price = _price;
            coreCount = _coreCount;
            threadCount = _threadCount;
            coreClock = _coreClock;
            boostClock = _boostClock;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Motherboard
    {
        public String name { get; }
        public String Chipset { get; }
        public String formFactor { get; }
        public String socket { get; }
        public int memorySlots { get; }
        public int m2Slots { get; }
        public int sataPorts { get; }
        public double price { get; }

        public Motherboard(String _name, String _Chipset, String _formFactor, String _socket, String _memorySlots, String _m2Slots, String _sataPorts, double _price)
        {
            name = _name;
            Chipset = _Chipset;
            formFactor = _formFactor;
            socket = _socket;
            memorySlots = Int32.Parse(_memorySlots);
            m2Slots = Int32.Parse(_m2Slots);
            sataPorts = Int32.Parse(_sataPorts);
            price = _price;
        }

    }
}

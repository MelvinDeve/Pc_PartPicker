using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public class Motherboard
    {
        public String name;
        public String Chipset;
        public String formFactor;
        public String socket;
        public int memorySlots;
        public int m2Slots;
        public int sataPorts;
        public double price;

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

        public Motherboard()
        {

        }

    }
}

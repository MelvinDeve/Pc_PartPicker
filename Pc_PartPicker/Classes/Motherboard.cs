using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker.Classes
{
    class Motherboard
    {
        private String Chipset { get; }
        private String formFactor { get; }
        private String socket { get; }
        private int memorySlots { get; }
        private int m2Slots { get; }
        private int sataPorts { get; }

        public Motherboard(String _Chipset, String _formFactor, String _socket, String _memorySlots, String _m2Slots, String _sataPorts)
        {
            Chipset = _Chipset;
            formFactor = _formFactor;
            socket = _socket;
            memorySlots = Int32.Parse(_memorySlots);
            m2Slots = Int32.Parse(_m2Slots);
            sataPorts = Int32.Parse(_sataPorts);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker.Classes
{
    class Storage
    {
        private String capacity { get; }
        private String intface { get; }

        public Storage(String capacity, String intface)
        {
            this.capacity = capacity;
            this.intface = intface;
        }
    }
}

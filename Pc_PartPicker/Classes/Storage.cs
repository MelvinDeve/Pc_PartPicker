using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Storage
    {
        public String capacity { get; }
        public String intface { get; }

        public Storage(String capacity, String intface)
        {
            this.capacity = capacity;
            this.intface = intface;
        }
    }
}

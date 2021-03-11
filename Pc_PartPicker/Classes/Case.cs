using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Case
    {
        public String formFactor { get; }

        public Case(String formFactor)
        {
            this.formFactor = formFactor;
        }
    }
}

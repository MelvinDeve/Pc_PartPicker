using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker.Classes
{
    class PartProperties
    {
        Dictionary<String, PropertiesLi> partProperties = new Dictionary<string, PropertiesLi>();
        
        public PartProperties()
        {
            partProperties.Add("CPU", new PropertiesLi(new List<Property> {new Property(1, "testcpu1"), new Property(2, "testcpu2")}));
            partProperties.Add("GPU", new PropertiesLi(new List<Property> {new Property(1, "testgpu1"), new Property(2, "testgpu2")}));
        }

        public PropertiesLi getPartProperties(String part)
        {
            PropertiesLi retProp;
            if (partProperties.TryGetValue(part, out retProp))
            {
                return retProp;
            }
            else
            {
                return null;
            }
        }
    }
}

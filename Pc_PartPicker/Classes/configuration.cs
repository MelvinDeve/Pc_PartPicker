using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pc_PartPicker
{

    static class configuration
    {

        static configuration() { }
        public static Case pcCase {get; set;}
        public static CPU cpu { get; set; }
        public static CPU_Cooler cpuCooler { get; set; }
        public static Gpu gpu { get; set; }

        public static List<Memory> memory { get; set; } = new List<Memory>();
        public static Motherboard motherboard { get; set; }
        public static Psu psu { get; set; }
        public static List<Storage> storage { get; set; } = new List<Storage>();

    }

    public class configWrite
    {

        public configWrite()
        {
        }

        public void fill()
        {
            pcCase = configuration.pcCase;
            cpu = configuration.cpu;
            cpuCooler = configuration.cpuCooler;
            gpu = configuration.gpu;
            memory = configuration.memory;
            motherboard = configuration.motherboard;
            psu = configuration.psu;
            storage = configuration.storage;
        }

        const string FileSavePath = "Partlist.xml";
        public Case pcCase;
        public CPU cpu;
        public CPU_Cooler cpuCooler;
        public Gpu gpu;

        public List<Memory> memory;
        public Motherboard motherboard;
        public Psu psu;
        public List<Storage> storage;

        public void configRead()
            {
            configuration.pcCase = pcCase;
            configuration.cpu = cpu;
            configuration.cpuCooler = cpuCooler;
            configuration.gpu = gpu;
            configuration.memory = memory;
            configuration.motherboard = motherboard;
            configuration.psu = psu;
            configuration.storage = storage;
            }
        public void BasicSave()
        {
            var xs = new XmlSerializer(typeof(configWrite));

            using (TextWriter sw = new StreamWriter(FileSavePath))
            {
                xs.Serialize(sw, this);
            }
        }
        public void BasicLoad()
        {
            var xs = new XmlSerializer(typeof(configWrite));

            using (var sr = new StreamReader(FileSavePath))
            {
                var tempObject = (configWrite)xs.Deserialize(sr);
                pcCase = tempObject.pcCase;
                cpu = tempObject.cpu;
                cpuCooler = tempObject.cpuCooler;
                gpu = tempObject.gpu;
                memory = tempObject.memory;
                motherboard = tempObject.motherboard;
                psu = tempObject.psu;
                storage = tempObject.storage;
                configRead();
            }
        }
    }
}

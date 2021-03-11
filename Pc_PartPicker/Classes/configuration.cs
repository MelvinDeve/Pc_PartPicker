using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{

    static class configuration
    {

        static configuration() { }
        public static Case pcCase {get; set;}
        public static CPU cpu { get; set; }
        public static CPU_Cooler cpuCooler { get; set; }
        public static Gpu gpu { get; set; }

        public static List<Memory> memory { get; set; }
        public static Motherboard motherboard { get; set; }
        public static Psu psu { get; set; }
        public static List<Storage> storage { get; set; }

    }

    public class configWrite
    {

        public configWrite()
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
        Case pcCase { get; set; }
        CPU cpu { get; set; }
        CPU_Cooler cpuCooler { get; set; }
        Gpu gpu { get; set; }

        List<Memory> memory { get; set; }
        Motherboard motherboard { get; set; }
        Psu psu { get; set; }
        List<Storage> storage { get; set; }

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

    }
}

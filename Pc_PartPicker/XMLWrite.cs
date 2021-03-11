using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    public static class XMLWrite
    {

        public static void WriteXML()
        {
            configWrite conWrite = new configWrite();
            conWrite.fill();
            conWrite.BasicSave();
            /*
            configWrite conWrite = new configWrite();
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(configWrite));

            var path = "Partlist.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, conWrite);
            file.Close();
            */
        }

        public static void ReadXML()
        {
            configWrite conWrite = new configWrite();
            conWrite.BasicLoad();
            /*
            configWrite conWrite = new configWrite();
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(configWrite));
            System.IO.StreamReader file = new System.IO.StreamReader(
                "Partlist.xml");
            conWrite = (configWrite)reader.Deserialize(file);
            file.Close();
            conWrite.configRead();
            */
        }
    }
}

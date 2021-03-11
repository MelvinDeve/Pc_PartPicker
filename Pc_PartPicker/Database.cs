using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Database
    {
        
        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        public static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Parts";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
                Console.ReadLine();
                
            }
            conn.Close();
        }

        public static DataTable ReadDataTable(SQLiteConnection conn, int partType)
        {
            DataTable TabData = new DataTable();
            List<int> Columns = new List<int>();

            TabData.Columns.Add("Product");

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT Properties.propName, Properties.id FROM TypeProperties JOIN Properties on TypeProperties.propId = Properties.id Where typeId = " + partType.ToString() + ";";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                
                string myreader = sqlite_datareader.GetString(0);
                Columns.Add(sqlite_datareader.GetInt32(1));
                TabData.Columns.Add(myreader);
            }
            TabData.Columns.Add("Price");

            SQLiteDataReader sqlite_datareader_products;
            SQLiteCommand sqlite_cmd_products;
            sqlite_cmd_products = conn.CreateCommand();
            sqlite_cmd_products.CommandText = "SELECT name, price, id FROM Parts WHERE typeId = " + partType + ";";
            sqlite_datareader_products = sqlite_cmd_products.ExecuteReader();
            while (sqlite_datareader_products.Read())
            {
                List<object> row = new List<object>();
                string partName = sqlite_datareader_products.GetString(0);
                double partPrice = sqlite_datareader_products.GetDouble(1);
                int partId = sqlite_datareader_products.GetInt32(2);
                row.Add(partName);
                foreach(int colId in Columns)
                {
                    SQLiteDataReader sqlite_datareader_properties;
                    SQLiteCommand sqlite_cmd_properties;
                    sqlite_cmd_properties = conn.CreateCommand();
                    sqlite_cmd_properties.CommandText = "SELECT propValue FROM PartProperties WHERE partId = "+partId+" and propId = "+colId+"; ";
                    sqlite_datareader_properties = sqlite_cmd_properties.ExecuteReader();
                    while (sqlite_datareader_properties.Read())
                    {
                        row.Add(sqlite_datareader_properties.GetString(0));
                    }
                }
                row.Add(partPrice);
                if (checkRow(partType, row))
                {
                    TabData.Rows.Add(row.ToArray());
                }
            }




                conn.Close();
            return TabData;
        }

        private static bool checkRow(int partType, List<Object> props)
        {
            switch (partType)
            {
                case Constants.CASECONST:
                    if (configuration.motherboard != null)
                    {
                        if((String)props[1] == "µATX" && configuration.motherboard.formFactor == "ATX")
                        {
                            return false;
                        }else if((String)props[1] == "Mini-ITX" && configuration.motherboard.formFactor != "Mini-ITX")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case Constants.CPUCONST:
                    if (configuration.motherboard != null)
                    {
                        if(configuration.motherboard.socket!= (String)props[8])
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case Constants.MOTHERBOARDCONST:
                    if(configuration.cpu != null)
                    {
                        if(configuration.cpu.Socket != (string)props[3])
                        {
                            return false;
                        }
                    }
                    if (configuration.pcCase!= null)
                    {
                        if (configuration.pcCase.formFactor == "µATX" && (string)props[2] == "ATX")
                        {
                            return false;
                        }
                        else if (configuration.pcCase.formFactor == "Mini-ITX" && (string)props[2] != "Mini-ITX")
                        {
                            return false;
                        }
                    }
                    break;
                case Constants.MEMORYCONST:
                    int dimms=0;
                    if (configuration.memory.Count!=0)
                    {
                        if (configuration.memory[0].name != (string)props[0])
                        {
                            return false;
                        }
                        foreach (Memory mod in configuration.memory)
                        {
                            dimms += mod.modules;
                        }
                    }
                    if (configuration.motherboard.memorySlots < dimms + Int32.Parse((String)props[2]))
                    {
                        return false;
                    }
                    
                    
                    break;
                case Constants.STORAGECONST:
                    int stnum = 0;
                    if ((string)props[2] == "sata")
                    {
                        if (configuration.storage.Count != 0)
                        {
                            foreach (Storage stDev in configuration.storage)
                            {
                                if (stDev.intface == "sata")
                                {
                                    stnum++;
                                }
                            }
                        }
                        if(configuration.motherboard.sataPorts < stnum+1)
                        {
                            return false;
                        }
                    }else if ((string)props[2] == "m.2")
                    {
                        if (configuration.storage.Count != 0)
                        {
                            foreach (Storage stDev in configuration.storage)
                            {
                                if (stDev.intface == "m.2")
                                {
                                    stnum++;
                                }
                            }
                        }
                        if (configuration.motherboard.m2Slots < stnum + 1)
                        {
                            return false;
                        }
                    }
                    break;
                case Constants.PSUCONST:
                    int tdp = configuration.cpu.TDP + configuration.gpu.tdp + 100;
                    if (tdp > Int32.Parse((String)props[2]))
                    {
                        return false;
                    }
                    break;
            }


            return true;
        }
    }
}


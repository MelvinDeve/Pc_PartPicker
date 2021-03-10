using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc_PartPicker
{
    class Database
    {
        /*
        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn);
        }
        */
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

        public static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE Type(id int auto_increment primary key unique not null, name varchar(20))";

            string Createsql1 = "CREATE TABLE Properties(id int auto_increment primary key unique not null, propName varchar(20))";

            string Createsql2 = "CREATE TABLE Parts(id int auto_increment primary key unique not null, typeId int not null, name varchar(60) not null, price double, image string, " +
                "CONSTRAINT FK_articleComments foreign key (typeId) references Type(id))";

            string Createsql3 = "CREATE TABLE PartProperties(id int auto_increment primary key unique not null, partId int not null, propId not null, propValue varchar(50), " +
                "CONSTRAINT FK_articleComments foreign key (partId) references Parts(id), " +
                "CONSTRAINT FK_articleComments foreign key (propId) references Properties(id))";

            string Createsql4 = "CREATE TABLE TypeProperties(id int auto_increment primary key unique not null, typeId int not null, propId not null, " +
                "CONSTRAINT FK_articleComments foreign key (typeId) references Type(id), " +
                "CONSTRAINT FK_articleComments foreign key (propId) references Properties(id))";

            sqlite_cmd = conn.CreateCommand();
            /*
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql2;
            sqlite_cmd.ExecuteNonQuery();            
            sqlite_cmd.CommandText = Createsql3;
            sqlite_cmd.ExecuteNonQuery();
            */
            sqlite_cmd.CommandText = Createsql4;
            sqlite_cmd.ExecuteNonQuery();

        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            //Type INSERTS
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('CPU'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('CPU-Cooler'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('Motherboard'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('Memory'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('Storage'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('GPU'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('Case'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Type(name) VALUES('PSU'); ";
            sqlite_cmd.ExecuteNonQuery();

            //Properties INSERTS
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Core Count'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Thread Count'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Core Clock'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Boost Clock'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('TDP'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Integrated Graphics'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Integrated Cooler'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Socket'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Cooling Type'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('TDP-Class'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Socket-Comp'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Chipset'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Form Factor'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Memory Slots'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('M2 Slots'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Sata Ports'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Memory Speed'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Modules'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Capacity'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Interface'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('GPU Memory'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Efficiency Rating'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO Properties(propName) VALUES('Wattage'); ";
            sqlite_cmd.ExecuteNonQuery();

            //CPU Type Properties
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'Core Count'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'Thread Count'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'Core Clock'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'Boost Clock'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'TDP'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'Integrated Graphics'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'Integrated Cooler'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU'' , SELECT id from Properties where propName like 'Socket'); ";
            sqlite_cmd.ExecuteNonQuery();
            //CPU-Cooler Type Properties
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU-Cooler'' , SELECT id from Properties where propName like 'Cooling Type'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU-Cooler'' , SELECT id from Properties where propName like 'TDP-Class'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'CPU-Cooler'' , SELECT id from Properties where propName like 'Socket-Comp'); ";
            sqlite_cmd.ExecuteNonQuery();
            //Motherboard Type Properties
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Motherboard'' , SELECT id from Properties where propName like 'Chipset'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Motherboard'' , SELECT id from Properties where propName like 'Form Factor'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Motherboard'' , SELECT id from Properties where propName like 'Socket'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Motherboard'' , SELECT id from Properties where propName like 'Memory Slots'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Motherboard'' , SELECT id from Properties where propName like 'M2 Slots'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Motherboard'' , SELECT id from Properties where propName like 'Sata Ports'); ";
            sqlite_cmd.ExecuteNonQuery();
            //Memory Type Properties
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Memory'' , SELECT id from Properties where propName like 'Memory Speed'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Memory'' , SELECT id from Properties where propName like 'Modules'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Memory'' , SELECT id from Properties where propName like 'Capacity'); ";
            sqlite_cmd.ExecuteNonQuery();
            //Storage Type Properties
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Storage'' , SELECT id from Properties where propName like 'Capacity'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Storage'' , SELECT id from Properties where propName like 'Interface'); ";
            sqlite_cmd.ExecuteNonQuery();
            //GPU Type Properties
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'GPU'' , SELECT id from Properties where propName like 'Chipset'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'GPU'' , SELECT id from Properties where propName like 'GPU Memory'); ";
            sqlite_cmd.ExecuteNonQuery();
            //Case Type Properties
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'Case'' , SELECT id from Properties where propName like 'Form Factor'); ";
            sqlite_cmd.ExecuteNonQuery();
            //PSU
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'PSU'' , SELECT id from Properties where propName like 'Efficiency Rating'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO TypeProperties(typeId, propId) VALUES('SELECT id from Type where name like 'PSU'' , SELECT id from Properties where propName like 'Wattage'); ";
            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "INSERT INTO Parts(typeId, name, price, image) VALUES('SELECT id from Type where name like 'CPU';', 'AMD Ryzen 5 3600' , 179 , 'CPU_R5_3600'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable1(Col1, Col2) VALUES('Test3 Text3 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();

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
                
            }
            conn.Close();
        }
    }
}


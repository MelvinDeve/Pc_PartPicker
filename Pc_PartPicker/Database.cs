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
            string Createsql2 = "CREATE TABLE Parts(id int auto_increment primary key unique not null, typeId int not null, name varchar(60) not null, price double, image longblob, " +
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
            sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test1 Text1 ', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test2 Text2 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable1(Col1, Col2) VALUES('Test3 Text3 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();

        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

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


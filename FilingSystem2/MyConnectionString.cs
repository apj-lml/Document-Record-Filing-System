using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilingSystem2
{
    internal class MyConnectionString
    {
        //public string ConnectionString { get; set; }

        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"db_filingsystem.accdb"));
        //OleDbConnection con = new OleDbConnection();

        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter da = new OleDbDataAdapter();
        public OleDbConnection MyConnection()
        {
            OleDbConnection con = new OleDbConnection();
            var userPath = AppDomain.CurrentDomain.BaseDirectory;
            var laptopPath = Environment.CurrentDirectory;

             var filename = Path.Combine(userPath, "mysettings");

            // Read connection string
             var connectionString = File.ReadAllText(filename);

            // appdomain setup information
            AppDomain currentDomain = AppDomain.CurrentDomain;
            //Create or update a value pair for the appdomain
            // currentDomain.SetData("DataDirectory", laptopPath + "\\db_filingsystem.accdb");

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(connectionString, @"db_filingsystem.accdb"));
           // con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + laptopPath + "\\db_filingsystem.accdb");

            Console.WriteLine(con);

            return con;
        }
    }
}

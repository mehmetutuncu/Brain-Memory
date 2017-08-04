using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace BrainMemory
{
    
    class db
    {
        //public SqlConnection myConnection = new SqlConnection("server=MSI;Trusted_Connection=yes;database=brainmemory;connection timeout=30");


        public SQLiteConnection myConnection = new SQLiteConnection("Data Source=../../brainmemorydb.db;Version=3;");





    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TestWeb1.Interfaces;

namespace TestWeb1.Services
{
    public class DatabaseService : IDatabase
    {
        public SqlConnection Connect()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=192.168.15.202;Initial Catalog=LOG_Stock_List;User ID=sa;Password=p@ssw0rd";
            cnn = new SqlConnection(connetionString);
            return cnn;
        }
    }
}

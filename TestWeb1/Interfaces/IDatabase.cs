using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb1.Interfaces
{
    interface IDatabase
    {
        SqlConnection Connect();
    }
}

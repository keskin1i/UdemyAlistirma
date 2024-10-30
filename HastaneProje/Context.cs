using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneProje
{
    public class Context
    {
        public SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2KELP5G;Initial Catalog=HastaneProje;User ID=sa;Password=123456;Encrypt=False");
            connection.Open();
            return connection;
        }
    }
}

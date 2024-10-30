using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   
    public class Baglanti
    {
        public static SqlConnection _sql = new SqlConnection(@"Data Source=DESKTOP-2KELP5G;Initial Catalog=DbPesonel;User ID=sa;Password=123456;Encrypt=False");
    }
}

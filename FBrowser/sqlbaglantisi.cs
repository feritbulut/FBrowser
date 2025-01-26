using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBrowser
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-F5EB85PM\\SQLEXPRESS;Initial Catalog=FBrowser;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}

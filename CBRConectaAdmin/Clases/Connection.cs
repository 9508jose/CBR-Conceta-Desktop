using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CBRConectaAdmin.Clases
{
    internal class Connection
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=177.231.253.170; Initial Catalog=CBR_Conecta; User id=usuario; Password=admin;");

        public void open()
        {
            cn.Open();
        }

        public void close ()
        {
            cn.Close();
        }

    }
}

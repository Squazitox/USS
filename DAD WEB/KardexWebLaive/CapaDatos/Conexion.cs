using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static string CN = ConfigurationManager.ConnectionStrings["miconexion"].ConnectionString;
        
    }
}

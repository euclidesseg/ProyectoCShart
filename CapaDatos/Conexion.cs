using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    class Conexion
    {
        public SqlConnection conectar(string cnx)
        {
            try
            {
                SqlConnection objConectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                objConectar.Open();
                return objConectar;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}

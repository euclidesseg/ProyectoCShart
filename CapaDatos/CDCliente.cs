using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCliente
    {
        Conexion objConexion = new Conexion();
        SqlCommand objCommand = new SqlCommand();
        public bool guardar_cliente(CECliente objCliente)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBNegocio");
                objCommand.CommandText = "INGRESAR_CLIENTE";
                objCommand.Parameters.AddWithValue("@DNI_CLIENTE", objCliente.DNI_CLIENTE1);
                objCommand.Parameters.AddWithValue("@NOM_CLIENTE", objCliente.NOM_CLIENTE1);
                objCommand.Parameters.AddWithValue("@DIR_CLIENTE", objCliente.DIR_CLIENTE1);
                objCommand.Parameters.AddWithValue("@TEL_CLIENTE", objCliente.TEL_CLIENTE1);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public DataSet consultar_cliente(CECliente obCliente)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBNegocio");
                objCommand.CommandText = "GET_CLIENTE";
                objCommand.Parameters.AddWithValue("@DNI_CLIENTE", obCliente.DNI_CLIENTE1);
                SqlDataAdapter da = new SqlDataAdapter(objCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        //---------------
        public bool eliminarCliente(CECliente objCliente)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBNegocio");
                objCommand.CommandText = "ELIMINAR_CLIENTE";
                objCommand.Parameters.AddWithValue("@DNI_CLIENTE", objCliente.DNI_CLIENTE1);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        //***********************

        public bool modificar_cliente(CECliente objCliente)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = objConexion.conectar("DBNegocio");
                objCommand.CommandText = "MODIFICAR_CLIENTE";
                objCommand.Parameters.AddWithValue("@DNI_CLIENTE", objCliente.DNI_CLIENTE1);
                objCommand.Parameters.AddWithValue("@NOM_CLIENTE", objCliente.NOM_CLIENTE1);
                objCommand.Parameters.AddWithValue("@DIR_CLIENTE", objCliente.DIR_CLIENTE1);
                objCommand.Parameters.AddWithValue("@TEL_CLIENTE", objCliente.TEL_CLIENTE1);
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}

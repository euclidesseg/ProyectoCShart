using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNCliente
    {
        CDCliente objDatCliente = new CDCliente();
        public bool guardar_cliente(CECliente objCliente)
        {
            return objDatCliente.guardar_cliente(objCliente);
        }

        //-------------------------
        public DataSet consultar_cliente(CECliente obCliente)
        {
            return objDatCliente.consultar_cliente(obCliente);
        }
        //--------------
        public bool eliminarCliente(CECliente objCliente)
        {
            return objDatCliente.eliminarCliente(objCliente);
        }
        //****************************
        public bool modificar_cliente(CECliente objCliente)
        {
            return objDatCliente.modificar_cliente(objCliente);
        }
    }
}

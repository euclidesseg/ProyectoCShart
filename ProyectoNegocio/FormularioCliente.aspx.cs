using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace ProyectoNegocio
{
    public partial class FormularioCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CECliente oCeCliente = new CECliente();
            CNCliente oCnCliente = new CNCliente();

            oCeCliente.DNI_CLIENTE1 = Convert.ToInt32(txtDniCliente.Text);
            oCeCliente.NOM_CLIENTE1 = txtNombreCliente.Text;
            oCeCliente.DIR_CLIENTE1 = txtDirCliente.Text;
            oCeCliente.TEL_CLIENTE1 = Convert.ToInt32(txtTelCliente.Text);

            if (oCnCliente.guardar_cliente(oCeCliente))
            {
                lblResultado.Text = "Cliente agregada correctamente";
            } else
            {
                lblResultado.Text = "Error al guardar el cliente";
            }
        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            CECliente oCeCliente = new CECliente();
            CNCliente oCnCliente = new CNCliente();

            DataSet ds = new DataSet();
            oCeCliente.DNI_CLIENTE1 = Convert.ToInt32(txtDniCliente.Text);

            ds = oCnCliente.consultar_cliente(oCeCliente);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblResultado.Text = "no existe este cliente";
            }
            else {
                txtDniCliente.Text = ds.Tables[0].Rows[0]["DNI_CLIENTE"].ToString();
                txtNombreCliente.Text = ds.Tables[0].Rows[0]["NOM_CLIENTE"].ToString();
                txtDirCliente.Text = ds.Tables[0].Rows[0]["DIR_CLIENTE"].ToString();
                txtTelCliente.Text = ds.Tables[0].Rows[0]["TEL_CLIENTE"].ToString();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            CECliente oCeCliente = new CECliente();
            CNCliente oCnCliente = new CNCliente();

            oCeCliente.DNI_CLIENTE1 = Convert.ToInt32(txtDniCliente.Text);
            if (oCnCliente.eliminarCliente(oCeCliente))
            {
                lblResultado.Text = "el cliente se ha eliminado correctamente";
            }
            else
            {
                lblResultado.Text = " no se pudo eliminar el cliente";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            CECliente oCeCliente = new CECliente();
            CNCliente oCnCliente = new CNCliente();

            oCeCliente.DNI_CLIENTE1 = Convert.ToInt32(txtDniCliente.Text);
            oCeCliente.NOM_CLIENTE1 = txtNombreCliente.Text;
            oCeCliente.DIR_CLIENTE1 = txtDirCliente.Text;
            oCeCliente.TEL_CLIENTE1 = Convert.ToInt32(txtTelCliente.Text);

            if (oCnCliente.modificar_cliente(oCeCliente))
            {
                lblResultado.Text = "Cliente modificado correctamente";
            }
            else
            {
                lblResultado.Text = "Error al modificar el cliente";
            }
        }
    }
}
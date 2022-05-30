using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CECliente
    {
        private int DNI_CLIENTE;
        private String NOM_CLIENTE;
        private String DIR_CLIENTE;
        private int TEL_CLIENTE;

        public int DNI_CLIENTE1 { get => DNI_CLIENTE; set => DNI_CLIENTE = value; }
        public string NOM_CLIENTE1 { get => NOM_CLIENTE; set => NOM_CLIENTE = value; }
        public string DIR_CLIENTE1 { get => DIR_CLIENTE; set => DIR_CLIENTE = value; }
        public int TEL_CLIENTE1 { get => TEL_CLIENTE; set => TEL_CLIENTE = value; }
    }
}

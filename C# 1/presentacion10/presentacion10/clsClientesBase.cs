using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion10
{
    public class clsClientesBase : clsAbsCliententes
    {
        public clsClientesBase()
        {
            ID = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            RFC = string.Empty;
            tipoRegimen = 0;
            nombreContacto = string.Empty;
        }

        public clsClientesBase(int pId, string pNombrem, string pClave, string pRFC, int pTipoRegimen, string pNombreContacto)
        {
            ID = pId;
            Nombre = pNombrem;
            Clave = pClave;
            RFC = pRFC;
            tipoRegimen = pTipoRegimen;
            nombreContacto = pNombreContacto;
        }

        public override int ID { get; set; }

        public override string Nombre { get; set; }

        public override string Clave { get; set; }

        public override string RFC { get; set; }

        public override int tipoRegimen { get; set; }

        public override string nombreContacto { get; set; }
    }
}

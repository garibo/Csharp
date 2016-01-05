using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion8
{
    public class clsClientesConContactos : clsClientesBase
    {
        public clsClientesConContactos()
        {
            _Direccion = new clsDirecciones();
        }

        public clsClientesConContactos(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen, string pNombreContacto, string pTelefono1, string pTelefono2, string pEmail, string pCalle, string pNumeroExterior, string pNumeroInterior, string pColonia, string pMunicipio, string pEstado, string pCP)
        {
            ID = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            tipoRegimen = pTipoRegimen;
            nombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Email = pEmail;
            _Direccion = new clsDirecciones();
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Colonia = pColonia;
            Direccion.Municipio = pMunicipio;
            Direccion.estado = pEstado;
            Direccion.CP = pCP;

        }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Email { get; set; }

        private clsDirecciones _Direccion;

        internal clsDirecciones Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
    }
}

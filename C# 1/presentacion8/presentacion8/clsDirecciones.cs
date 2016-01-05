using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion8
{
    public class clsDirecciones
    {
        public clsDirecciones()
        {
            Calle = string.Empty;
            NumeroExterior = string.Empty;
            NumeroInterior = string.Empty;
            Colonia = string.Empty;
            Municipio = string.Empty;
            estado = string.Empty;
            CP = string.Empty;
        }

        public string Calle { get; set; }

        public string NumeroExterior { get; set; }

        public string NumeroInterior { get; set; }

        public string Colonia { get; set; }

        public string Municipio { get; set; }

        public string estado { get; set; }

        public string CP { get; set; }
    }
}

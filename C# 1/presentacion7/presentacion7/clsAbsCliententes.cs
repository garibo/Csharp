using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion7
{
    public abstract class clsAbsCliententes
    {
        public abstract int ID { get; set; }

        public abstract string Nombre { get; set; }

        public abstract string Clave { get; set; }

        public abstract string RFC { get; set; }

        public abstract int tipoRegimen { get; set; }

        public abstract string nombreContacto { get; set; }
    }
}

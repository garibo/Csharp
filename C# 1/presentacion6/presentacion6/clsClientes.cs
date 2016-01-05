using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion6
{
    class clsClientes
    {
        private int _IdCliente;

        public int IdCliente
        {
            get { return _IdCliente;  }
            set { _IdCliente = value; }
        }

        private string _Nombres;

        public string Nombres
        {
            get { return _Nombres;  }
            set { _Nombres = value; }
        }

        private string _Apellidos;

        public string Apellidos
        {
            get { return _Apellidos;  }
            set { _Apellidos = value; }
        }
    }
}

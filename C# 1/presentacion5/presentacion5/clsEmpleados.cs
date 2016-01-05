using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion5
{
    public class clsEmpleados
    {
        public clsEmpleados()
        {
            nombre = "";
            sueldoDiario = 0.0m;
            edad = 0;
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre;  }
            set { _nombre = value; }
        }

        public decimal sueldoDiario { get; set; }

        public int edad { get; set; }

        public decimal calculaSalario(int numeroDias)
        {
            return sueldoDiario * numeroDias;
        }
    }
}

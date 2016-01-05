using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion7
{
    public class clsArchivos : intSalidas
    {
        public void ImprimeCliente(clsAbsCliententes cliente)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\Kevin\Documents\archBitacora.log", true);
            ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.tipoRegimen == 1)
                ar.WriteLine("Tipo: PERSONA FISICA");
            else
                ar.WriteLine("Tipo: PERSONA MORAL");
            ar.WriteLine("RFC: " + cliente.RFC);
            ar.Close();
        }

        public void ImprimeDirecciones(clsDirecciones Direccion)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\Kevin\Documents\archBitacora.log", true);
            ar.WriteLine(Direccion.Calle + " N° " + Direccion.NumeroExterior);
            ar.WriteLine(Direccion.Colonia);
            ar.WriteLine(Direccion.CP);
            ar.WriteLine(Direccion.estado);
            ar.Close();
        }
    }
}

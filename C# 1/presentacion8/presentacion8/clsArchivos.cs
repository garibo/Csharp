using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion8
{
    public class clsArchivos : intSalidas
    {
        public void ImprimeCliente(clsAbsCliententes cliente)
        {
            int i = 0;
            bool bandera = true;
            while (bandera)
            {
                try
                {
                    StreamWriter ar = new StreamWriter(@"C:\Users\Kevin\Documents\archBitacora.log", true);
                    ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
                    if (cliente.tipoRegimen == 1)
                        ar.WriteLine("Tipo: PERSONA FISICA");
                    else
                        ar.WriteLine("Tipo: PERSONA MORAL");
                    ar.WriteLine("RFC: " + cliente.RFC);
                    ar.Close();
                    bandera = false;
                }
                catch(Exception e)
                {
                    i++;
                    if(i >= 200)
                        throw e;
                }
            }
            
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

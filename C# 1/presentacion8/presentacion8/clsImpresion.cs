using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion8
{
    public class clsImpresion : intSalidas
    {
        public void ImprimeCliente(clsAbsCliententes cliente)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cliente.Clave+" "+cliente.Nombre);
            if (cliente.tipoRegimen == 1)
                Console.WriteLine("Tipo: PERSONA FISICA");
            else
                Console.WriteLine("Tipo: PERSONA MORAL");
            Console.WriteLine("RFC: " + cliente.RFC);
            Console.ReadKey();
        }

        public void ImprimeDirecciones(clsDirecciones Direccion)
        {
            Console.WriteLine(Direccion.Calle + " N° " + Direccion.NumeroExterior);
            Console.WriteLine(Direccion.Colonia);
            Console.WriteLine(Direccion.CP);
            Console.WriteLine(Direccion.estado);
            Console.ReadKey();
        }
    }
}

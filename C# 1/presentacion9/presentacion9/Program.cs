using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion9
{
    class Program
    {
        static void Main(string[] args)
        {
            //clsMostrarArrayList Muestra = new clsMostrarArrayList();
            //Muestra.capturarDatos();
            //Muestra.imprimeDatos();

            clsMuestraHashTable muestraH = new clsMuestraHashTable();
            muestraH.agregarDatos();
            muestraH.imprimirDatos();
            muestraH.eliminarElemento("C001");
            muestraH.imprimirDatos();
        }
    }
}

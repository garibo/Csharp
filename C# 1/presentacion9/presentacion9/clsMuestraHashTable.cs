using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion9
{
    public class clsMuestraHashTable
    {
        Hashtable Tabla;

        public clsMuestraHashTable()
        {
            Tabla = new Hashtable();
        }

        public void agregarDatos()
        {
            Tabla.Add("C001", "Producto 1");
            Tabla.Add("B123", "Producto 2");
            Tabla.Add("J452", "Producto 3");
            Tabla.Add("Z099", "Producto 4");
        }

        public void imprimirDatos()
        {
            Console.WriteLine("Existen {0} elementos, dame la clave del producto:", Tabla.Count);
            string cadena = Console.ReadLine();
            if (Tabla[cadena] == null)
            {
                Console.WriteLine("El elemento no existe");
            }                
            else
            {
                Console.WriteLine("El elemento encontrado es: ");
                Console.WriteLine(Tabla[cadena]);
            }                
            Console.ReadKey();
        }

        public void eliminarElemento(string key)
        {
            Tabla.Remove(key);
        }
    }  
}

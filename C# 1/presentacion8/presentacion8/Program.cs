using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion8
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContactos cliente = new clsClientesConContactos(0, "Kevin", "GABK", "9311", 1, "Luis echeverria", "7531008638", "5370423", "garibokevin@gmail.com", "Ignacio comonfort", "95", string.Empty, "Centro", "Lazaro Cardenas", "Michoacan", "60950");

            intSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
                Impresion = new clsImpresion();
            else
                Impresion = new clsArchivos();
            try
            {
                Impresion.ImprimeCliente(cliente);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocurrio un error: " + e.Message);
                Console.ReadKey();
            }
            
        }
    }
}

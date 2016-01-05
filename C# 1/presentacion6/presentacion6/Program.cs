using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion6
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente = new clsClientesVentas();

            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Garibo Martell";
            Cliente.Nombres = "Esteban";

            Cliente.RFC = "GABK";
            Cliente.Direccion = "Ignacio comonfort #95";
            Cliente.Colonia = "Centro";
            Cliente.Municipio = "Lazaro Cardenas";
            Cliente.EsCredito = true;

            Console.WriteLine(Cliente.Apellidos+ " "+Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);

            if (Cliente.EsCredito)
                Console.WriteLine("El cliente tiene credito");
            else
                Console.WriteLine("El cliente no tiene credito");

            Console.ReadKey();

        }
    }
}

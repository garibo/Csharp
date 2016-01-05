using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado = new clsEmpleados();
            
            empleado.edad = 25;
            empleado.nombre = "Kevin Garibo";
            empleado.sueldoDiario = 12.5m;
            decimal total = empleado.calculaSalario(30);

            Console.WriteLine("El salario mensual del empleado {1} es: {0:C}",total, empleado.nombre);
            Console.ReadKey();
        }
    }
}

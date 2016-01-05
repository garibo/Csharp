using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursofacilito
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Mi nombre es {0} ",args[0]);
            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0d;
            string s = "Hola";
            bool flag = false;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("El valor de i es: {0}",i);
            Console.WriteLine("El valor de x es: {0:c}",x);
            Console.WriteLine("El valor de f es: {0:F2}",f);
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("l valor de cadena es: " + s);
            Console.WriteLine("El valor de bandera es: "+flag.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());

            Console.ReadKey();
        }
    }
}

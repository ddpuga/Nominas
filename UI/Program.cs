using Nominas.Core;
using System;

namespace Nominas.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado o1 = new Obrero("Pepe");
            Empleado d1 = new Directivo("Gnabry");

            Console.Write(d1);
            Console.WriteLine(" nomina: " + d1.calcularNomina(10));

            Console.Write(o1);
            Console.WriteLine(" nomina: " + o1.calcularNomina(10));


        }
    }
}

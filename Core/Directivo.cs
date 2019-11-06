using System;
using System.Collections.Generic;
using System.Text;

namespace Nominas.Core
{
    class Directivo : Empleado
    {
        public const int salarioPorHoraPrefijado = 100;
        public const int salarioBase = 1000;
        public Directivo(string nombre)
            :base(salarioPorHoraPrefijado, nombre)
        {

        }


        public override int calcularNomina(int hs)
        {
            return salarioBase + base.calcularNomina(hs);
        }

        public override string ToString()
        {
            return base.ToString() +  " directivo ";
        }
    }
}

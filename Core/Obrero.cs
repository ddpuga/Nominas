using System;
using System.Collections.Generic;
using System.Text;

namespace Nominas.Core
{
    class Obrero : Empleado
    {

        public const int salarioPorHoraPrefijado = 50;

        public Obrero(string nombre)
            :base(salarioPorHoraPrefijado, nombre)
        {
        }



        public string ToString(int hs)
        {
            return base.ToString() + " obrero " + hs;
        }
    }
}

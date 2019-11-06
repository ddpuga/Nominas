using System;
using System.Collections.Generic;
using System.Text;

namespace Nominas.Core
{
    public abstract class Empleado
    {

        int salarioPorHora;
        string nombre;

        public Empleado(int salarioPorHora, string nombre)
        {

            this.salarioPorHora = salarioPorHora;
            this.nombre = nombre;

        }

        public int SalarioPorHora
        {
            get;set;
        }

        public string Nombre
        {
            get; set;
        }

        public virtual int calcularNomina(int hs)
        {
            return this.salarioPorHora * hs;
        }

        public override string ToString()
        {
            return "Empleado: " + this.nombre + " Salario/hora: " + this.salarioPorHora;
        }
    }
}

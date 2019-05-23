using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Personal
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        enum EstadoCivil { Casado, Soltero}
        enum Genero { Masculino, Femenino}
        enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}

        public struct Fecha
        {
            int dia;
            int mes;
            int año;
        }

        public struct Empleado
        {
            string nombre;
            string apellido;
            Fecha fechaNacimiento;
            EstadoCivil estadoCivil;
            Genero genero;
            Fecha fechaIngreso;
            double sueldo;
            Cargo cargo;
        }
    }
}

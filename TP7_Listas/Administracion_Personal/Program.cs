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
            Random random = new Random();
            int ale = random.Next(4, 10);
            int ale2;
            Nombres nom;
            Apellidos apel;
            DateTime fNac, fIng;
            EstadoCivil eCivil;
            Genero gen;
            Cargo car;
            DateTime fechaActual = new DateTime(2019, 5, 21);
            DateTime rangoMinFecha = new DateTime(1960, 1, 1);
            int rangoFecha = (fechaActual - rangoMinFecha).Days;
            //DateTime fechaActual = DateTime.Now();
            //DateTime fechaActual = new DateTime(1999, 04, 24);
            //DateTime fechaActual = DateTime(1995, 1, 1);
            //DateTime FechaInicial = DateTime(1960, 1, 1);
            //int rango = (fechaActual - fechaIncial).Days;
            //Console.WriteLine("fecha : {0}", fechaActual.ToString());
            //DateTime fechaAleatoria = fechaInicial.AddDays(rand.Next(rango));

            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado = new Empleado();
            
            //Cargar empleados en la lista
            for(int i = 0; i < ale; i++)
            {
                //Seleccion aleatoria de nombres
                ale2 = random.Next(9);
                switch(ale2)
                {
                    case 0: nom = Nombres.Facundo;
                    break;

                    case 1: nom = Nombres.Rafael;
                    break;

                    case 2: nom = Nombres.Julieta;
                    break;

                    case 3: nom = Nombres.Nicole;
                    break;

                    case 4: nom = Nombres.Tomas;
                    break;

                    case 5: nom = Nombres.Camila;
                    break;

                    case 6: nom = Nombres.Lionel;
                    break;

                    case 7: nom = Nombres.Daniela;
                    break;

                    case 8: nom = Nombres.Santiago;
                    break;

                    case 9: nom = Nombres.Martina;
                    break;
                }

                //Seleccion aleatoria de apellidos
                ale2 = random.Next(9);
                switch (ale2)
                {
                    case 0:
                        apel = Apellidos.Castro;
                        break;

                    case 1:
                        apel = Apellidos.Rojo;
                        break;

                    case 2:
                        apel = Apellidos.Aymar;
                        break;

                    case 3:
                        apel = Apellidos.Stark;
                        break;

                    case 4:
                        apel = Apellidos.Gutierrez;
                        break;

                    case 5:
                        apel = Apellidos.Perez;
                        break;

                    case 6:
                        apel = Apellidos.Acosta;
                        break;

                    case 7:
                        apel = Apellidos.Ayala;
                        break;

                    case 8:
                        apel = Apellidos.Albornoz;
                        break;

                    case 9:
                        apel = Apellidos.Reynoso;
                        break;
                }

                //Fecha aleatoria de nacimiento
                fNac = rangoMinFecha.AddDays(random.Next(rangoFecha));

                //Estado Civil
                ale2 = random.Next(1);
                switch(ale2)
                {
                    case 0:
                        eCivil = EstadoCivil.Casado;
                        break;
                    case 1:
                        eCivil = EstadoCivil.Soltero;
                        break;
                }

                //Genero
                ale2 = random.Next(1);
                switch(ale2)
                {
                    case 0:
                        gen = Genero.Masculino;
                        break;
                    case 1:
                        gen = Genero.Femenino;
                        break;
                }

                //Fecha de ingreso
                fIng = rangoMinFecha.AddDays(random.Next(rangoFecha));

                //Cargo
                ale2 = random.Next(4);
                switch(ale2)
                {
                    case 0:
                        car = Cargo.Auxiliar;
                        break;
                    case 1:
                        car = Cargo.Administrativo;
                        break;
                    case 2:
                        car = Cargo.Ingeniero;
                        break;
                    case 3:
                        car = Cargo.Especialista;
                        break;
                    case 4:
                        car = Cargo.Investigador;
                        break;
                }

                empleado.CargarEmpleado(nom, apel, fNac, eCivil, gen, fIng, car);
            }
            //Menu(empleados);
        }

        public enum Nombres { Facundo, Rafael, Julieta, Nicole, Tomas, Camila, Lionel, Daniela, Santiago, Martina}
        public enum Apellidos { Castro, Rojo, Aymar, Stark, Gutierrez, Perez, Acosta, Ayala, Albornoz, Reynoso}

        public enum EstadoCivil { Casado, Soltero}
        public enum Genero { Masculino, Femenino}
        public enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}


        public struct Empleado
        {
            Nombres nombre;
            Apellidos apellido;
            DateTime fechaNacimiento;
            EstadoCivil estadoCivil;
            Genero genero;
            DateTime fechaIngreso;
            double sueldo;
            Cargo cargo;

            public void CargarEmpleado(Nombres _nombre, Apellidos _apellido, DateTime _fechaNacimiento, EstadoCivil _estadoCivil, Genero _genero, DateTime _fechaIngreso, Cargo _cargo)
            {
                nombre = _nombre;
                apellido = _apellido;
                fechaNacimiento = _fechaNacimiento;
                estadoCivil = _estadoCivil;
                genero = _genero;
                fechaIngreso = _fechaIngreso;
                sueldo = 12500;
                cargo = _cargo;
            }

            public void MostrarEmpleado()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine("Fecha de nacimiento: ");
                Console.WriteLine("Genero: " + genero);
                Console.WriteLine("Fecha de ingreso: ");
                Console.WriteLine("Sueldo Basico: $" + sueldo);
                Console.WriteLine("Cargo: " + cargo);
            }
        }

        public static void Menu(Empleado empleados)
        {
            int seleccion, ale;

            do
            {
                seleccion = Convert.ToInt32(Console.ReadLine());
                

            }
            while (seleccion != 0);
        }
    }
}

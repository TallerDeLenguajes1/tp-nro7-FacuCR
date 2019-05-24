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
            //Valor aleatorio de empleados
            int ale = random.Next(4, 20);
            //Valores aleatorios para los enum
            int ale2;

            string nom = null;
            string apel = null;
            DateTime fNac, fIng;
            string eCivil = null;
            string gen = null;
            string car = null;

            DateTime fechaActual = DateTime.Now;
            DateTime rangoFechaMax = new DateTime(1997, 1, 1);
            DateTime rangoMinFecha = new DateTime(1960, 1, 1);
            int rangoFechaIng;
            int rangoFecha = (rangoFechaMax - rangoMinFecha).Days;

            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado = new Empleado();
            
            //Cargar una cantidad aleatoria de empleados en la lista
            for(int i = 0; i < ale; i++)
            {
                //Seleccion aleatoria de nombres
                ale2 = random.Next(9);
                switch (ale2)
                {
                    case 0:
                        nom = Nombres.Facundo.ToString();
                        break;

                    case 1:
                        nom = Nombres.Rafael.ToString();
                        break;

                    case 2:
                        nom = Nombres.Julieta.ToString();
                        break;

                    case 3:
                        nom = Nombres.Nicole.ToString();
                        break;

                    case 4:
                        nom = Nombres.Tomas.ToString();
                        break;

                    case 5:
                        nom = Nombres.Camila.ToString();
                        break;

                    case 6:
                        nom = Nombres.Lionel.ToString();
                        break;

                    case 7:
                        nom = Nombres.Daniela.ToString();
                        break;

                    case 8:
                        nom = Nombres.Santiago.ToString();
                        break;

                    case 9:
                        nom = Nombres.Martina.ToString();
                        break;
                }

                //Seleccion aleatoria de apellidos
                ale2 = random.Next(9);
                switch (ale2)
                {
                    case 0:
                        apel = Apellidos.Castro.ToString();
                        break;

                    case 1:
                        apel = Apellidos.Rojo.ToString();
                        break;

                    case 2:
                        apel = Apellidos.Aymar.ToString();
                        break;

                    case 3:
                        apel = Apellidos.Stark.ToString();
                        break;

                    case 4:
                        apel = Apellidos.Gutierrez.ToString();
                        break;

                    case 5:
                        apel = Apellidos.Perez.ToString();
                        break;

                    case 6:
                        apel = Apellidos.Acosta.ToString();
                        break;

                    case 7:
                        apel = Apellidos.Ayala.ToString();
                        break;

                    case 8:
                        apel = Apellidos.Albornoz.ToString();
                        break;

                    case 9:
                        apel = Apellidos.Reynoso.ToString();
                        break;
                }

                //Fecha aleatoria de nacimiento
                fNac = rangoMinFecha.AddDays(random.Next(rangoFecha));

                //Estado Civil
                ale2 = random.Next(1);
                switch(ale2)
                {
                    case 0:
                        eCivil = EstadoCivil.Casado.ToString();
                        break;
                    case 1:
                        eCivil = EstadoCivil.Soltero.ToString();
                        break;
                }

                //Genero
                ale2 = random.Next(1);
                switch(ale2)
                {
                    case 0:
                        gen = Genero.Masculino.ToString();
                        break;
                    case 1:
                        gen = Genero.Femenino.ToString();
                        break;
                }

                //Fecha de ingreso
                rangoFechaIng = (fechaActual - fNac).Days;
                fIng = fNac.AddDays(random.Next(rangoFechaIng));

                //Cargo
                ale2 = random.Next(4);
                switch(ale2)
                {
                    case 0:
                        car = Cargo.Auxiliar.ToString();
                        break;
                    case 1:
                        car = Cargo.Administrativo.ToString();
                        break;
                    case 2:
                        car = Cargo.Ingeniero.ToString();
                        break;
                    case 3:
                        car = Cargo.Especialista.ToString();
                        break;
                    case 4:
                        car = Cargo.Investigador.ToString();
                        break;
                }
                
                //Creo un empleado
                empleado.CargarEmpleado(nom, apel, fNac, eCivil, gen, fIng, car);

                //Lo cargo en la lista
                empleados.Add(empleado);
            }

            Menu(empleados);
        }

        public enum Nombres { Facundo, Rafael, Julieta, Nicole, Tomas, Camila, Lionel, Daniela, Santiago, Martina}
        public enum Apellidos { Castro, Rojo, Aymar, Stark, Gutierrez, Perez, Acosta, Ayala, Albornoz, Reynoso}

        public enum EstadoCivil { Casado, Soltero}
        public enum Genero { Masculino, Femenino}
        public enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}


        public struct Empleado
        {
            string nombre;
            string apellido;
            DateTime fechaNacimiento;
            string estadoCivil;
            string genero;
            DateTime fechaIngreso;
            double sueldo;
            string cargo;

            public void CargarEmpleado(string _nombre, string _apellido, DateTime _fechaNacimiento, string _estadoCivil, string _genero, DateTime _fechaIngreso, string _cargo)
            {


                nombre = _nombre;
                apellido = _apellido;
                fechaNacimiento = _fechaNacimiento;
                estadoCivil = _estadoCivil;
                genero = _genero;
                fechaIngreso = _fechaIngreso;
                sueldo = 15000;
                cargo = _cargo;
            }

            public void MostrarEmpleado()
            {
                Console.WriteLine("\n===============Datos del Empleado==============\n");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento);
                Console.WriteLine("Genero: " + genero);
                Console.WriteLine("Fecha de ingreso: " + fechaIngreso);
                Console.WriteLine("Sueldo Basico: $" + sueldo);
                Console.WriteLine("Cargo: " + cargo);
                Console.WriteLine("\n===============================================\n");
            }

            public int CalcularAntiguedad()
            {
                DateTime fechaActual = DateTime.Today;

                int antiguedad = (fechaActual.Year - fechaIngreso.Year);

                return antiguedad;
            }

            public int CalcularEdad()
            {
                DateTime fechaActual = DateTime.Today;

                int edad = (fechaActual.Year - fechaNacimiento.Year);

                return edad;
            }

            public double CalcularAdicional()
            {
                Random random = new Random();
                int hijos = random.Next(5);
                int antiguedad = CalcularAntiguedad();
                int cont = 0;
                double adicional = 0, porcentajeSueldo = 0, porcentajeCargo = 0;

                //Calcular el porcentaje del sueldo segun la antiguedad
                if (antiguedad > 19)
                {
                    porcentajeSueldo = 0.25;
                }
                else
                {
                    while (cont < antiguedad)
                    {
                        porcentajeSueldo += 0.02;
                        cont++;
                    }
                }

                //Consultar si es casado y con 2 o mas hijos
                bool casado = string.Equals(estadoCivil, EstadoCivil.Casado.ToString());

                if(casado && hijos > 1)
                {
                    adicional += 5000;
                }

                adicional = adicional + (sueldo * porcentajeSueldo);

                //Porcentaje segun el cargo
                bool pComparacion = string.Equals(cargo, Cargo.Ingeniero.ToString());
                bool sComparacion = string.Equals(cargo, Cargo.Especialista.ToString());

                if (pComparacion || sComparacion)
                {
                    porcentajeCargo += 0.50;
                    adicional = adicional + (adicional * porcentajeCargo);
                }

                return adicional;

            }

            public double CalcularSalario()
            {
                double salario = sueldo + CalcularAdicional();

                return salario;
            }

            public int Jubilacion()
            {
                int jubilacion;
                bool compGenero = string.Equals(genero, Genero.Masculino.ToString());

                if(compGenero)
                {
                    return jubilacion = 65 - CalcularEdad();
                }
                else
                {
                    return jubilacion = 65 - CalcularEdad();
                }
            }
        }

        public static void Menu(List<Empleado> lista)
        {
            int seleccion, seleccionEmp;

            do
            {
                Console.WriteLine("\n.::==MENU==::.\n");

                Console.WriteLine("\n1. Mostrar todos los empleados\n2. Seleccionar un empleado\n3. Mostrar salario total\n4. Cantidad total de empleados\n5. Salir");

                seleccion = Convert.ToInt32(Console.ReadLine());

                switch(seleccion)
                {
                    case 1:
                        MostrarLista(lista);
                        break;

                    case 2:
                        Console.WriteLine("Seleccione un empleado");

                        seleccionEmp = Convert.ToInt32(Console.ReadLine());

                        MenuEmpleado(lista[seleccionEmp]);

                        break;

                    case 3:
                        SalarioTotal(lista);
                        break;

                    case 4:
                        CantidadEmpleados(lista);
                        break;
                }
                

            }
            while (seleccion != 5);
        }

        public static void MenuEmpleado(Empleado empleado)
        {
            int seleccion;

            do
            {
                Console.WriteLine("\n.::==MENU DE EMPLEADO==::.\n");
                Console.WriteLine("\n1. Antiguedad del empleado\n2. Edad del empleado\n3. Cuando falta para su jubilacion\n4. Salario\n5. Salir");

                seleccion = Convert.ToInt16(Console.ReadLine());

                switch(seleccion)
                {
                    case 1:
                        Console.WriteLine("\nLa antiguedad del empleado es: {0} año(s)\n", empleado.CalcularAntiguedad());
                        break;
                    case 2:
                        Console.WriteLine("\nLa edad del empleado es: {0} años\n", empleado.CalcularEdad());
                        break;
                    case 3:
                        Console.WriteLine("\nAl empleado le faltan {0} años para jubilarse\n", empleado.Jubilacion());
                        break;
                    case 4:
                        Console.WriteLine("\nEl salario del empleado es: ${0}\n", empleado.CalcularSalario());
                        break;
                }
            }
            while (seleccion != 5);
        }

        public static void MostrarLista(List<Empleado> lista)
        {
            int cont = 0;

            foreach(Empleado elemento in lista)
            {
                Console.WriteLine("\n====Empleado {0}====\n", cont);

                elemento.MostrarEmpleado();

                cont++;
            }
        }

        public static void SalarioTotal(List<Empleado> lista)
        {
            double salarioTotal = 0;

            foreach(Empleado elemento in lista)
            {
                salarioTotal += elemento.CalcularSalario();
            }

            Console.WriteLine("\nMonto total a pagar: ${0}\n", salarioTotal);
        }

        public static void CantidadEmpleados(List<Empleado> lista)
        {
            int cont = 0;

            foreach(Empleado elemento in lista)
            {
                cont++;
            }

            Console.WriteLine("\nLa cantidad total de empleados es: {0}\n", cont);
        }
    }
}

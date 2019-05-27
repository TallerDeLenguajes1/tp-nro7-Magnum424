using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp7
{
    class Program
    {
        ////Enumeraciones
        public enum Cargos { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
        public enum EstadoCivil { Solterx, Casadx, Viudx, Complicado }
        public enum Género { Masculino, Femenino }

        ////Estructura de datos de los empleados
        public struct DatosEmpleado
        {
            ////Datos de los empleados
            public string nombre;
            public string apellido;
            public DateTime fechaNac;
            public EstadoCivil estadoCivil;
            public Género género;
            public DateTime fechaIng;
            public double sueldoBasico;
            public Cargos cargo;
            ////Constructor de la estructura
            public DatosEmpleado(string nombre, string apellido, DateTime fechaNac, EstadoCivil estadoCivil, Género género, DateTime fechaIng, double sueldoBasico, Cargos cargo)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.fechaNac = fechaNac;
                this.estadoCivil = estadoCivil;
                this.género = género;
                this.fechaIng = fechaIng;
                this.sueldoBasico = sueldoBasico;
                this.cargo = cargo;
            }
            ////Metodos par mostrar los datos de los empleados
            ///Una forma de mostrar los empleados(Toma un empleado en especifico)
            public void MostrarEmpleados(DatosEmpleado Empleado)
            {
                Console.WriteLine(Empleado.nombre);
                Console.WriteLine(Empleado.apellido);
                Console.WriteLine(Empleado.fechaNac.ToShortDateString());
                Console.WriteLine(Empleado.estadoCivil);
                Console.WriteLine(Empleado.género);
                Console.WriteLine(Empleado.fechaIng.ToShortDateString());
                Console.WriteLine(Empleado.sueldoBasico);
                Console.WriteLine(Empleado.cargo);
            }
            ///Otra forma de mostrar los empleados(toma el empleado que está en la instancia actual)
            public void MostrarEmpleados2()
            {
                Console.WriteLine(this.nombre);
                Console.WriteLine(this.apellido);
                Console.WriteLine(this.fechaNac.ToShortDateString());
                Console.WriteLine(this.estadoCivil);
                Console.WriteLine(this.género);
                Console.WriteLine(this.fechaIng.ToShortDateString());
                Console.WriteLine(this.sueldoBasico);
                Console.WriteLine(this.cargo);
            }
            ////Calculo la edad
            public void CalculoEdad()
            {
                DateTime hoy = DateTime.Today;
                TimeSpan edad = (hoy - this.fechaNac);
                Console.WriteLine("La edad es: {0}", edad.ToString());
            }
            ////Calculo la antiguedad
            public void CalculoAntiguedad()
            {
                DateTime hoy = DateTime.Today;
                TimeSpan antiguedad = (hoy - this.fechaIng);
                Console.WriteLine("La antiguedad del empleado en la empresa es: {0}", antiguedad.ToString());
            }
        }
        static void Main(string[] args)
        {
            ////Declaro la variable de nuevo empleado
            DatosEmpleado NuevoEmpleado;

            ////Creo variables auxiliares
            int dia, mes, año;
            EstadoCivil Est;
            Género Gen;
            Cargos Car;

            ////Arrays con datos requeridos
            string[] Apellidos = new string[] { "Pérez", "Gomez", "Abduzcan" };
            string[] NombresMasc = new string[] { "Juan", "Jorge", "Pedro" };
            string[] NombresFem = new string[] { "Ana", "María", "Juana" };

            ////Creo el objeto aleatorio
            Random rdn = new Random();

            ////Creo la lista de empleados
            List<DatosEmpleado> ListaDeEmpleados = new List<DatosEmpleado>();

            ////Datos para la carga
            for (int i = 0; i < 2; i++)
            {
                ////Tomo 3 numeros aleatorios para la fecha de nacimiento
                dia = rdn.Next(1, 31);
                mes = rdn.Next(1, 13);
                año = rdn.Next(1970, 1990);

                ////Creo una variable DateTime a la cual le inserto los valores obtenidos
                DateTime FechaNac = new DateTime(año, mes, dia);

                ////Repito el proceso para la fecha de ingreso
                dia = rdn.Next(1, 31);
                mes = rdn.Next(1, 13);
                año = rdn.Next(2000, 2020);

                ////Fecha de ingreso
                DateTime FechaIng = new DateTime(año, mes, dia);

                ////Defino el Estado civil, el genero y el cargo
                Est = (EstadoCivil)rdn.Next(0, 4);
                Gen = (Género)rdn.Next(0, 2);
                Car = (Cargos)rdn.Next(0, 5);

                ////Dependiendo si es Hombre o Mujer se le asigna un nombre apropiado
                if (Gen == Género.Masculino)
                {
                    NuevoEmpleado = new DatosEmpleado(NombresMasc[rdn.Next(0, 3)], Apellidos[rdn.Next(0, 3)], FechaNac, Est, Gen, FechaIng, rdn.Next(10000, 20000), Car);
                }
                else
                {
                    NuevoEmpleado = new DatosEmpleado(NombresFem[rdn.Next(0, 3)], Apellidos[rdn.Next(0, 3)], FechaNac, Est, Gen, FechaIng, rdn.Next(10000, 20000), Car);
                }

                ////Agrego al nuevo empleado a la lista
                ListaDeEmpleados.Add(NuevoEmpleado);
            }
            ////Muestro los empleados en la lista
            foreach (DatosEmpleado empleado in ListaDeEmpleados)
            {
                empleado.MostrarEmpleados2();
                Console.Write("\n");
                empleado.CalculoEdad();
                Console.Write("\n");
                empleado.CalculoAntiguedad();
                Console.Write("\n");
                Console.ReadKey();
            }
        }
    }
}

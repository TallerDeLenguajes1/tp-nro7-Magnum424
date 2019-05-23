using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp7
{
    class Program
    {
        //Enumeraciones
        public enum Cargos { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
        public enum EstadoCivil { Solterx, Casadx, Viudx, Complicado }
        public enum Género { Masculino, Femenino }
        //Estructura de datos de los empleados
        public struct DatosEmpleado
        {
            //Datos de los empleados
            public string nombre;
            public string apellido;
            public DateTime fechaNac;
            public EstadoCivil estadoCivil;
            public Género género;
            public DateTime fechaIng;
            public double sueldoBasico;
            public Cargos cargo;
            //Constructor de la estructura
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
        }
        static void Main(string[] args)
        {
            int dia, mes, año;
            
            //Arrays con datos requeridos
            string[] Apellidos = new string[] { "Pérez", "Gomez", "Abduzcan" };
            string[] NombresMasc = new string[] { "Juan", "Jorge", "Pedro" };
            string[] NombresFem = new string[] { "Ana", "María", "Juana" };
            
            //Creo el objeto aleatorio
            Random rdn = new Random(); 
            //Creo la lista de empleados
            List<DatosEmpleado> ListaDeEmpleados = new List<DatosEmpleado>();
            
            //Datos para la carga
            //Tomo 3 numeros aleatorios para la fecha de nacimiento
            dia = rdn.Next(1, 31);
            mes = rdn.Next(1, 13);
            año = rdn.Next(1970, 2000);
            //Creo una variable DateTime a la cual le inserto los valores obtenidos
            DateTime FechaNac = new DateTime(año, mes, dia);
            
            //Repito el proceso para la fecha de ingreso
            dia = rdn.Next(1, 31);
            mes = rdn.Next(1, 13);
            año = rdn.Next(2000, 2020);
            //Fecha de ingreso
            DateTime FechaIng = new DateTime(año, mes, dia);



        }
    }
}

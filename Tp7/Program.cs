using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp7
{
    class Program
    {
        public struct DatosEmpleado
        {
            public string nombre;
            public string apellido;
            public int diaNac;
            public int mesNac;
            public int añoNac;
            public string estadoCivil;
            public string género;
            public int diaIngreso;
            public int mesIngreso;
            public int añoIngreso;
            public double sueldoBasico;
            public string cargo;

            public void CargarDatos()
            {



            }
        }
        public class Datos
        {
            enum Cargos {Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}
            enum NombresMasc {Juan, Jorge, Pedro, Vladimir}
            enum NombresFem {Ana, Micaela, María, Zina}
            enum EstadoCivil {Solterx, Casadx, Viudx, Complicado}
            enum Género {Masculino, Femenino}
            enum Apellidos {Pérez, Gomez, Rodriguez, Hitler}
        }
        static void Main(string[] args)
        {
            List<DatosEmpleado> ListaDeEmpleados = new List<DatosEmpleado>();
        }
    }
}

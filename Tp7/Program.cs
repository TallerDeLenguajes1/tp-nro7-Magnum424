using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp7
{
    class Program
    {
        public struct Datos
        {
            public string Nombre;
            public string Apellido;
            public int DiaNac;
            public int MesNac;
            public int AñoNac;
            public bool EstadoCivil;
            public bool Género;
            public int DiaIngreso;
            public int MesIngreso;
            public int AñoIngreso;
            public double SueldoBasico;
            public string Cargo;
        }
        public class Trabajo
        {
            enum Cargos {Auxiliar, Administrativo, Ingeniero, Especialista, Investigador}
        }
        static void Main(string[] args)
        {
            List<Datos> ListaDeEmpleados = new List<Datos>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante: Persona
    {
        string establecimiento;
        string nivel;
        string nombreCarrera;

        public Estudiante()
        {

        }

        public Estudiante(string nombre, string apellido, int edad, string sexo, int dni, string localidad, string estadoCivil, int cantidadHijos, string nivelEstudio, string establecimiento, string nivel, string nombreCarrera): base(nombre, apellido, edad, sexo, dni, localidad, estadoCivil, cantidadHijos, nivelEstudio)
        {
            this.establecimiento = establecimiento;
            this.nivel = nivel;
            this.nombreCarrera = nombreCarrera;
        }


        public string Establecimiento
        {
            get { return establecimiento; }
            set { establecimiento = value; }
        }

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        public string NombreCarrera
        {
            get { return nombreCarrera; }
            set { nombreCarrera = value; }
        }

        public override bool VerificarDatos(string nombre, string apellido, string edad, string dni, string localidad, string cantidadHijos, string horasSemanales, string establecimiento, string titulo)
        {
            int edadInt;
            int dniInt;
            int cantidadHijosInt;
            

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) &&
                int.TryParse(edad, out edadInt) && edadInt > 0 && edadInt < 120 &&
                int.TryParse(dni, out dniInt) && dniInt > 15000000 && dniInt < 70000000 &&
                !string.IsNullOrEmpty(localidad) &&
                int.TryParse(cantidadHijos, out cantidadHijosInt) && cantidadHijosInt >= 0 &&
                !string.IsNullOrEmpty(establecimiento) && !string.IsNullOrEmpty(titulo))
            {
                return true;
            }

            return false;
        }
    }
}

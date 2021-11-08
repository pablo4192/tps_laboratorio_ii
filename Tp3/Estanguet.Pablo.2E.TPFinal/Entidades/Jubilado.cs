using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jubilado: Persona
    {
        int anioJubilacion;
        bool sigueTrabajando;

        public Jubilado()
        {

        }

        public Jubilado(string nombre, string apellido, int edad, string sexo, int dni, string localidad, string estadoCivil, int cantidadHijos, string nivelEstudio, int anioJubilacion, bool sigueTrabajando): base(nombre, apellido, edad, sexo, dni, localidad, estadoCivil, cantidadHijos, nivelEstudio)
        {
            this.anioJubilacion = anioJubilacion;
            this.sigueTrabajando = sigueTrabajando;
        }

        public int AnioJubilacion
        {
            get { return anioJubilacion; }
            set { anioJubilacion = value; }
        }

        public bool SigueTrabajando
        {
            get { return sigueTrabajando; }
            set { sigueTrabajando = value; }
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
                int.TryParse(cantidadHijos, out cantidadHijosInt) && cantidadHijosInt >= 0)
            {
                return true;
            }

            return false;
        }


    }
}

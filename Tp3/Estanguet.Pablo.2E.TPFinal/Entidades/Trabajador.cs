using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trabajador: Persona
    {
        bool trabajoRegistrado;
        bool relacionDeDependencia;
        int horasSemanales;

        public Trabajador()
        {

        }
        

        public Trabajador(string nombre, string apellido, int edad, string sexo, int dni, string localidad, string estadoCivil, int cantidadHijos, string nivelEstudio, bool trabajoRegistrado, bool relacionDeDependencia, int horasSemanales) : base(nombre, apellido, edad, sexo, dni, localidad, estadoCivil, cantidadHijos, nivelEstudio)
        {
            this.trabajoRegistrado = trabajoRegistrado;
            this.relacionDeDependencia = relacionDeDependencia;
            this.horasSemanales = horasSemanales;
        }

        public bool TrabajoRegistrado
        {
            get { return trabajoRegistrado; }
            set { trabajoRegistrado = value; }
        }

        public bool RelacionDeDependencia
        {
            get { return relacionDeDependencia; }
            set { relacionDeDependencia = value; }
        }

        public int HorasSemanales
        {
            get { return horasSemanales; }
            set { horasSemanales = value; }
        }

        public override bool VerificarDatos(string nombre, string apellido, string edad, string dni, string localidad, string cantidadHijos, string horasSemanales, string establecimiento, string titulo)
        {
            int edadInt;
            int dniInt;
            int cantidadHijosInt;
            int horasSemanalesInt;

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) &&
                int.TryParse(edad, out edadInt) && edadInt > 0 && edadInt < 120 && 
                int.TryParse(dni, out dniInt) && dniInt > 15000000 && dniInt < 70000000 &&
                !string.IsNullOrEmpty(localidad) && 
                int.TryParse(cantidadHijos,out cantidadHijosInt) && cantidadHijosInt >= 0 &&
                int.TryParse(horasSemanales,out horasSemanalesInt) && horasSemanalesInt > 0)
            {
                return true;
            }

            return false;
        }

    }
}

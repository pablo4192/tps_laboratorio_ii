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
            this.Establecimiento = establecimiento;
            this.Nivel = nivel;
            this.NombreCarrera = nombreCarrera;
        }


        public string Establecimiento
        {
            get { return establecimiento; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                {
                    establecimiento = value;
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }
               
            }
        }

        public string Nivel
        {
            get { return nivel; }
            set 
            {
                if(value == "Secundario" || value == "Terciario" || value == "Universitario")
                {
                    nivel = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public string NombreCarrera
        {
            get { return nombreCarrera; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                {
                    nombreCarrera = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public override bool VerificarDatosInt(string edad, string dni, string cantidadHijos, string horasSemanales)
        {
            int edadInt;
            int dniInt;
            int cantidadHijosInt;
            

            if (
                int.TryParse(edad, out edadInt) && 
                int.TryParse(dni, out dniInt) && 
                int.TryParse(cantidadHijos, out cantidadHijosInt) 
                )
            {
                return true;
            }

            return false;
        }
    }
}

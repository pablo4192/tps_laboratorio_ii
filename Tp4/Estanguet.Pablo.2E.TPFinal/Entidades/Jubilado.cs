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
            this.AnioJubilacion = anioJubilacion;
            this.SigueTrabajando = sigueTrabajando;
        }

        public int AnioJubilacion
        {
            get { return anioJubilacion; }
            set 
            { 
                if(value > 1970 && value < 2022)
                {
                    anioJubilacion = value;
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }
                
            }
        }

        public bool SigueTrabajando
        {
            get { return sigueTrabajando; }
            set 
            {
                if(value == true || value == false)
                {
                    sigueTrabajando = value; 
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
                int.TryParse(cantidadHijos, out cantidadHijosInt) )
            {
                return true;
            }

            return false;
        }


    }
}

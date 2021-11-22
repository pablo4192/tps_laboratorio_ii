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
            this.TrabajoRegistrado = trabajoRegistrado;
            this.RelacionDeDependencia = relacionDeDependencia;
            this.HorasSemanales = horasSemanales;
        }

        public bool TrabajoRegistrado
        {
            get { return trabajoRegistrado; }

            set 
            {   
                //if(value == true || value == false)
                //{
                    trabajoRegistrado = value;
                //}
                //else
                //{
                //    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                //    throw datosInvalidos;
                //}
                
            }
        }

        public bool RelacionDeDependencia
        {
            get { return relacionDeDependencia; }
            set 
            { 
                if(value == true || value == false)
                {
                    relacionDeDependencia = value;
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }
                
            }
        }

        public int HorasSemanales
        {
            get { return horasSemanales; }
            set 
            {   
                if(value > 0 && value < 168)
                {
                    horasSemanales = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public override bool VerificarDatosInt( string edad, string dni, string cantidadHijos, string horasSemanales)
        {
            int edadInt;
            int dniInt;
            int cantidadHijosInt;
            int horasSemanalesInt;

            if(
                int.TryParse(edad, out edadInt) && 
                int.TryParse(dni, out dniInt) && 
                int.TryParse(cantidadHijos,out cantidadHijosInt) && 
                int.TryParse(horasSemanales,out horasSemanalesInt) )
            {
                return true;
            }

            return false;
        }

    }
}

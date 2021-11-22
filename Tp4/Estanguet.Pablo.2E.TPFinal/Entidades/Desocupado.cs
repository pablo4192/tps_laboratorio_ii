using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Desocupado : Persona
    {
        DateTime fechaUltimoTrabajo;
        bool recibeAyudaEstatal;

        public Desocupado()
        {

        }

        public Desocupado(string nombre, string apellido, int edad, string sexo, int dni, string localidad, string estadoCivil, int cantidadHijos, string nivelEstudio, DateTime fechaUltimoTrabajo, bool recibeAyudaEstatal) : base(nombre, apellido, edad, sexo, dni, localidad, estadoCivil, cantidadHijos, nivelEstudio)
        {
            this.FechaUltimoTrabajo = fechaUltimoTrabajo;
            this.RecibeAyudaEstatal = recibeAyudaEstatal;
        }

        public DateTime FechaUltimoTrabajo
        {
            get { return fechaUltimoTrabajo; }
            set { fechaUltimoTrabajo = value; }
        }

        public bool RecibeAyudaEstatal
        {
            get { return recibeAyudaEstatal; }
            set 
            { 
                if(value == true || value == false)
                {
                    recibeAyudaEstatal = value; 
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

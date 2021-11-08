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
            this.fechaUltimoTrabajo = fechaUltimoTrabajo;
            this.recibeAyudaEstatal = recibeAyudaEstatal;
        }

        public DateTime FechaUltimoTrabajo
        {
            get { return fechaUltimoTrabajo; }
            set { fechaUltimoTrabajo = value; }
        }

        public bool RecibeAyudaEstatal
        {
            get { return recibeAyudaEstatal; }
            set { recibeAyudaEstatal = value; }
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
                int.TryParse(cantidadHijos, out cantidadHijosInt) && cantidadHijosInt >= 0 )
            {
                return true;
            }

            return false;
        }
    }
}

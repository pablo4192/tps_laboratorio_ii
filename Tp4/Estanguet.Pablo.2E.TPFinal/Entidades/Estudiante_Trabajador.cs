using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante_Trabajador: Estudiante, ITrabajo
    {
        public Estudiante_Trabajador()
        {

        }

        public Estudiante_Trabajador(string nombre, string apellido, int edad, string sexo, int dni, string localidad, string estadoCivil, int cantidadHijos, string nivelEstudio, string establecimiento, string nivel, string nombreCarrera, bool trabajoRegistrado, bool relacionDeDependencia, int horasSemanales): base(nombre, apellido, edad, sexo, dni, localidad, estadoCivil, cantidadHijos, nivelEstudio, establecimiento, nivel, nombreCarrera)
        {
            this.TrabajoRegistrado = trabajoRegistrado;
            this.RelacionDeDependencia = relacionDeDependencia;
            this.HorasSemanales = horasSemanales;
        }

        public bool TrabajoRegistrado { get ; set ; }
        public bool RelacionDeDependencia { get ; set ; }
        public int HorasSemanales { get ; set ; }
                
                    
                    
            

        //TENGO QUE VALIDAR LOS CAMPOS INT PARA QUE NO SEAN STRINGS

        public override bool VerificarDatosInt(string edad, string dni, string cantidadHijos, string horasSemanales)
        {
            int edadInt;
            int dniInt;
            int cantidadHijosInt;
            int horasSemanalesInt;

            if (
                int.TryParse(edad, out edadInt) &&
                int.TryParse(dni, out dniInt) &&
                int.TryParse(cantidadHijos, out cantidadHijosInt) &&
                int.TryParse(horasSemanales, out horasSemanalesInt) && horasSemanalesInt > 0)
            {
                return true;
            }

            return false;

        }



    }
}

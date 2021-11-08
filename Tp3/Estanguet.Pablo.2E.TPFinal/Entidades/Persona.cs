using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string sexo;
        private int dni;
        private string localidad;
        private string estadoCivil;
        private int cantidadHijos;
        private string nivelEstudioCompleto;


        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int edad, string sexo, int dni, string localidad, string estadoCivil, int cantidadHijos, string nivelEstudio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
            this.dni = dni;
            this.localidad = localidad;
            this.estadoCivil = estadoCivil;
            this.cantidadHijos = cantidadHijos;
            this.nivelEstudioCompleto = nivelEstudio;

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public int CantidadHijos
        {
            get { return cantidadHijos; }
            set { cantidadHijos = value; }
        }

        public string NivelEstudio
        {
            get { return nivelEstudioCompleto; }
            set { nivelEstudioCompleto = value; }
        }

        public abstract bool VerificarDatos(string nombre, string apellido, string edad, string dni, string localidad,  string cantidadHijos, string horasSemanales, string establecimiento, string titulo);

        



        



        


        


        


       


       



        
        


    }
}



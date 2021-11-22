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
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Dni = dni;
            this.Localidad = localidad;
            this.EstadoCivil = estadoCivil;
            this.CantidadHijos = cantidadHijos;
            this.NivelEstudio = nivelEstudio;

        }

        public string Nombre
        {
            get { return nombre; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                {
                    nombre = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public string Apellido
        {
            get { return apellido; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    apellido = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public int Edad
        {
            get { return edad; }
            set 
            { 
                if(value > 0 || value < 120)
                {
                    edad = value;
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }
                
            }
        }

        public string Sexo
        {
            get { return sexo; }
            set 
            { 
                if(value == "Masculino" || value == "Femenino" || value == "Otro")
                {
                    sexo = value;
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }
                
            }
        }

        public int Dni
        {
            get { return dni; }
            set 
            { 
                if(value > 10000000 && value < 70000000)
                {
                    dni = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public string Localidad
        {
            get { return localidad; }

            set 
            {   
                if(!string.IsNullOrEmpty(value))
                {
                    localidad = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public string EstadoCivil
        {
            get { return estadoCivil; }

            set 
            {
                if(value == "Soltero" || value == "Casado")
                {
                    estadoCivil = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public int CantidadHijos
        {
            get { return cantidadHijos; }
            set 
            { 
                if(value >= 0)
                {
                    cantidadHijos = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }

            }
        }

        public string NivelEstudio
        {
            get { return nivelEstudioCompleto; }
            set 
            { 
                if(value == "Primario" || value == "Secundario" || value == "Terciario" || value == "Universitario")
                {
                    nivelEstudioCompleto = value; 
                }
                else
                {
                    DatosInvalidosExcepcion datosInvalidos = new DatosInvalidosExcepcion();
                    throw datosInvalidos;
                }


            }
        }

        public abstract bool VerificarDatosInt( string edad, string dni, string cantidadHijos, string horasSemanales);

        



        



        


        


        


       


       



        
        


    }
}



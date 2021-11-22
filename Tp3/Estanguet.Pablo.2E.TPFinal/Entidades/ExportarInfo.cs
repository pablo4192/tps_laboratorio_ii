using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExportarInfo
    {
        public static event AvisarErrorArchivoDelegate avisarErrorDelegado;
        public static event AvisarExitoArchivoDelegate avisarExitoDelegado;

        static ExportarInfo()
        {
            
        }

        /// <summary>
        /// Exporta datos de informes en Csv segun tipo <T> pasado en la llamada
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listaInformes"></param>
        /// <param name="nombreArchivo"></param>
        public static void ExportarDatos<T>(List<T> listaInformes, string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Censo_Informes";

            StreamWriter escritor;

            if(nombreArchivo.VerificarNombreArchivo(nombreArchivo))
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                if (typeof(T) == typeof(Trabajador))
                {
                    escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv");

                    escritor.WriteLine("Trabajo Registrado;Relacion de dependencia;Horas semanales;Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");
                }
                else if (typeof(T) == typeof(Estudiante))
                {
                    escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv");

                    escritor.WriteLine("Establecimiento;Nivel;Carrera;Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");
                }
                else if (typeof(T) == typeof(Jubilado))
                {
                    escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv");

                    escritor.WriteLine("Anio jubilacion;Sigue trabajando?;Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");

                }
                else if (typeof(T) == typeof(Desocupado))
                {
                    escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv");

                    escritor.WriteLine("Fecha ultimo trabajo;Ayuda estatal;Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");
                }
                else
                {
                    escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv");

                    escritor.WriteLine("Trabajo Registrado;Relacion de dependencia;Horas semanales;Establecimiento;Nivel;Carrera;Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");
                }

                foreach (T item in listaInformes)
                {
                    Type tipo = item.GetType();

                    foreach (PropertyInfo item2 in tipo.GetProperties())
                    {
                        escritor.Write("{0};", item2.GetValue(item));
                    }
                    escritor.WriteLine();

                }
                escritor.Close();

                if(avisarExitoDelegado != null)
                {
                    avisarExitoDelegado.Invoke();
                }

            }
            else
            {
                if(avisarErrorDelegado != null)
                {
                    avisarErrorDelegado.Invoke();
                }
                
            }

            

        }

        /// <summary>
        /// Exporta datos datos de la lista de estudiantes a Csv
        /// </summary>
        /// <param name="listaEstudiantes"></param>
        /// <param name="nombreArchivo"></param>
        public static void ExportarDatosEstudiantes_Csv(List<Estudiante> listaEstudiantes, string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Censo_Informes";

            if(nombreArchivo.VerificarNombreArchivo(nombreArchivo))
            {
                using (StreamWriter escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv"))
                {
                    escritor.WriteLine("Establecimiento;Nivel;Carrera;Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");

                    foreach (Estudiante item in listaEstudiantes)
                    {
                        escritor.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11}", item.Establecimiento, item.Nivel, item.NombreCarrera, item.Nombre, item.Apellido, item.Edad, item.Sexo, item.Dni, item.Localidad, item.EstadoCivil, item.CantidadHijos, item.NivelEstudio);
                    }
                }
                if (avisarExitoDelegado != null)
                {
                    avisarExitoDelegado.Invoke();
                }

            }
            else
            {
                if (avisarErrorDelegado != null)
                {
                    avisarErrorDelegado.Invoke();
                }

            }
        }

        /// <summary>
        /// Exporta datos de la lista de personas en Csv
        /// </summary>
        /// <param name="nombreArchivo"></param>
        public static void ExportarDatosListaPersona_Csv(object nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            StreamWriter escritor;

            if(nombreArchivo.ToString().VerificarNombreArchivo(nombreArchivo.ToString()))
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv"))
                {
                    escritor.WriteLine("Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");
                    foreach (Persona item in Censo<Persona>.RegistroCompleto)
                    {
                        escritor.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8}", item.Nombre, item.Apellido, item.Edad, item.Sexo, item.Dni, item.Localidad, item.EstadoCivil, item.CantidadHijos, item.NivelEstudio);
                    }
                }
                if (avisarExitoDelegado != null)
                {
                    avisarExitoDelegado.Invoke();
                }

            }
            else
            {
                if (avisarErrorDelegado != null)
                {
                    avisarErrorDelegado.Invoke();
                }

            }




        }

        /// <summary>
        /// Exporta datos en formato JSON
        /// </summary>
        /// <param name="nombreArchivo"></param>
        public static void ExportarDatosJson(object nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += $"\\{nombreArchivo}.json";

            if(nombreArchivo.ToString().VerificarNombreArchivo(nombreArchivo.ToString()))
            {
                string listaPersonas = JsonSerializer.Serialize(Censo<Persona>.RegistroCompleto);

                File.WriteAllText(ruta, listaPersonas);
                if(avisarExitoDelegado != null)
                {
                    avisarExitoDelegado.Invoke();
                }
                
                
            }
            else
            {
                if(avisarErrorDelegado != null)
                {
                    avisarErrorDelegado.Invoke();
                }
                
            }
            
        }

        
    }
}

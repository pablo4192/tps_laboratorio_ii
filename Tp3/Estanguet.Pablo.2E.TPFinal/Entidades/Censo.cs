using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;

namespace Entidades
{
    public static class Censo<T>
    {
        static DateTime fecha;
        static List<T> registros;
        static List<Persona> registroCompleto;

        static Censo()
        {
            fecha = DateTime.Today;
            registros = new List<T>();
            registroCompleto = new List<Persona>();
            
        }

       public static DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public static List<T> Registros
        {
            get { return registros; }
            set { registros = value; }
        }

        public static List<Persona> RegistroCompleto
        {
            get { return registroCompleto; }
            set { registroCompleto = value; }
        }


        
        public static void ExportarDatos(List<T> listaInformes, string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Censo_Informes";

            StreamWriter escritor;

            
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
            
        }

        public static void ExportarDatosEstudiantes_Csv(List<Estudiante> listaEstudiantes, string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Censo_Informes";

            try
            {
                using (StreamWriter escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv"))
                {
                    escritor.WriteLine("Establecimiento;Nivel;Carrera;Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");

                    foreach (Estudiante item in listaEstudiantes)
                    {
                        escritor.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11}", item.Establecimiento, item.Nivel, item.NombreCarrera, item.Nombre, item.Apellido, item.Edad, item.Sexo, item.Dni, item.Localidad, item.EstadoCivil, item.CantidadHijos, item.NivelEstudio);
                    }
                }
            }
            catch
            {
                //Excepcion
            }
           
        }

        
        public static void ExportarDatosListaPersona_Csv(List<Persona> listaInformes, string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            

            StreamWriter escritor;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (escritor = new StreamWriter(ruta + $"\\{nombreArchivo}.csv"))
                {
                    escritor.WriteLine("Nombre;Apellido;Edad;Sexo;Dni;Localidad;Estado Civil;Cantidad Hijos;Estudio Completo");
                    foreach (Persona item in listaInformes)
                    {
                        escritor.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8}", item.Nombre, item.Apellido, item.Edad, item.Sexo, item.Dni, item.Localidad, item.EstadoCivil, item.CantidadHijos, item.NivelEstudio);
                    }
                }
                   
            }
            catch
            {
                //Excepcion
            }
        }

        
        public static void ExportarDatosJson(string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += $"\\{nombreArchivo}.json";

            string listaPersonas = JsonSerializer.Serialize(Censo<Persona>.RegistroCompleto);

            File.WriteAllText(ruta, listaPersonas);
        }

        
        public static void SerializarXml()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Censo_Xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                if (typeof(T) == typeof(Trabajador))
                    ruta += @"\Trabajadores.xml";
                else if (typeof(T) == typeof(Estudiante))
                    ruta += @"\Estudiantes.xml";
                else if (typeof(T) == typeof(Estudiante_Trabajador))
                    ruta += @"\Estudiantes_Trabajadores.xml";
                else if (typeof(T) == typeof(Jubilado))
                    ruta += @"\Jubilados.xml";
                else
                    ruta += @"\Desocupados.xml";

                using (XmlTextWriter escritor = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));

                    serializador.Serialize(escritor, registros);

                }
            }
            catch
            {
                //Excepcion
            }
            
        }
    
        
        public static void LeerDatosXml()
        {
            string ruta = Environment.CurrentDirectory;
            ruta += @"\Censo_Xml";

            try
            {
                if (typeof(T) == typeof(Trabajador))
                    ruta += @"\Trabajadores.xml";
                else if (typeof(T) == typeof(Estudiante))
                    ruta += @"\Estudiantes.xml";
                else if (typeof(T) == typeof(Estudiante_Trabajador))
                    ruta += @"\Estudiantes_Trabajadores.xml";
                else if (typeof(T) == typeof(Jubilado))
                    ruta += @"\Jubilados.xml";
                else
                    ruta += @"\Desocupados.xml";

                using (XmlTextReader lector = new XmlTextReader(ruta))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));

                    registros = (List<T>)serializador.Deserialize(lector); //Guardo el archivo en lista por actividad
                }

               
            }
            catch
            {
                //Excepcion
            }

           

        }

         public static List<T> Filtrar_LocalidadMayorDesocupacion(out List<string> localidades)
        {
            List<T> listaAux = new List<T>();
            List<string> listaLocalidades = new List<string>();
            

            Type tipo = typeof(T);
            foreach (T item in registros)
            {
                foreach (PropertyInfo item2 in tipo.GetProperties())
                {
                    if(item2.Name.ToString() == "Localidad")
                    {
                        listaLocalidades.Add(item2.GetValue(item).ToString());
                    }
                }
            }

            listaLocalidades = BuscarMayor_Localidad(listaLocalidades);

            listaAux = RetornarDesocupados(listaLocalidades);

            localidades = listaLocalidades;
            return listaAux;
        }

        private static List<string> BuscarMayor_Localidad(List<string> listaLocalidades)
        {
            List<string> localidadesQueMasAparecen = new List<string>();
            int contador = 0;
            int mayor = 0;
            

            for (int i = 0; i < listaLocalidades.Count; i++)
            {
                
                foreach (string item in listaLocalidades)
                {
                    if (listaLocalidades[i] == item)
                    {
                        contador++;
                    }
                }

                if (mayor == 0 || contador >= mayor)
                {
                    mayor = contador;

                    if(!localidadesQueMasAparecen.Contains(listaLocalidades[i]))
                    {
                        localidadesQueMasAparecen.Add(listaLocalidades[i]);
                    }
                    
                    

                }

                contador = 0;

            }
            return localidadesQueMasAparecen;
        }
        
        private static List<T> RetornarDesocupados(List<string> listaLocalidades)
        {
            List<T> listaDesocupados = new List<T>();
           
            Type tipo = typeof(T);
            foreach (T item in registros)
            {
                foreach (PropertyInfo item2 in tipo.GetProperties())
                {
                    if (item2.Name.ToString() == "Localidad")
                    {
                        foreach (string localidad in listaLocalidades)
                        {
                            if(item2.GetValue(item).ToString() == localidad)
                            {
                                listaDesocupados.Add(item);
                            }
                        }
                    }
                }
            }
            

            return listaDesocupados;
        }


        
        public static List<T> Filtrar_DesocupadosMenores30()
        {
            List<T> listaAux = new List<T>();
            string edad;
            int edadInt;

            Type tipo = typeof(T);
            foreach (T item in registros)
            {
                foreach (PropertyInfo propiedad in tipo.GetProperties())
                {
                    if(propiedad.Name.ToString() == "Edad")
                    {
                        edad = propiedad.GetValue(item).ToString();
                        if(int.TryParse(edad, out edadInt))
                        {
                            if(edadInt < 30)
                            {
                                listaAux.Add(item);
                            }
                        }
                    }
                  
                }
            }
            return listaAux;
        }

        
        public static List<T> Filtrar_SexoMasDesocupado(out string sexo)
        {
            List<T> listaAux = new List<T>();
            List<T> listaMasculino = new List<T>();
            List<T> listaFemenino = new List<T>();
            List<T> listaOtros = new List<T>();
            
            

            Type tipo = typeof(T);
            foreach (T item in registros)
            {
                foreach (PropertyInfo propiedad in tipo.GetProperties())
                {
                    if (propiedad.Name.ToString() == "Sexo")
                    {
                        if(propiedad.GetValue(item).ToString() == "Masculino")
                        {
                            listaMasculino.Add(item);
                        }
                        else if(propiedad.GetValue(item).ToString() == "Femenino")
                        {
                            listaFemenino.Add(item);
                        }
                        else
                        {
                            listaOtros.Add(item);  
                        }
                    }
                }
            }

            if(listaMasculino.Count > listaFemenino.Count && listaMasculino.Count > listaOtros.Count)
            {
                listaAux = listaMasculino;
                sexo = "Masculino";
            }
            else if (listaFemenino.Count > listaOtros.Count )
            {
                listaAux = listaFemenino;
                sexo = "Femenino";
            }
            else
            {
                listaAux = listaOtros;
                sexo = "Otros";
            }


            return listaAux;
        }
        
        
        public static List<T> Filtrar_TrabajadoresNoRegistrados()
        {
            List<T> listaAux = new List<T>();
            

            Type tipo = typeof(T);
            foreach (T item in registros)
            {
                foreach (PropertyInfo propiedad in tipo.GetProperties())
                {
                    if(propiedad.Name.ToString() == "TrabajoRegistrado")
                    {
                        if( (bool)propiedad.GetValue(item) == false)
                        {
                            listaAux.Add(item);
                        }
                        
                    }
                }
            }


            return listaAux;
        }

        
        public static List<Estudiante> Filtrar_CarreraMasEstudiada(List<Estudiante> lista, out List<string> carrera)
        {
            List<Estudiante> listaAux = new List<Estudiante>();
            List<string> listaCarreras = new List<string>();

            foreach (Estudiante item in lista)
            {
                listaCarreras.Add(item.NombreCarrera);
            }
            
            listaCarreras = BuscarCarreraMasEstudiada(listaCarreras);

            listaAux = RetornarEstudiantes(listaCarreras, lista);

            carrera = listaCarreras;
            return listaAux;
        }

        private static List<string> BuscarCarreraMasEstudiada(List<string> listaCarreras)
        {
            
            List<string> carrerasQueMasAparecen = new List<string>();
            int contador = 0;
            int mayor = 0;


            for (int i = 0; i < listaCarreras.Count; i++)
            {

                foreach (string item in listaCarreras)
                {
                    if (listaCarreras[i] == item)
                    {
                        contador++;
                    }
                }

                if (mayor == 0 || contador >= mayor)
                {
                    mayor = contador;
                    if (!carrerasQueMasAparecen.Contains(listaCarreras[i]))
                    {
                        carrerasQueMasAparecen.Add(listaCarreras[i]);
                    }
                   


                }

                contador = 0;

            }
            return carrerasQueMasAparecen;
        }

        private static List<Estudiante> RetornarEstudiantes(List<string> listaCarreras, List<Estudiante> lista)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            foreach (string carrera in listaCarreras)
            {
                foreach (Estudiante estudiante in lista)
                {
                    if(carrera == estudiante.NombreCarrera)
                    {
                        listaEstudiantes.Add(estudiante);
                    }

                }
                
            }

            return listaEstudiantes;
        }

    }
}

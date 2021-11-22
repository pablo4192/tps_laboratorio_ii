using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

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


        /// <summary>
        /// Exporta en Xml las listas hardcodeadas segun actividad del tipo T que le pasen.
        /// </summary>
        public static void SerializarXml()
        {
            string ruta = Environment.CurrentDirectory; //Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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
    
        /// <summary>
        /// Lee los datos del archivo Xml de listas hardcodeadas segun su actividad.
        /// </summary>
        public static void LeerDatosXml()
        {
            string ruta = Environment.CurrentDirectory; /*Environment.GetFolderPath(Environment.SpecialFolder.Desktop);*/
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

        /// <summary>
        /// Filtra las localidades con mayor indice de desocupacion.
        /// </summary>
        /// <param name="localidades">Guarda la lista de localidades en variable out</param>
        /// <returns>Lista de personas que viven en esas localidades</returns>
        public static List<T> Filtrar_LocalidadMayorDesocupacion(out List<string> localidades)
        {
            List<T> listaAux;
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

        /// <summary>
        /// Busca la localidad que mas aparece en la lista.
        /// </summary>
        /// <param name="listaLocalidades"></param>
        /// <returns>Lista con las localidades que mas aparecen</returns>
        public static List<string> BuscarMayor_Localidad(List<string> listaLocalidades)
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
        
        /// <summary>
        /// Busca las personas que aparecen en las localidades con mas desocupacion
        /// </summary>
        /// <param name="listaLocalidades"></param>
        /// <returns>Lista de personas de las localidades con mas desocupacion</returns>
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


        /// <summary>
        /// Filtra los desocupados menores de 30 años
        /// </summary>
        /// <returns>Lista con personas desocupadas menores de 30 años</returns>
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

        /// <summary>
        /// Filtra el sexo con mas indice de desocupacion
        /// </summary>
        /// <param name="sexo"></param>
        /// <returns>Lista de personas del sexo con mas indice de desocupacion</returns>
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
        
        /// <summary>
        /// Filtra los trabajadores no registrados
        /// </summary>
        /// <returns>Lista de trabajadores con trabajos no registrados</returns>
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

        /// <summary>
        /// Filtra la carrera mas estudiada epor las personas del registro
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="carrera">guarda la lista de carrera en variable out</param>
        /// <returns>Lista de personas que estudian las carreras mas elegidas</returns>
        public static List<Estudiante> Filtrar_CarreraMasEstudiada(List<Estudiante> lista, out List<string> carrera)
        {
            List<Estudiante> listaAux = new List<Estudiante>();
            List<string> listaCarreras = new List<string>();

            lista.ForEach((e) => listaCarreras.Add(e.NombreCarrera));

            listaCarreras = BuscarCarreraMasEstudiada(listaCarreras);

            listaAux = RetornarEstudiantes(listaCarreras, lista);

            carrera = listaCarreras;
            return listaAux;
        }

        /// <summary>
        /// Busca en la lista las carreras mas estudiadas
        /// </summary>
        /// <param name="listaCarreras"></param>
        /// <returns>Lista de carreras mas estudiadas</returns>
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

        /// <summary>
        /// Busca los estudiantes que estudian las carreras mas elegidas
        /// </summary>
        /// <param name="listaCarreras"></param>
        /// <param name="lista"></param>
        /// <returns>Lista de personas que estudian las carreras mas elegidas</returns>
        private static List<Estudiante> RetornarEstudiantes(List<string> listaCarreras, List<Estudiante> lista)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            foreach (string carrera in listaCarreras)
            {
                listaEstudiantes.AddRange(lista.FindAll((e) => carrera == e.NombreCarrera));
            }

            return listaEstudiantes;
        }


       
        /// <summary>
        /// Carga los datos de los registros desde la base de datos
        /// </summary>
        public static void CargarInfoDb()
        {
            DB baseDeDatos = new DB(@"Data Source=DESKTOP-6OSNEQS\SQLEXPRESS;Database=Censo;Trusted_Connection=True;");

            if(typeof(T) == typeof(Trabajador))
            {
                registros.AddRange((IEnumerable<T>)baseDeDatos.RetornarTrabajadores());
            }
            else if(typeof(T) == typeof(Estudiante))
            {
                registros.AddRange((IEnumerable<T>)baseDeDatos.RetornarEstudiantes());
            }
            else if(typeof(T) == typeof(Estudiante_Trabajador))
            {
                registros.AddRange((IEnumerable<T>)baseDeDatos.RetornarEstudiantes_Trabajadores());
            }
            else if(typeof(T) == typeof(Jubilado))
            {
                registros.AddRange((IEnumerable<T>)baseDeDatos.RetornarJubilados());
            }
            else
            {
                registros.AddRange((IEnumerable<T>)baseDeDatos.RetornarDesocupados());
            }

        }

        /// <summary>
        /// Crea la conexion con la base de datos para insertar informacion
        /// </summary>
        /// <param name="objetoAinsertar"></param>
        private static void InsertToDataBase(T objetoAinsertar)
        {
            DB baseDeDatos = new DB(@"Data Source=DESKTOP-6OSNEQS\SQLEXPRESS;Database=Censo;Trusted_Connection=True;");

            baseDeDatos.InsertarEnDb(objetoAinsertar);
            
        }

        /// <summary>
        /// Agrega al registro una persona
        /// </summary>
        /// <param name="objetoAgregarALista"></param>
        private static void AgregarARegistro(T objetoAgregarALista)
        {
            registros.Add(objetoAgregarALista);
        }


        /// <summary>
        /// Retorna delegado de la clase Censo que se ocupa de insertar en base de datos y agregar a registro
        /// </summary>
        /// <returns>GuardarCambiosDelegate<T></returns>
        public static GuardarCambiosDelegate<T> RetornarDelegado()
        {
            GuardarCambiosDelegate<T> guardarCambiosDelegate;

            guardarCambiosDelegate = InsertToDataBase;
            guardarCambiosDelegate += AgregarARegistro;

            return guardarCambiosDelegate;

        }

        /// <summary>
        /// Ordena la lista de personas por edad ascendente o descendente
        /// </summary>
        /// <param name="criterio"></param>
        public static void OrdenarRegistroPorEdad(object criterio)
        {
            Thread.Sleep(3000);

            if (criterio.ToString() == "Ascendente")
            {
                
                registroCompleto.Sort((p1, p2) => p1.Edad - p2.Edad);
               
            }
            else if(criterio.ToString() == "Descendente")
            {
                registroCompleto.Sort((p1, p2) => p2.Edad - p1.Edad);
               
            }
        }

       
        

    }
}

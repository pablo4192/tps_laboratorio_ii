using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Entidades
{
    class DB
    {
        //Forma de conectarnos y autenticarse a la base de datos
        private string conexionString;

        //Cuando creen una instancia pido la conexion por el constructor
        public DB(string conexionString)
        {
            this.conexionString = conexionString;
        }
    
        //Retorna datos resultantes de la consulta
        public List<Trabajador> RetornarTrabajadores()
        {
            
            string consulta = "select * from Trabajadores";
            List<Trabajador> listaTrabajadores = new List<Trabajador>();

            //Instancio un objeto SqlConnection pasandole la ruta para conectarse a la base de datos
            SqlConnection conexion = new SqlConnection(this.conexionString);

            //Se ocupa de realizar la consulta en la DB, le paso consulta y la forma de conectarse
            SqlCommand comando = new SqlCommand(consulta, conexion);

            //Puede haber problemas de conexion, por eso se pone en un bloque try catch
            try
            {
                    //Abro la conexion para realizar la consulta
                    conexion.Open();

                    //Ejecuto la consulta
                    //Va a contener los datos de la tabla //Retorna un sqlDataReader
                    SqlDataReader sqlDataReader = comando.ExecuteReader();

                    //Retorna un bool cada vez que pudo leer una linea
                    while (sqlDataReader.Read()) //Mientras tenga filas para leer entro al bloque while
                    {
                        Trabajador trabaAux = new Trabajador();
                        trabaAux.Nombre = sqlDataReader["Nombre"].ToString();
                        trabaAux.Apellido = sqlDataReader["Apellido"].ToString();
                        trabaAux.Edad = (int)(decimal)sqlDataReader["Edad"];
                        trabaAux.Sexo = sqlDataReader["Sexo"].ToString();
                        trabaAux.Dni = (int)(decimal)sqlDataReader["Dni"];
                        trabaAux.Localidad = sqlDataReader["Localidad"].ToString();
                        trabaAux.EstadoCivil = sqlDataReader["Estado civil"].ToString();
                        trabaAux.CantidadHijos = (int)(decimal)sqlDataReader["Cantidad hijos"];
                        trabaAux.NivelEstudio = sqlDataReader["Nivel estudio"].ToString();
                        trabaAux.TrabajoRegistrado = (bool)sqlDataReader["Trabajo registrado"];
                        trabaAux.RelacionDeDependencia = (bool)sqlDataReader["Relacion de dependencia"];
                        trabaAux.HorasSemanales = (int)(decimal)sqlDataReader["Horas semanales"];

                        listaTrabajadores.Add(trabaAux);
                    }

            }
            catch (Exception e)
            {
                //Hacer algo
            }
            finally
            {
                //Cierro la conexion
                conexion.Close();
            }

            return listaTrabajadores;

        }
    
        public List<Estudiante> RetornarEstudiantes()
        {
            string consulta = "select * from Estudiantes";
            List<Estudiante> listaEstudiantes = new List<Estudiante>();


            SqlConnection conexion = new SqlConnection(this.conexionString);
            
            SqlCommand comando = new SqlCommand(consulta, conexion);

            
            try
            {
               
                conexion.Open();

                SqlDataReader sqlDataReader = comando.ExecuteReader();

                
                while (sqlDataReader.Read()) 
                {
                    Estudiante estudianteAux = new Estudiante();
                    estudianteAux.Nombre = sqlDataReader["Nombre"].ToString();
                    estudianteAux.Apellido = sqlDataReader["Apellido"].ToString();
                    estudianteAux.Edad = (int)(decimal)sqlDataReader["Edad"];
                    estudianteAux.Sexo = sqlDataReader["Sexo"].ToString();
                    estudianteAux.Dni = (int)(decimal)sqlDataReader["Dni"];
                    estudianteAux.Localidad = sqlDataReader["Localidad"].ToString();
                    estudianteAux.EstadoCivil = sqlDataReader["Estado civil"].ToString();
                    estudianteAux.CantidadHijos = (int)(decimal)sqlDataReader["Cantidad hijos"];
                    estudianteAux.NivelEstudio = sqlDataReader["Nivel estudio"].ToString();
                    estudianteAux.Establecimiento = sqlDataReader["Establecimiento"].ToString();
                    estudianteAux.Nivel = sqlDataReader["Nivel"].ToString();
                    estudianteAux.NombreCarrera = sqlDataReader["Carrera"].ToString();

                    listaEstudiantes.Add(estudianteAux);
                }

            }
            catch (Exception e)
            {
                //Hacer algo
            }
            finally
            {
                
                conexion.Close();
            }

            return listaEstudiantes;
        }

        public List<Estudiante_Trabajador> RetornarEstudiantes_Trabajadores()
        {
            string consulta = "select * from Estudiante_Trabajador";
            List<Estudiante_Trabajador> listaEstudiantes_Trabas = new List<Estudiante_Trabajador>();


            SqlConnection conexion = new SqlConnection(this.conexionString);

            SqlCommand comando = new SqlCommand(consulta, conexion);


            try
            {

                conexion.Open();

                SqlDataReader sqlDataReader = comando.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    Estudiante_Trabajador estudianteTrabaAux = new Estudiante_Trabajador();
                    estudianteTrabaAux.Nombre = sqlDataReader["Nombre"].ToString();
                    estudianteTrabaAux.Apellido = sqlDataReader["Apellido"].ToString();
                    estudianteTrabaAux.Edad = (int)(decimal)sqlDataReader["Edad"];
                    estudianteTrabaAux.Sexo = sqlDataReader["Sexo"].ToString();
                    estudianteTrabaAux.Dni = (int)(decimal)sqlDataReader["Dni"];
                    estudianteTrabaAux.Localidad = sqlDataReader["Localidad"].ToString();
                    estudianteTrabaAux.EstadoCivil = sqlDataReader["Estado civil"].ToString();
                    estudianteTrabaAux.CantidadHijos = (int)(decimal)sqlDataReader["Cantidad hijos"];
                    estudianteTrabaAux.NivelEstudio = sqlDataReader["Nivel estudio"].ToString();
                    estudianteTrabaAux.Establecimiento = sqlDataReader["Establecimiento"].ToString();
                    estudianteTrabaAux.Nivel = sqlDataReader["Nivel"].ToString();
                    estudianteTrabaAux.NombreCarrera = sqlDataReader["Carrera"].ToString();
                    estudianteTrabaAux.TrabajoRegistrado = (bool)sqlDataReader["Trabajo registrado"];
                    estudianteTrabaAux.RelacionDeDependencia = (bool)sqlDataReader["Relacion de dependencia"];
                    estudianteTrabaAux.HorasSemanales = (int)(decimal)sqlDataReader["Horas semanales"];

                    listaEstudiantes_Trabas.Add(estudianteTrabaAux);
                }

            }
            catch (Exception e)
            {
                //Hacer algo
            }
            finally
            {

                conexion.Close();
            }

            return listaEstudiantes_Trabas;
        }

        public List<Jubilado> RetornarJubilados()
        {
            string consulta = "select * from Jubilados";
            List<Jubilado> listaJubilados = new List<Jubilado>();


            SqlConnection conexion = new SqlConnection(this.conexionString);

            SqlCommand comando = new SqlCommand(consulta, conexion);


            try
            {

                conexion.Open();

                SqlDataReader sqlDataReader = comando.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    Jubilado jubiladoAux = new Jubilado();
                    jubiladoAux.Nombre = sqlDataReader["Nombre"].ToString();
                    jubiladoAux.Apellido = sqlDataReader["Apellido"].ToString();
                    jubiladoAux.Edad = (int)(decimal)sqlDataReader["Edad"];
                    jubiladoAux.Sexo = sqlDataReader["Sexo"].ToString();
                    jubiladoAux.Dni = (int)(decimal)sqlDataReader["Dni"];
                    jubiladoAux.Localidad = sqlDataReader["Localidad"].ToString();
                    jubiladoAux.EstadoCivil = sqlDataReader["Estado civil"].ToString();
                    jubiladoAux.CantidadHijos = (int)(decimal)sqlDataReader["Cantidad hijos"];
                    jubiladoAux.NivelEstudio = sqlDataReader["Nivel estudio"].ToString();
                    jubiladoAux.AnioJubilacion = (int)(decimal)sqlDataReader["anio jubilacion"];
                    jubiladoAux.SigueTrabajando = (bool)sqlDataReader["Sigue trabajando"];

                    listaJubilados.Add(jubiladoAux);
                }

            }
            catch (Exception e)
            {
                //Hacer algo
            }
            finally
            {

                conexion.Close();
            }

            return listaJubilados;
        }

        public List<Desocupado> RetornarDesocupados()
        {

            string consulta = "select * from Desocupados";
            List<Desocupado> listaDesocupados = new List<Desocupado>();


            SqlConnection conexion = new SqlConnection(this.conexionString);

            SqlCommand comando = new SqlCommand(consulta, conexion);


            try
            {

                conexion.Open();

                SqlDataReader sqlDataReader = comando.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    Desocupado desocupadoAux = new Desocupado();
                    desocupadoAux.Nombre = sqlDataReader["Nombre"].ToString();
                    desocupadoAux.Apellido = sqlDataReader["Apellido"].ToString();
                    desocupadoAux.Edad = (int)(decimal)sqlDataReader["Edad"];
                    desocupadoAux.Sexo = sqlDataReader["Sexo"].ToString();
                    desocupadoAux.Dni = (int)(decimal)sqlDataReader["Dni"];
                    desocupadoAux.Localidad = sqlDataReader["Localidad"].ToString();
                    desocupadoAux.EstadoCivil = sqlDataReader["Estado civil"].ToString();
                    desocupadoAux.CantidadHijos = (int)(decimal)sqlDataReader["Cantidad hijos"];
                    desocupadoAux.NivelEstudio = sqlDataReader["Nivel estudio"].ToString();
                    desocupadoAux.FechaUltimoTrabajo = (DateTime) sqlDataReader["Fecha ultimo trabajo"];
                    desocupadoAux.RecibeAyudaEstatal = (bool)sqlDataReader["Ayuda estatal"];

                    listaDesocupados.Add(desocupadoAux);
                }

            }
            catch (Exception e)
            {
                //Hacer algo
            }
            finally
            {

                conexion.Close();
            }

            return listaDesocupados;
        }


        public bool InsertarEnDb<T>(T objetoAinsertar)
        {
            string consulta;
            SqlConnection conexion = new SqlConnection(this.conexionString);
            SqlCommand comando;
            ProblemasDeConexionSqlExcepcion problemasDeConexionSqlExcepcion = new ProblemasDeConexionSqlExcepcion();

            Type tipo = typeof(T);

            try
            {
                if (tipo == typeof(Trabajador))
                {
                    Trabajador trabajador = new Trabajador();

                    foreach (PropertyInfo item in tipo.GetProperties())
                    {
                        if (item.Name == "Nombre")
                            trabajador.Nombre = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Apellido")
                            trabajador.Apellido = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Edad")
                            trabajador.Edad = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Sexo")
                            trabajador.Sexo = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Dni")
                            trabajador.Dni = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Localidad")
                            trabajador.Localidad = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "EstadoCivil")
                            trabajador.EstadoCivil = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "CantidadHijos")
                            trabajador.CantidadHijos = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "NivelEstudio")
                            trabajador.NivelEstudio = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "TrabajoRegistrado")
                            trabajador.TrabajoRegistrado = (bool)item.GetValue(objetoAinsertar);
                        else if (item.Name == "RelacionDeDependencia")
                            trabajador.RelacionDeDependencia = (bool)item.GetValue(objetoAinsertar);
                        else if (item.Name == "HorasSemanales")
                            trabajador.HorasSemanales = (int)item.GetValue(objetoAinsertar);
                    }
                    consulta = $"insert into Trabajadores(Nombre, Apellido, Edad, Sexo, Dni, Localidad, [Estado civil], [Cantidad hijos], [Nivel estudio], [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) values ('{trabajador.Nombre}', '{trabajador.Apellido}', '{trabajador.Edad}', '{trabajador.Sexo}', '{trabajador.Dni}', '{trabajador.Localidad}', '{trabajador.EstadoCivil}', '{trabajador.CantidadHijos}', '{trabajador.NivelEstudio}', '{trabajador.TrabajoRegistrado}', '{trabajador.RelacionDeDependencia}', '{trabajador.HorasSemanales}')";
                    comando = new SqlCommand(consulta, conexion);


                    conexion.Open();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }

                else if (tipo == typeof(Estudiante))
                {
                    Estudiante estudiante = new Estudiante();

                    foreach (PropertyInfo item in tipo.GetProperties())
                    {
                        if (item.Name == "Nombre")
                            estudiante.Nombre = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Apellido")
                            estudiante.Apellido = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Edad")
                            estudiante.Edad = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Sexo")
                            estudiante.Sexo = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Dni")
                            estudiante.Dni = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Localidad")
                            estudiante.Localidad = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "EstadoCivil")
                            estudiante.EstadoCivil = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "CantidadHijos")
                            estudiante.CantidadHijos = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "NivelEstudio")
                            estudiante.NivelEstudio = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Establecimiento")
                            estudiante.Establecimiento = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Nivel")
                            estudiante.Nivel = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "NombreCarrera")
                            estudiante.NombreCarrera = item.GetValue(objetoAinsertar).ToString();
                    }

                    consulta = $"insert into Estudiantes(Nombre, Apellido, Edad, Sexo, Dni, Localidad, [Estado civil], [Cantidad hijos], [Nivel estudio], Establecimiento, Nivel, Carrera) values ('{estudiante.Nombre}', '{estudiante.Apellido}', '{estudiante.Edad}', '{estudiante.Sexo}', '{estudiante.Dni}', '{estudiante.Localidad}', '{estudiante.EstadoCivil}', '{estudiante.CantidadHijos}', '{estudiante.NivelEstudio}', '{estudiante.Establecimiento}', '{estudiante.Nivel}', '{estudiante.NombreCarrera}')";
                    comando = new SqlCommand(consulta, conexion);


                    conexion.Open();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }

                else if (tipo == typeof(Estudiante_Trabajador))
                {
                    Estudiante_Trabajador estudiante_Traba = new Estudiante_Trabajador();


                    foreach (PropertyInfo item in tipo.GetProperties())
                    {
                        if (item.Name == "Nombre")
                            estudiante_Traba.Nombre = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Apellido")
                            estudiante_Traba.Apellido = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Edad")
                            estudiante_Traba.Edad = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Sexo")
                            estudiante_Traba.Sexo = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Dni")
                            estudiante_Traba.Dni = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Localidad")
                            estudiante_Traba.Localidad = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "EstadoCivil")
                            estudiante_Traba.EstadoCivil = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "CantidadHijos")
                            estudiante_Traba.CantidadHijos = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "NivelEstudio")
                            estudiante_Traba.NivelEstudio = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Establecimiento")
                            estudiante_Traba.Establecimiento = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Nivel")
                            estudiante_Traba.Nivel = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "NombreCarrera")
                            estudiante_Traba.NombreCarrera = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "TrabajoRegistrado")
                            estudiante_Traba.TrabajoRegistrado = (bool)item.GetValue(objetoAinsertar);
                        else if (item.Name == "RelacionDeDependencia")
                            estudiante_Traba.RelacionDeDependencia = (bool)item.GetValue(objetoAinsertar);
                        else if (item.Name == "HorasSemanales")
                            estudiante_Traba.HorasSemanales = (int)item.GetValue(objetoAinsertar);

                    }

                    consulta = $"insert into Estudiante_Trabajador(Nombre, Apellido, Edad, Sexo, Dni, Localidad, [Estado civil], [Cantidad hijos], [Nivel estudio], Establecimiento, Nivel, Carrera, [Trabajo registrado], [Relacion de dependencia], [Horas semanales]) values ('{estudiante_Traba.Nombre}', '{estudiante_Traba.Apellido}', '{estudiante_Traba.Edad}', '{estudiante_Traba.Sexo}', '{estudiante_Traba.Dni}', '{estudiante_Traba.Localidad}', '{estudiante_Traba.EstadoCivil}', '{estudiante_Traba.CantidadHijos}', '{estudiante_Traba.NivelEstudio}', '{estudiante_Traba.Establecimiento}', '{estudiante_Traba.Nivel}', '{estudiante_Traba.NombreCarrera}', '{estudiante_Traba.TrabajoRegistrado}', '{estudiante_Traba.RelacionDeDependencia}', '{estudiante_Traba.HorasSemanales}')";
                    comando = new SqlCommand(consulta, conexion);


                    conexion.Open();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }

                else if (tipo == typeof(Jubilado))
                {
                    Jubilado jubilado = new Jubilado();

                    foreach (PropertyInfo item in tipo.GetProperties())
                    {
                        if (item.Name == "Nombre")
                            jubilado.Nombre = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Apellido")
                            jubilado.Apellido = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Edad")
                            jubilado.Edad = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Sexo")
                            jubilado.Sexo = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Dni")
                            jubilado.Dni = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Localidad")
                            jubilado.Localidad = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "EstadoCivil")
                            jubilado.EstadoCivil = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "CantidadHijos")
                            jubilado.CantidadHijos = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "NivelEstudio")
                            jubilado.NivelEstudio = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "AnioJubilacion")
                            jubilado.AnioJubilacion = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "SigueTrabajando")
                            jubilado.SigueTrabajando = (bool)item.GetValue(objetoAinsertar);

                    }

                    consulta = $"insert into Jubilados(Nombre, Apellido, Edad, Sexo, Dni, Localidad, [Estado civil], [Cantidad hijos], [Nivel estudio], [anio jubilacion], [Sigue trabajando]) values ('{jubilado.Nombre}', '{jubilado.Apellido}', '{jubilado.Edad}', '{jubilado.Sexo}', '{jubilado.Dni}', '{jubilado.Localidad}', '{jubilado.EstadoCivil}', '{jubilado.CantidadHijos}', '{jubilado.NivelEstudio}', '{jubilado.AnioJubilacion}', '{jubilado.SigueTrabajando}')";
                    comando = new SqlCommand(consulta, conexion);


                    conexion.Open();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }

                else if (tipo == typeof(Desocupado))
                {
                    Desocupado desocupado = new Desocupado();

                    foreach (PropertyInfo item in tipo.GetProperties())
                    {
                        if (item.Name == "Nombre")
                            desocupado.Nombre = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Apellido")
                            desocupado.Apellido = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Edad")
                            desocupado.Edad = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Sexo")
                            desocupado.Sexo = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "Dni")
                            desocupado.Dni = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "Localidad")
                            desocupado.Localidad = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "EstadoCivil")
                            desocupado.EstadoCivil = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "CantidadHijos")
                            desocupado.CantidadHijos = (int)item.GetValue(objetoAinsertar);
                        else if (item.Name == "NivelEstudio")
                            desocupado.NivelEstudio = item.GetValue(objetoAinsertar).ToString();
                        else if (item.Name == "FechaUltimoTrabajo")
                            desocupado.FechaUltimoTrabajo = (DateTime)item.GetValue(objetoAinsertar);
                        else if (item.Name == "RecibeAyudaEstatal")
                            desocupado.RecibeAyudaEstatal = (bool)item.GetValue(objetoAinsertar);

                    }

                    consulta = $"insert into Desocupados(Nombre, Apellido, Edad, Sexo, Dni, Localidad, [Estado civil], [Cantidad hijos], [Nivel estudio], [Fecha ultimo trabajo], [Ayuda estatal]) values ('{desocupado.Nombre}', '{desocupado.Apellido}', '{desocupado.Edad}', '{desocupado.Sexo}', '{desocupado.Dni}', '{desocupado.Localidad}', '{desocupado.EstadoCivil}', '{desocupado.CantidadHijos}', '{desocupado.NivelEstudio}', '{desocupado.FechaUltimoTrabajo}', '{desocupado.RecibeAyudaEstatal}')";
                    comando = new SqlCommand(consulta, conexion);

                    conexion.Open();
                    if (comando.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
            }
            catch(ProblemasDeConexionSqlExcepcion)
            {
                throw problemasDeConexionSqlExcepcion;
            }
            finally
            {
                conexion.Close();
            }

            return false;
        }

    }

   


}

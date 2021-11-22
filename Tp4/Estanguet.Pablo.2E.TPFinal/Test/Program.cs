using System;
using System.Collections.Generic;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Desocupado> listaDesocuMenores30 = new List<Desocupado>();


            ////Hardcodeo de personas segun actividad
            //Hardcodeo.HardcodearTrabajadores();
            //Hardcodeo.HardcodearEstudiantes();
            //Hardcodeo.HardcodearEstudiantes_Trabajadores();
            //Hardcodeo.HardcodearJubilados();
            //Hardcodeo.HardcodearDesocupados();

            ////Serializacion del hardcodeo
            //Censo<Trabajador>.SerializarXml();
            //Censo<Estudiante>.SerializarXml();
            //Censo<Estudiante_Trabajador>.SerializarXml();
            //Censo<Jubilado>.SerializarXml();
            //Censo<Desocupado>.SerializarXml();

            //Levanto los datos del Censo archivo Xml en la carpeta bin del proyecto.
            Censo<Trabajador>.LeerDatosXml();
            Censo<Estudiante>.LeerDatosXml();
            Censo<Estudiante_Trabajador>.LeerDatosXml();
            Censo<Desocupado>.LeerDatosXml();
            Censo<Jubilado>.LeerDatosXml();

            //Cargo en lista general de personas censadas todas las personas clasificadas por actividad en la lista generica de Censo<T>
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Trabajador>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Estudiante>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Estudiante_Trabajador>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Jubilado>.Registros);
            Censo<Persona>.RegistroCompleto.AddRange(Censo<Desocupado>.Registros);

            //Prueba de escritura csv
            ExportarInfo.ExportarDatos<Trabajador>(Censo<Trabajador>.Registros, "PruebaDatos");

            //prueba de escritura json
            ExportarInfo.ExportarDatosJson("PruebaJson");

            //Filtro desocupados menores de 30 años
            listaDesocuMenores30 = Censo<Desocupado>.Filtrar_DesocupadosMenores30();

            foreach (Desocupado item in listaDesocuMenores30)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", item.Nombre, item.Apellido, item.Edad, item.FechaUltimoTrabajo, item.RecibeAyudaEstatal);
            }













        }
    }
}

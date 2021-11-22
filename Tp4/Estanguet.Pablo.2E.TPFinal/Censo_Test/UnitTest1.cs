using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;

namespace Censo_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FiltrarLocalidadMayorDesocupacion_Exito()
        {
            //Arrange
            List<string> localidades;
            List<Desocupado> listaRetorno;
            Hardcodeo.HardcodearDesocupados();

            //ACT
            listaRetorno = Censo<Desocupado>.Filtrar_LocalidadMayorDesocupacion(out localidades);

            //Assert
            Assert.IsNotNull(localidades);
            Assert.IsTrue(listaRetorno.Count > 0);
            Assert.IsTrue(localidades.Count > 0);
        }

        [TestMethod]
        public void Test_FiltrarLocalidadMayorDesocupacion_Erroneos()
        {
            List<string> localidades;
            List<Desocupado> listaRetorno;

            listaRetorno = Censo<Desocupado>.Filtrar_LocalidadMayorDesocupacion(out localidades);

            Assert.IsFalse(listaRetorno.Count > 0);
            Assert.IsFalse(localidades.Count > 0);
        }

        [TestMethod]
        public void Test_BuscarMayorLocalidad_Exito()
        {
            Hardcodeo.HardcodearDesocupados();
            List<string> listaRetorno;
            List<string> localidades = new List<string>();
            foreach (Desocupado item in Censo<Desocupado>.Registros)
            {
                localidades.Add(item.Localidad);
            }

            listaRetorno = Censo<Desocupado>.BuscarMayor_Localidad(localidades);

            Assert.IsNotNull(listaRetorno);
            Assert.IsTrue(listaRetorno.Count > 0);
        }

        [TestMethod]
        public void Test_BuscarMayorLocalidad_Erroneos()
        {
            List<string> listaRetorno;
            List<string> localidades = new List<string>();

            listaRetorno = Censo<Desocupado>.BuscarMayor_Localidad(localidades);

            Assert.IsTrue(listaRetorno.Count == 0);
            Assert.IsNotNull(listaRetorno);

        }

        [TestMethod]
        public void Test_FiltrarCarreraMasEstudiada_Exito()
        {
            Hardcodeo.HardcodearEstudiantes();
            Hardcodeo.HardcodearEstudiantes_Trabajadores();
            
            List<Estudiante> listaParametro = new List<Estudiante>();
            listaParametro.AddRange(Censo<Estudiante>.Registros);
            listaParametro.AddRange(Censo<Estudiante_Trabajador>.Registros);
            
            List<Estudiante> listaRetorno;
            List<string> listaCarreras;

            listaRetorno = Censo<Estudiante>.Filtrar_CarreraMasEstudiada(listaParametro, out listaCarreras);

            Assert.IsNotNull(listaRetorno);
            Assert.IsTrue(listaRetorno.Count > 0);
            Assert.IsNotNull(listaCarreras);
            Assert.IsFalse(listaCarreras.Count == 0);

        }

        [TestMethod]
        public void Test_FiltrarCarreraMasEstudiada_Error()
        {
            List<Estudiante> listaParametro = new List<Estudiante>();
            List<Estudiante> listaRetorno;
            List<string> listaCarreras;

            listaRetorno = Censo<Estudiante>.Filtrar_CarreraMasEstudiada(listaParametro, out listaCarreras);

            Assert.IsTrue(listaRetorno.Count == 0);
            Assert.IsNotNull(listaRetorno);
            Assert.IsFalse(listaCarreras.Count > 0);

        }

        [TestMethod]
        public void Test_VerificarNombreArchivo_Exito()
        {
            string nombre = "Carlos";
            bool retorno;

            retorno = nombre.VerificarNombreArchivo(nombre);

            Assert.IsTrue(retorno);
            Assert.IsFalse(!retorno);
        }

    }
}

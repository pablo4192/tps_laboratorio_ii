using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Hardcodeo
    {
        public static void HardcodearTrabajadores()
        {
            Trabajador t1 = new Trabajador("Pepe", "Perez", 45, "Masculino", 30560489, "Lomas Del Mirador", "Casado", 2, "Secundario", true, true, 45);
            Trabajador t2 = new Trabajador("Sara", "Miller", 39, "Femenino", 32987456, "Ramos Mejia", "Soltero", 0, "Secundario", true, true, 50);
            Trabajador t3 = new Trabajador("Flavia", "Dente", 49, "Femenino", 28963258, "Caseros", "Casado", 3, "Primario", false, true, 55);
            Trabajador t4 = new Trabajador("Dario", "Ferchon", 27, "Otro", 38124578, "Lomas Del Mirador", "Soltero", 0, "Secundario", false, false, 45);
            Trabajador t5 = new Trabajador("Lucas", "Babe", 30, "Masculino", 35987456, "Tapiales", "Soltero", 1, "Secundario", true, false, 60);
            Trabajador t6 = new Trabajador("Daniel", "Rimpi", 55, "Masculino", 25897463, "Ciudadela", "Casado", 4, "Primario", false, true, 45);
            Trabajador t7 = new Trabajador("Leila", "Culi", 25, "Otro", 39854126, "Ciudadela", "Soltero", 1, "Secundario", false, false, 40);
            Trabajador t8 = new Trabajador("Berta", "Chancle", 21, "Femenino", 40986325, "Lomas Del Mirador", "Soltero", 0, "Primario", false, true, 55);
            Trabajador t9 = new Trabajador("Luis", "Neron", 60, "Masculino", 22893175, "Ramos Mejia", "Casado", 2, "Universitario", true, true, 40);
            Trabajador t10 = new Trabajador("Jose", "Sertal", 63, "Masculino", 20986158, "Caseros", "Soltero", 0, "Primario", false, false, 55);

            List<Trabajador> listaTraba = new List<Trabajador>();
            listaTraba.Add(t1);
            listaTraba.Add(t2);
            listaTraba.Add(t3);
            listaTraba.Add(t4);
            listaTraba.Add(t5);
            listaTraba.Add(t6);
            listaTraba.Add(t7);
            listaTraba.Add(t8);
            listaTraba.Add(t9);
            listaTraba.Add(t10);

            Censo<Trabajador>.Registros.AddRange(listaTraba);
           
        }

        public static void HardcodearEstudiantes()
        {
            Estudiante e1 = new Estudiante("Tomas", "Gago", 20, "Masculino", 42896325, "Ramos Mejia", "Soltero", 0, "Secundario", "UTN", "Terciario", "Programacion");
            Estudiante e2 = new Estudiante("Laura", "Ferde", 19, "Otro", 43695874, "Ciudadela", "Soltero", 0, "Secundario", "UTN", "Terciario", "Analista de sistemas");
            Estudiante e3 = new Estudiante("Carla", "Luiato", 22, "Femenino", 40896543, "Ramos Mejia", "Soltero", 0, "Secundario", "Unlam", "Universitario", "Derecho");
            Estudiante e4 = new Estudiante("Lorenzo", "Jadeo", 24, "Otro", 39897425, "Caseros", "Soltero", 0, "Secundario", "Uba", "Universitario", "Programacion");
            Estudiante e5 = new Estudiante("Mateo", "Araujo", 26, "Otro", 43692854, "Lomas Del Mirador", "Casado", 1, "Secundario", "UTN", "Terciario", "Programacion");
            Estudiante e6 = new Estudiante("Pablo", "Perez", 22, "Masculino", 43325684, "Tapiales", "Soltero", 0, "Secundario", "Unlam", "Universitario", "Educacio fisica");
            Estudiante e7 = new Estudiante("Melina", "Tabori", 25, "Femenino", 38963251, "Tapiales", "Soltero", 2, "Primario", "Mariano Moreno", "Secundario", "Bachiller");
            Estudiante e8 = new Estudiante("Belen", "Aybar", 20, "Femenino", 44581263, "Ramos Mejia", "Soltero", 0, "Secundario", "UTN", "Terciario", "Seguridad e higiene");
            Estudiante e9 = new Estudiante("Noemi", "Nureto", 19, "Otro", 44652145, "Ciudadela", "Soltero", 0, "Secundario", "Uba", "Universitario", "Ingenieria industrial");
            Estudiante e10 = new Estudiante("Pilar", "Mastronardi", 21, "Femenino", 42895632, "Caseros", "Soltero", 0, "Secundario", "Unlam", "Universitario", "Derecho");

            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            listaEstudiantes.Add(e1);
            listaEstudiantes.Add(e2);
            listaEstudiantes.Add(e3);
            listaEstudiantes.Add(e4);
            listaEstudiantes.Add(e5);
            listaEstudiantes.Add(e6);
            listaEstudiantes.Add(e7);
            listaEstudiantes.Add(e8);
            listaEstudiantes.Add(e9);
            listaEstudiantes.Add(e10);

            Censo<Estudiante>.Registros.AddRange(listaEstudiantes);
        }
    
        public static void HardcodearDesocupados()
        {
            Desocupado d1 = new Desocupado("Fernanda", "Carulo", 38, "Femenino", 30036965, "Tapiales", "Casado", 4, "Secundario", new DateTime(2020, 05, 15), true);
            Desocupado d2 = new Desocupado("Rene", "Camchatca", 40, "Masculino", 27896365, "Lomas Del Mirador", "Casado", 2, "Secundario", new DateTime(2021,07,10), false);
            Desocupado d3 = new Desocupado("Juan", "Soria", 30, "Masculino", 30695852, "Ciudadela", "Soltero", 1, "Primario", new DateTime(2020,04,06), true);
            Desocupado d4 = new Desocupado("Lorenas", "Rati", 25, "Femenino", 38963214, "Caseros", "Soltero", 2, "Primario", new DateTime(2019,02,20), true);
            Desocupado d5 = new Desocupado("Mirna", "Pape", 22, "Femenino", 39854726, "Ciudadela", "Soltero", 0, "Secundario", new DateTime(2021,04,06), false);
            Desocupado d6 = new Desocupado("Andres", "Carulo", 45, "Masculino", 29863254, "Ciudadela", "Casado", 3, "Secundario", new DateTime(2021,01,15), true);
            Desocupado d7 = new Desocupado("Monica", "Ferche", 29, "Femenino", 31569482, "Tapiales", "Soltero", 0, "Secundario", new DateTime(2020,07,10), false);
            Desocupado d8 = new Desocupado("Rebeca", "Loria", 55, "Femenino", 24896352, "Ramos Mejia", "Casado", 3, "Universitario", new DateTime(2020,09,12), false);
            Desocupado d9 = new Desocupado("Samantha", "Lescano", 40, "Femenino", 31695869, "Tapiales", "Soltero", 0, "Secundario", new DateTime(2019,06,26), false);
            Desocupado d10 = new Desocupado("Martin", "Ternerito", 20, "Otro", 43695821, "Caseros", "Soltero", 0, "Secundario", new DateTime(2020,05,15), false);

            List<Desocupado> listaDesocupados = new List<Desocupado>();
            listaDesocupados.Add(d1);
            listaDesocupados.Add(d2);
            listaDesocupados.Add(d3);
            listaDesocupados.Add(d4);
            listaDesocupados.Add(d5);
            listaDesocupados.Add(d6);
            listaDesocupados.Add(d7);
            listaDesocupados.Add(d8);
            listaDesocupados.Add(d9);
            listaDesocupados.Add(d10);
            

            Censo<Desocupado>.Registros.AddRange(listaDesocupados);

        }

        public static void HardcodearJubilados()
        {
            Jubilado j1 = new Jubilado("Josefa", "Mitre", 66, "Femenino", 21563259, "Ramos Mejia", "Casado", 2, "Universitario", 2015, false);
            Jubilado j2 = new Jubilado("Pepe", "Mitre", 69, "Masculino", 20986325, "Ramos Mejia", "Casado", 3, "Secundario", 2016, true);
            Jubilado j3 = new Jubilado("Juan", "Faferto", 72, "Masculino", 19863254, "Ciudadela", "Casado", 1, "Primario", 2014, false);
            Jubilado j4 = new Jubilado("Pedro", "Gareme", 65, "Masculino", 23658965, "Tapiales", "Casado", 2, "Secundario", 2021, true);
            Jubilado j5 = new Jubilado("Marta", "Benbeta", 63, "Femenino", 23695845, "Tapiales", "Casado", 3, "Secundario", 2018, true);
            Jubilado j6 = new Jubilado("Mirta", "Busnelli", 65, "Femenino", 22693521, "Caseros", "Soltero", 0, "Universitario", 2016, false);
            Jubilado j7 = new Jubilado("Luis", "Nono", 76, "Masculino", 18963254, "Ramos Mejia", "Casado", 4, "Universitario", 2012, false);
            Jubilado j8 = new Jubilado("Gabriel", "Junar", 68, "Masculino", 24589632, "Lomas Del Mirador", "Casado", 2, "Secundario", 2018, true);
            Jubilado j9 = new Jubilado("Norma", "Liyaya", 64, "Femenino", 23695847, "Lomas Del Mirador", "Casado", 1, "Primario", 2017, true);
            Jubilado j10 = new Jubilado("Domingo", "Franco", 67, "Masculino", 22569365, "Tapiales", "Casado", 1, "Secundario", 2019, true);

            List<Jubilado> listaJubilados = new List<Jubilado>();
            listaJubilados.Add(j1);
            listaJubilados.Add(j2);
            listaJubilados.Add(j3);
            listaJubilados.Add(j4);
            listaJubilados.Add(j5);
            listaJubilados.Add(j6);
            listaJubilados.Add(j7);
            listaJubilados.Add(j8);
            listaJubilados.Add(j9);
            listaJubilados.Add(j10);
            
            Censo<Jubilado>.Registros.AddRange(listaJubilados);

        }

        public static void HardcodearEstudiantes_Trabajadores()
        {
            Estudiante_Trabajador et1 = new Estudiante_Trabajador("Lisardo", "Dader", 26, "Otro", 39896526, "Ramos Mejia", "Soltero", 0, "Secundario", "Unlam", "Universitario", "Medicina", true, true, 40);
            Estudiante_Trabajador et2 = new Estudiante_Trabajador("Maximo", "Serrano", 21, "Masculino", 41965365, "Ramos Mejia", "Soltero", 0, "Secundario", "UTN", "Universitario", "Ingenieria electronica", true, true, 30);
            Estudiante_Trabajador et3 = new Estudiante_Trabajador("Maria", "Becerri", 19, "Otro", 43658956, "Ramos Mejia", "Soltero", 0, "Secundario", "Unlam", "Universitario", "Educacion fisica", false, true, 20);
            Estudiante_Trabajador et4 = new Estudiante_Trabajador("Laura", "Pipi", 28, "Femenino", 38658962, "Lomas Del MNirador", "Soltero", 2, "Secundario", "UBA", "Universitario", "Derecho", false, false, 40);
            Estudiante_Trabajador et5 = new Estudiante_Trabajador("Antonia", "Mimina", 24, "Femenino", 40563256, "Tapiales", "Soltero", 0, "Secundario", "Unlam", "Universitario", "Relaciones publicas", true, true, 30);
            Estudiante_Trabajador et6 = new Estudiante_Trabajador("Valentin", "Dader", 23, "Masculino", 39625478, "Tapiales", "Soltero", 0, "Primario", "Mariano Moreno", "Secundario", "Bachiller", false, true, 45);
            Estudiante_Trabajador et7 = new Estudiante_Trabajador("Pablo", "Carlis", 33, "Masculino", 33652958, "Lomas Del Mirador", "Soltero", 0, "Secundario", "UTN", "Terciario", "Programacion", false, false, 40);
            Estudiante_Trabajador et8 = new Estudiante_Trabajador("Melisa", "Loscago", 31, "Femenino", 35968547, "Lomnas Del Mirador", "Soltero", 0, "Secundario", "Unlam", "Terciario", "Psicomotricidad", false, true, 30);
            Estudiante_Trabajador et9 = new Estudiante_Trabajador("Kevin", "Jonas", 22, "Otro", 41236902, "Caseros", "Soltero", 1, "Secundario", "UTN", "Terciario", "Analista de sistemas", false, true, 30);
            Estudiante_Trabajador et10 = new Estudiante_Trabajador("Julian", "Pupo", 30, "Masculino", 37965842, "Caseros", "Casado", 2, "Secundario", "Unlam", "Universitario", "Derecho", true, true, 40);

            List<Estudiante_Trabajador> listaEstuTraba = new List<Estudiante_Trabajador>();
            listaEstuTraba.Add(et1);
            listaEstuTraba.Add(et2);
            listaEstuTraba.Add(et3);
            listaEstuTraba.Add(et4);
            listaEstuTraba.Add(et5);
            listaEstuTraba.Add(et6);
            listaEstuTraba.Add(et7);
            listaEstuTraba.Add(et8);
            listaEstuTraba.Add(et9);
            listaEstuTraba.Add(et10);
            

            Censo<Estudiante_Trabajador>.Registros.AddRange(listaEstuTraba);
        }

        

    }
}

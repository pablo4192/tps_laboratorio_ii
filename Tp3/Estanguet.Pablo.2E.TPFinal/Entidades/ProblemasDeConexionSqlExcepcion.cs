using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProblemasDeConexionSqlExcepcion: Exception
    {
        public ProblemasDeConexionSqlExcepcion(): base("Problemas al intentar insertar informacion en la base de datos")
        {

        }

    }
}

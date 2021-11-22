using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosInvalidosExcepcion: Exception
    {
        public DatosInvalidosExcepcion(): base("Verifique los datos ingresados")
        {

        }

    }
}

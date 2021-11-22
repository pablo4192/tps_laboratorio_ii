using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void GuardarCambiosDelegate<T>(T objeto);
    public delegate void AvisarErrorArchivoDelegate();
    public delegate void AvisarExitoArchivoDelegate();
    
}

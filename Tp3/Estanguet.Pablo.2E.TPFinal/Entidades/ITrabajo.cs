using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface ITrabajo
    {
        bool TrabajoRegistrado
        {
            get; set;
        }

        public bool RelacionDeDependencia
        {
            get; set; 
        }

        public int HorasSemanales
        {
            get; set;
        }

       
        
    }
}

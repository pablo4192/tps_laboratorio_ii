using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Verifica que el nombre contenga solo letras
    /// </summary>
    public static class MetodoDeExtension
    {
        public static bool VerificarNombreArchivo(this string nombreArchivo, string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return false;
            }

            for (int i = 0; i < nombre.Length; i++)
            {
                if (!char.IsLetter(nombre[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}

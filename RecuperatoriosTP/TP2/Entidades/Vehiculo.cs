using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        EMarca marca;
        string chasis;
        ConsoleColor color;

        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }


        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }



        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Datos del vehiculo</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        
        /// <summary>
        /// Conversion explicita de un Vehiculo a string con sus datos
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}");  
            sb.AppendLine($"MARCA : {p.marca}"); 
            sb.AppendLine($"COLOR : {p.color}"); 
            sb.AppendLine("---------------------");

            return sb.ToString();
        }


        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>True si son iguales, False si son distintos</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>True si son distintos, False si son iguales</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
    {
        return !(v1.chasis == v2.chasis);
    }
}
}

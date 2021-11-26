using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas. 
    /// </summary>
    public sealed class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;

        public enum ETipo
        {
            Moto, Automovil, Camioneta, Todos
        }


        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible): this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns>Datos de la lista de vehiculos</returns>
        public override string ToString()
        {
            
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Datos de los vehiculos</returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Tenemos {taller.vehiculos.Count} lugares ocupados de un total de {taller.espacioDisponible} disponibles");
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Camioneta:
                        if(v.GetType() == typeof(Suv)) 
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Moto:
                        if(v.GetType() == typeof(Ciclomotor))
                        sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Automovil:
                        if(v.GetType() == typeof(Sedan))
                        sb.AppendLine(v.Mostrar());
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>El taller con el objeto agregado en caso de que no se encuentre previamente en la lista y haya espacio disponible</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                    return taller;
            }
            
            if(taller.vehiculos.Count < taller.espacioDisponible)
            {
                taller.vehiculos.Add(vehiculo);
            }
            
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>El taller si el elemento a eliminar en caso de que exista en la lista de vehiculos</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
           

            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(v);
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}

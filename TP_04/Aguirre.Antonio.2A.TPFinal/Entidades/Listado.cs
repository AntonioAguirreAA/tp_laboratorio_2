using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Listado<T> where T : Dispositivo
    {
        private List<T> lista;

        public Listado()
        {
            this.lista = new List<T>();
        }

        public List<T> Lista
        {
            get { return this.lista; }
            set { this.lista = value; }
        }

        /// <summary>
        /// Convierte el estado de "Reparación" a "Terminado" y setea la fecha de reparación
        /// </summary>
        /// <param name="dispositivo"></param>
        /// <returns>true si se pudo procesar, false si dispositivo es null o su Estado == Terminado</returns>
        public static bool Procesar (Dispositivo dispositivo)
        {
            bool retorno = false;
            if(dispositivo is not null && dispositivo.Estado == Estado.Reparacion)
            {
                dispositivo.Estado = Estado.Terminado;
                dispositivo.ArregloFinalizado = DateTime.Now;
                retorno = true;
            }
            return retorno;
        }

        #region Operadores
        /// <summary>
        /// Compara si el dispositivo se encuentra en el listado a través del ID
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="dispositivo"></param>
        /// <returns>true si está, false si no está</returns>
        public static bool operator ==(Listado<T> listado, T dispositivo)
        {
            bool retorno = false;
            foreach(Dispositivo item in listado.lista)
            {
                if(item.Id == dispositivo.Id)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Listado<T> listado, T dispositivo)
        {
            return !(listado == dispositivo);
        }

        /// <summary>
        /// Compara si el id se encuentra en el listado
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="dispositivo"></param>
        /// <returns>true si está, false si no está</returns>
        public static bool operator ==(Listado<T> listado, int id)
        {
            bool retorno = false;
            foreach (Dispositivo item in listado.lista)
            {
                if (item.Id == id)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Listado<T> listado, int id)
        {
            return !(listado == id);
        }

        /// <summary>
        /// Agrega un dispositivo al listado, salvo si la ID de este ya se encuentra en otro dispositivo del listado
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="dispositivo"></param>
        /// <returns>true si se agrega, false si no</returns>
        public static bool operator +(Listado<T> listado, T dispositivo)
        {
            bool retorno = false;
            if(listado != dispositivo)
            {
                listado.lista.Add(dispositivo);
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Elimina el dispositivo de la lista, si es que este se encuentra en ella
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="dispositivo"></param>
        /// <returns>true si se elimina correctamente, false si no</returns>
        public static bool operator -(Listado<T> listado, T dispositivo)
        {
            bool retorno = false;
            if (listado == dispositivo)
            {
                listado.lista.Remove(dispositivo);
                retorno = true;
            }
            return retorno;
        }
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Dispositivo d in this.lista)
            {
                sb.AppendLine(d.ToString());
            }
            return sb.ToString();
        }

        public static List<T> Filtrar(Listado<T> listado)
        {
            List<T> aux = new List<T>();
            foreach(T item in listado.Lista)
            {
                if(item.Estado == Estado.Reparacion)
                {
                    aux.Add(item);
                }
            }
            return aux;
        }

        public bool Modificar(T dispositivo)
        {
            bool retorno = false;
            foreach(T d in this.lista)
            {
                if(dispositivo.Id == d.Id)
                {
                    lista.Remove(d);
                    lista.Add(dispositivo);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}

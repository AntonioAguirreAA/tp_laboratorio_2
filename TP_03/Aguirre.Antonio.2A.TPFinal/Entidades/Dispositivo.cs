using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Dispositivo
    {
        private int id;
        private string nombreDuenio;
        private string observacion;
        private float precio;
        private DateTime ingreso;
        private DateTime arregloEstimado;
        private DateTime arregloFinalizado;
        private Estado estado;

        #region Propiedades
        public Estado Estado { get { return this.estado; } set { this.estado = value; } }
        public string Tipo
        {
            get
            {
                if(this is Computadora)
                {
                    return "Computadora";
                }
                else if (this is Celular)
                {
                    return "Celular";
                }
                else
                {
                    return "Dispositivo";
                }
            }
        }
        public string NombreDuenio { get { return this.nombreDuenio; } set { this.nombreDuenio = value; } }
        public string Observacion { get { return this.observacion; } set { this.observacion = value; } }
        public float Precio { get { return this.precio; } set { this.precio = value; } }
        public DateTime Ingreso { get { return this.ingreso; } }
        public DateTime ArregloEstimado { get { return this.arregloEstimado; } set { this.arregloEstimado = value; } }
        public DateTime ArregloFinalizado { get { return this.arregloFinalizado; } set { this.arregloFinalizado = value; } }
        public float Descuento 
        {
            get
            {
                float retorno = 0;
                if(arregloFinalizado > arregloEstimado)
                {
                    retorno = (float)(this.precio * 0.25);
                }
                return retorno;
            } 
        }
        public float PrecioFinal
        {
            get
            {
                return this.precio - this.Descuento;
            }
        }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor por defecto, setea el estado como 'Diagnostico' y la fecha de ingreso (fecha actual)
        /// </summary>
        public Dispositivo()
        {
            this.ingreso = DateTime.Now;
            this.estado = Estado.Reparacion;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombreDuenio"></param>
        /// <param name="senia"></param>
        public Dispositivo(int id, string nombreDuenio, string observacion, int precio, DateTime arregloEstimado):this()
        {
            this.id = id;
            this.nombreDuenio = nombreDuenio;
            this.observacion = observacion;
            this.precio = precio;
            this.arregloEstimado = arregloEstimado;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Dispositivo d1, Dispositivo d2)
        {
            return d1.id == d2.id;
        }

        public static bool operator !=(Dispositivo d1, Dispositivo d2)
        {
            return !(d1 == d2);
        }
        #endregion
        //AGREGAR OPERADORES CONTAINS
        
        public static bool NuevoDispositivo(string strId, string strNombreDuenio, string strObservacion, string strPrecio, DateTime arregloEstimadoss, out Dispositivo dispositivo)
        {
            bool retorno = false;
            dispositivo = null;

            int id;
            float precio;

            if()


            return retorno;
        }


    }
}

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
    [Serializable]
    [XmlInclude(typeof(Computadora))]
    [XmlInclude(typeof(Celular))]

    public abstract class Dispositivo
    {
        private int id;
        private string nombreDuenio;
        private string observacion;
        private int precio;
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
        public int Id { get { return this.id; } set { this.id = value; } }
        public string NombreDuenio { get { return this.nombreDuenio; } set { this.nombreDuenio = value; } }
        public string Observacion { get { return this.observacion; } set { this.observacion = value; } }
        public int Precio { get { return this.precio; } set { this.precio = value; } }
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
            this.arregloFinalizado = DateTime.MinValue;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ID: {this.id} - ");
            sb.Append($"Nombre del dueño: {this.nombreDuenio} - ");
            sb.Append($"Observación: {this.observacion} - ");
            sb.Append($"Precio: ${this.precio} - ");
            sb.Append($"Ingreso: {this.ingreso.ToString("d")} - ");
            sb.Append($"Arreglo estimado: {this.arregloEstimado.ToString("d")} - ");
            if(this.arregloFinalizado != DateTime.MinValue)
            {
                sb.Append($"Estado: {this.estado} - ");
                sb.AppendLine($"Arreglo finalizado: {this.arregloFinalizado.ToString("d")}");
                sb.AppendLine($"Precio final: ${this.PrecioFinal}");
                sb.AppendLine($"(Descuento: -${this.Descuento}");
            }
            else
            {
                sb.Append($"Estado: {this.estado}");
            }
            return sb.ToString();
        }

    }
}

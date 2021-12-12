using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular : Dispositivo
    {
        private Marca marca;

        #region Constructores
        public Celular() : base() { }

        public Celular(int id, string nombreDuenio, string observacion, int precio, DateTime arregloEstimado, Marca marca)
            : base(id, nombreDuenio, observacion, precio, arregloEstimado)
        {
            this.marca = marca;
        }
        #endregion

        public Marca Marca{ get { return this.marca; } set { this.marca = value; } }

        public static bool NuevoCelular(string strId, string strNombreDuenio, string strObservacion, string strPrecio, DateTime arregloEstimado,Marca marca, out Celular celular)
        {
            bool retorno = false;
            celular = null;

            int id;
            int precio;

            if (Int32.TryParse(strId, out id) &&
                Int32.TryParse(strPrecio, out precio) &&
                id >= 0 &&
                precio >= 0 &&
                strNombreDuenio != "" &&
                arregloEstimado >= DateTime.Now)
            {
                celular = new Celular(id, strNombreDuenio, strObservacion, precio, arregloEstimado,marca);
                retorno = true;
            }
            else
            {
                Console.WriteLine("Error generando nuevo celular");
            }

            return retorno;
        }

        public static bool ModificarCelular(Celular celular, string strId, string strNombreDuenio, string strObservacion, string strPrecio, DateTime arregloEstimado,Marca marca)
        {
            bool retorno = false;

            int id;
            int precio;

            if (Int32.TryParse(strId, out id) &&
                Int32.TryParse(strPrecio, out precio) &&
                id >= 0 &&
                precio >= 0 &&
                strNombreDuenio != "" &&
                celular != null &&
                arregloEstimado >= DateTime.Now)
            {
                celular.Id = id;
                celular.NombreDuenio = strNombreDuenio;
                celular.Observacion = strObservacion;
                celular.Precio = precio;
                celular.ArregloEstimado = arregloEstimado;
                celular.Marca = marca;
                retorno = true;
            }
            else
            {
                Console.WriteLine("Error modificando el celular");
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"CELULAR - ");
            sb.Append($"Marca: {this.Marca} - ");
            sb.Append($"{base.ToString()}");
            return sb.ToString();
        }

    }
}

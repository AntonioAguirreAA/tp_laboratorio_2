using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora : Dispositivo
    {
        public Computadora() : base() { }

        public Computadora(int id, string nombreDuenio, string observacion, int precio, DateTime arregloEstimado)
            : base(id,nombreDuenio,observacion,precio,arregloEstimado) { }

        /// <summary>
        /// Recibe los string de los txtBox y genera un objeto del tipo "Computadora"
        /// </summary>
        /// <param name="strId"></param>
        /// <param name="strNombreDuenio"></param>
        /// <param name="strObservacion"></param>
        /// <param name="strPrecio"></param>
        /// <param name="arregloEstimado"></param>
        /// <param name="computadora"></param>
        /// <returns>true si todo ok, false si algun dato es erróneo</returns>
        public static bool NuevaComputadora(string strId, string strNombreDuenio, string strObservacion, string strPrecio, DateTime arregloEstimado, out Computadora computadora)
        {
            bool retorno = false;
            computadora = null;

            int id;
            int precio;

            if (Int32.TryParse(strId, out id) &&
                Int32.TryParse(strPrecio, out precio) &&
                id >= 0 &&
                precio >= 0 &&
                strNombreDuenio != "" &&
                arregloEstimado >= DateTime.Now)
            {
                computadora = new Computadora(id, strNombreDuenio, strObservacion, precio, arregloEstimado);
                retorno = true;
            }
            else
            {
                Console.WriteLine("Error generando nueva computadora");
            }

            return retorno;
        }

        public static bool ModificarComputadora(Computadora computadora, string strId, string strNombreDuenio, string strObservacion, string strPrecio, DateTime arregloEstimado)
        {
            bool retorno = false;

            int id;
            int precio;

            if (Int32.TryParse(strId, out id) &&
                Int32.TryParse(strPrecio, out precio) &&
                id >= 0 &&
                precio >= 0 &&
                strNombreDuenio != "" &&
                arregloEstimado >= DateTime.Now &&
                computadora != null)
            {
                computadora.Id = id;
                computadora.NombreDuenio = strNombreDuenio;
                computadora.Observacion = strObservacion;
                computadora.Precio = precio;
                computadora.ArregloEstimado = arregloEstimado;
                retorno = true;
            }
            else
            {
                Console.WriteLine("Error modificando la computadora");
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"COMPUTADORA - ");
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}

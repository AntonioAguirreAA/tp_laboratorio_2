using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Celular : Dispositivo
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



    }
}

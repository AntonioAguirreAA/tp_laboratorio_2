using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ChoferCombi:Chofer
    {
        private string AireA;//Aire acondicionado

        public ChoferCombi(string nombre, EMarca marca, string patente, int edad, string AireA)
            :base(nombre,marca,patente,edad,0)
        {
            this.AireA = AireA;
        }

        public ChoferCombi(string nombre, EMarca marca, string patente, int edad,int viajesRealizados, string AireA)
            :base(nombre, marca, patente, edad, viajesRealizados)
        {
            this.AireA = AireA;
        }

        protected override int Asientos
        {
            get{ return 19; }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}--Aire Acondicionado: {1}", base.Mostrar(), this.AireA);
            return sb.ToString();
        }
    }
}

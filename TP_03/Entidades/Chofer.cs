using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Chofer
    {
        private string nombre;
        private EMarca marca;
        private string patente;
        private int viajesRealizados;
        private int edad;

        public Chofer(string nombre, EMarca marca, string patente, int edad): this(nombre,marca,patente,edad,0)
        {
        }

        public Chofer(string nombre, EMarca marca, string patente, int edad, int viajesRealizados)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.patente = patente;
            this.viajesRealizados = viajesRealizados;
            this.edad = edad;
        }

        protected virtual int Asientos { get; }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}--{1}--{2}--{3}", this.nombre, this.edad, this.marca, this.viajesRealizados);
            return sb.ToString();
        }

        public static bool operator ==(Chofer c1, Chofer c2)
        {
            return c1.nombre == c2.nombre && c1.patente == c2.patente;
        }

        public static bool operator !=(Chofer c1, Chofer c2)
        {
            return !(c1 == c2);
        }

        //Invalidaciones generadas automaticamente por Visual Studio
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

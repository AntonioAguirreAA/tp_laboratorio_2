using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        private double ValidarOperando(string StrNumero)
        {
            double retorno;
            if(!Double.TryParse(StrNumero,out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }

        public string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }

        private static bool EsBinario(string binario)
        {
            bool retorno = false;
            if(!binario.Contains('0') || !binario.Contains('1'))
            {
                retorno = true;
            }
            return retorno;
        }

        //private static string BinarioDecimal(string binario)
        //{
        //    string retorno = "Valor Inválido";
            
        //    if(EsBinario(binario))
        //    {
        //        int numero = 0;
        //        int digito = 0;
        //        const int DIVISOR = 10;

        //        for (long i = binario, j = 0; i > 0; i /= DIVISOR, j++)
        //        {
        //            digito = (int)i % DIVISOR;
        //            if (digito != 1 && digito != 0)
        //            {
        //                return -1;
        //            }
        //            numero += digito * (int)Math.Pow(2, j);
        //        }

        //        return numero;
        //    }
        //}
        
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = Double.MinValue;
            if(n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}

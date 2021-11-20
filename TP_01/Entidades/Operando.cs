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
            bool retorno = true;
            if(!binario.Contains('0') && !binario.Contains('1'))
            {
                retorno = false;
            }
            return retorno;
        }

        public static string BinarioDecimal(string binario)
        {
            int intResultado = 0;
            char[] charNumero = binario.ToCharArray();
            Array.Reverse(charNumero);
            string strResultado;

            if (EsBinario(binario))
            {
                for (int i = 0; i < charNumero.Length; i++)
                {
                    if (charNumero[i] == '1')
                    {
                        intResultado += (int)Math.Pow(2, i);
                    }
                }
                strResultado = intResultado.ToString();
            }
            else
            {
                strResultado = "Valor inválido";
            }

            return strResultado;
        }

        public static string DecimalBinario(double numero)
        {
            string resultado = null;
            int numeroEntero = (int)numero;

            if (numeroEntero > 0)
            {
                do
                {
                    if (numeroEntero % 2 == 1)
                    {
                        resultado = "1" + resultado;
                    }
                    else if (numeroEntero % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    numeroEntero = numeroEntero / 2;
                } while (numeroEntero != 0);
            }
            else
            {
                resultado = "Valor invalido";
            }
            return resultado;
        }

        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            double decim;
            if(Double.TryParse(numero,out decim))
            {
                retorno = DecimalBinario(decim);
            }
            return retorno;
        }

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

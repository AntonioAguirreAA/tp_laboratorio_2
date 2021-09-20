using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        //ATRIBUTOS
        private double numero;

        //PROPIEDADES
        private string strNumero
        {
            set
            {
                this.numero = ValidarOpearando(value);
            }
        }
        private double ValidarOpearando(string strNumero)
        {
            double retorno;

            double.TryParse(strNumero, out retorno);

            return retorno;
        }

        //CONSTRUCTORES
        public Operando() : this(0)
        {
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            this.strNumero = strNumero;
        }

        //CONVERTIR DE BINARIO A DECIMAL Y VICEVERSA
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            int i;

            for (i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno = false;
                }
            }

            return retorno;
        }

        public static string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";

            int len;
            int i;
            double j;
            double numeroDec = 0;

            if (EsBinario(binario))
            {
                len = binario.Length;

                for (i = len; i > 0; i--)
                {
                    if (binario[i - 1] == '1')
                    {
                        numeroDec += Math.Pow(2, len - i);
                    }
                }

                retorno = Convert.ToString(numeroDec);

            }

            return retorno;
        }

        public static string DecimalBinario(double numero)
        {
            double resto;
            double cociente;
            string retorno = "Valor inválido";

            if (numero > 0)
            {
                retorno = "";

                resto = numero % 2;
                cociente = Math.Floor((float)numero / 2);

                retorno = Convert.ToString(resto) + retorno;

                do
                {
                    resto = cociente % 2;
                    cociente = Math.Floor((float)cociente / 2);

                    retorno = Convert.ToString(resto) + retorno;

                } while (cociente > 1);

                retorno = Convert.ToString(cociente) + retorno;
            }

            return retorno;
        }

        public static string DecimalBinario(string strNumero)
        {
            return DecimalBinario(Convert.ToDouble(strNumero));
        }

        //SOBRECARGA DE OPERADORES
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Operando num1, Operando num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return num1.numero / num2.numero;
            }
        }
    }
}

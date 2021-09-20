using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = operador;
            }

            return retorno;
        }

        /// <summary>
        /// Recibe dos operandos del tipo Operando y un operador en un char y realiza dicha operacion
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de la operacion en un double</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            operador = ValidarOperador(operador);
            double retorno = 0;

            switch (operador)
            {
                case '+':
                    retorno = num1 + num2;
                    break;

                case '-':
                    retorno = num1 - num2;
                    break;

                case '/':
                    retorno = num1 / num2;
                    break;

                case '*':
                    retorno = num1 * num2;
                    break;
            }

            return retorno;
        }
    }
}

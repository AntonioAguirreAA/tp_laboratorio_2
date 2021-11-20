using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperando(char operador)
        { 
            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                return '+';
            }
            return operador;
        }

        public static double Operar(Operando num1,Operando num2,char operador)
        {
            double retorno = 0;

            switch (ValidarOperando(operador))
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

using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Valida que sea un operador valido, caso contrario asigna "+" por defecto
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            if(!Equals(operador,' '))
            {
                if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
                    retorno = operador;
            }

            return retorno;
        }

        /// <summary>
        /// Valida el operar y realiza las operaciones entre numeros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado=num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que sea un operador valido, caso contrario asigna "+" por defecto
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            if (string.IsNullOrEmpty(operador))
                operador = "+";

            if (operador != "+" && operador != "-" && operador != "/" && operador != "*")
                operador = "+";

            return operador;
        }

        /// <summary>
        /// Valida el operar y realiza las operaciones entre numeros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }
    }
}

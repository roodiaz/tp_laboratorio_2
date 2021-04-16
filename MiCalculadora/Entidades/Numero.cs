using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Constructores
        /// <summary>
        /// Inicializa por defecto la instancia numero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa una instancia numero con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa una instancia numero con valor numero y valida que sea un valor valido 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            SetNumero = numero;
        }
        #endregion

        #region Propieades
        /// <summary>
        /// Valida e inicializa un objeto Numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida que el string sea convertible en un dato del tipo double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El string convertido a double o 0 sino pudo realizarse la conversion</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = new double();

            if (double.TryParse(strNumero, out retorno))
                return retorno;
            else
                return 0;
        }

        /// <summary>
        /// Valida que la cadena de caracteres esté compuesta solamente por caracteres '0' o '1'
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>True si contiene solo o y 1, False si contiene otros caracteres</returns>
        private bool EsBinario(string binario)
        {
            int longBin = binario.Length; //leo longitud del string ingresado

            for (int i = 0; i < longBin; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Realiza la conversion de un numero bin a uno decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>String con el binario ya convertido a decimal</returns>
        public string BinarioDecimal(string binario)
        {
            bool bin = EsBinario(binario);

            if (bin)
                return Convert.ToInt32(binario, 2).ToString();
            else
                return "Valor invalido";

        }

        /// <summary>
        /// Valida el decimal y lo convierte a su equivalente binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> La conversion del decimal a binario, "Valor invalido" sino se pudo o 0 si el numero era 0 </returns>
        public string DecimalBinario(double numero)
        {
            string resultado = string.Empty;
            int num = (int)numero;

            if (num == 0)
                resultado = "0";
            if (num < 0)
                resultado = "Valor invalido";

            while (num > 0)
            {
                resultado = num % 2 + resultado;
                num = num / 2;
            }

            return resultado;
        }

        /// <summary>
        /// Valida decimal recibido como string, asigna -1 si no se pudo convertir
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>La conversion del decimal a binario</returns>
        public string DecimalBinario(string numero)
        {
            double numValidado;

            if (double.TryParse(numero, out numValidado))
                return DecimalBinario(numValidado);
            else
                return DecimalBinario(-1);
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Sobrecarga el operador "-" permitiendo la resta de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La resta entre los atributos numero</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "+" permitiendo la suma de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La suma entre los atributos numero</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "*" permitiendo la multiplicacion de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La multiplicacion entre los atributos numero</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "/" permitiendo la division de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La division entre los atributos numero, o dobule.MinValue en caso que el num2 sea 0</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
                return double.MinValue;
            else
                return num1.numero / num2.numero;
        }
        #endregion
    }
}


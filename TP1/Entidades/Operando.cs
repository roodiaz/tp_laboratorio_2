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

        /// <summary>
        /// Valida e inicializa un objeto Numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Inicializa por defecto la instancia numero en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa una instancia numero con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
            :this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa una instancia numero con valor numero y valida que sea un valor valido 
        /// </summary>
        /// <param name="numero"></param>
        public Operando(string strNumero)
            :this()
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Valida que el string sea convertible en un dato del tipo double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El string convertido a double o 0 sino pudo realizarse la conversion</returns>
        private double ValidarOperando(string strNumero)
        {
            if(double.TryParse(strNumero, out double num))
            {
                return num;
            }

            return 0;
        }

        /// <summary>
        /// Valida que la cadena de caracteres esté compuesta solamente por caracteres '0' o '1'
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>True si contiene solo 0 y 1, False si contiene otros caracteres</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length-1; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                    return false;               
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
            if (EsBinario(binario))
            {
                return Convert.ToInt32(binario, 2).ToString();
            }

            return "Valor Invalido";
        }

        /// <summary>
        /// Valida el decimal y lo convierte a su equivalente binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> La conversion del decimal a binario, "Valor invalido" sino se pudo o 0 si el numero era 0 </returns>
        public string DecimalBinario(double numero)
        {           
            if (numero == 0)
                return "0";
            else if (numero < 0)
                return "Valor Invalido";
            else
            {
                long num = (long)Math.Abs(numero);
                return Convert.ToString(num, 2);
            }
                
        }

        /// <summary>
        /// Valida decimal recibido como string, asigna -1 si no se pudo convertir
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>La conversion del decimal a binario</returns>
        public string DecimalBinario(string numero)
        {
            double validado;

            if (double.TryParse(numero, out validado))
                return DecimalBinario(validado);
            else
                return DecimalBinario(-1);
        }

        /// <summary>
        /// Sobrecarga el operador "+" permitiendo la suma de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La suma entre los atributos numero</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "-" permitiendo la resta de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La resta entre los atributos numero</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "*" permitiendo la multiplicacion de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La multiplicacion entre los atributos numero</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "/" permitiendo la division de los atributos entre dos objetos tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La division entre los atributos numero, o dobule.MinValue en caso que el num2 sea 0</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return n1.numero / n2.numero;
        }
    }
}

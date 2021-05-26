using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Digital : VideoJuego
    {
        private double costo;
        private double tamanio;

        /// <summary>
        /// constructor de videojuego digital
        /// </summary>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name="plataforma">plataforma para desarrollo</param>
        /// <param name="region">region del juego</param>
        public Digital(string codigoJuego, Plataforma plataforma,Region region)
            : base(codigoJuego, plataforma,region)
        {
            this.costo = 0;
            this.tamanio = 0;
        }

        /// <summary>
        /// constructor de videojuego digital
        /// </summary>
        /// <param name = "nombre" > nombre del juego</param>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name = "region" > region del juego</param>
        /// <param name = "plataforma" > plataforma para desarrollo</param>
        /// <param name="estadoJuego">fase de desarrollo del juego</param>
        /// <param name="costo">costo del juego</param>
        /// <param name="tamanio">tamanio total del juego</param>
        public Digital(string nombre, string codigoJuego, Region region, Plataforma plataforma, EstadoJuego estadoJuego, double costo, double tamanio)
            : base(nombre, codigoJuego, region, plataforma, estadoJuego)
        {
            this.Costo = costo;
            this.Tamanio = tamanio; ;
        }

        /// <summary>
        /// propiedad lectura/escritura de atributo costo
        /// </summary>
        public override double Costo
        {
            get { return this.costo; }
            set
            {
                if (value > 0)
                    this.costo = value;
                else
                    this.costo = 0;
            }
        }

        /// <summary>
        /// propiedad lectura/escritura e atributo tamanio expresado en gb
        /// </summary>
        public double Tamanio
        {
            get { return this.tamanio; }
            set
            {
                if (value > 0)
                    this.tamanio = value;
                else
                    this.tamanio = 0;

            }
        }

        /// <summary>
        /// sobreescritura del metodo base infoJuego que agrega informacion 
        /// </summary>
        /// <returns></returns>
        public override string InfoJuego()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.InfoJuego());
            sb.AppendLine($"COSTO: {this.Costo}US");
            sb.AppendLine($"TAMANIO: {this.Tamanio}GB");

            return sb.ToString();
        }
    }
}

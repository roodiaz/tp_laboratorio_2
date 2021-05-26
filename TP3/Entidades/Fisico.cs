using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fisico : VideoJuego
    {
        private double costo;

        /// <summary>
        /// constructor de videojuegofisico
        /// </summary>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name="plataforma">plataforma para desarrollo</param>
        /// <param name="region">region del juego</param>
        public Fisico(string codigoJuego, Plataforma plataforma,Region region)
            : base(codigoJuego, plataforma, region)
        {
            this.costo = 0;
        }

        /// <summary>
        /// constructor de videojuego fisico
        /// </summary>
        /// <param name = "nombre" > nombre del juego</param>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name = "region" > region del juego</param>
        /// <param name = "plataforma" > plataforma para desarrollo</param>
        /// <param name="estadoJuego">fase de desarrollo del juego</param>
        /// <param name="costo">costo del juego</param>
        public Fisico(string nombre,string codigoJuego, Region region, Plataforma plataforma, EstadoJuego estadoJuego, double costo)
            : base(nombre,codigoJuego,region,plataforma,estadoJuego)
        {
            this.Costo = costo;
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
            
            return sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public abstract class VideoJuego
    {
        private string nombre;
        private string codigoJuego;
        private Region region;
        private Plataforma plataforma;


        /* ####################### CONSTRUCTORES ###########################*/

        /// <summary>
        /// Constructor juego
        /// </summary>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name="plataforma">plataforma para desarrollo</param>
        public VideoJuego(string codigoJuego, Plataforma plataforma, Region region)
        {
            this.CodigoJuego = codigoJuego;
            this.region = region;
            this.plataforma = plataforma;
        }

        /// <summary>
        /// Constructor del juego
        /// </summary>
        /// <param name = "nombre" > nombre del juego</param>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name = "region" > region del juego</param>
        /// <param name = "plataforma" > plataforma para desarrollo</param>
        /// <param name="estadoJuego">fase de desarrollo del juego</param>
        public VideoJuego(string nombre, string codigoJuego, Region region, Plataforma plataforma)
            : this(codigoJuego, plataforma, region)
        {
            this.Nombre = nombre;
        }

        /* ########################## PROPIEDADES ##############################*/

        /// <summary>
        /// Propiedad de lectura y escritura para atributo "nombre" con validacion 
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 2)
                    this.nombre = "Sin especificar";
                else
                    this.nombre = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para atributo "codigoJuego" con validacion 
        /// </summary>
        public string CodigoJuego
        {
            get { return this.codigoJuego; }
            set
            {
                if (int.TryParse(value, out int aux) && aux > 3000000 && aux < 3999999)
                {
                    this.codigoJuego = value;
                }
                else
                    this.codigoJuego = "Sin especificar";
            }
        }

        /// <summary>
        /// Propiedad solo lectura para atributo "region"
        /// </summary>
        public Region Region
        {
            get { return this.region; }
        }

        /// <summary>
        /// Propiedad solo lectura para atributo "plataforma"
        /// </summary>
        public Plataforma Plataforma
        {
            get { return this.plataforma; }
        }

        /// <summary>
        /// Propiedad lectura que retorna el tipo de objeto de instacia
        /// </summary>
        public string TipoJuego
        {
            get
            {
                return this.GetType().ToString();
            }
        }

        /// <summary>
        /// Propiedad abstracta de lectura y escritura para ser implementada en derivadas
        /// </summary>


        /* ########################## METODOS ##########################*/

        /// <summary>
        /// Metodo que devuelve informacion del videojuego
        /// </summary>
        /// <returns></returns>
        public virtual string InfoJuego()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE JUEGO: {this.Nombre}");
            sb.AppendLine($"PLATAFORMA DESARROLLO: {this.Plataforma}");
            sb.AppendLine($"TIPO DE JUEGO: {this.TipoJuego}");
            sb.AppendLine($"REGION JUEGO: {this.Region}");
            sb.AppendLine($"CODIGO JUEGO: {this.CodigoJuego}");

            return sb.ToString();
        }

       


        /* ########################## SOBRECARGAS ##########################*/

        /// <summary>
        /// Si dos juegos comparten mismo codigo y plataforma de desarrollo se los considera iguales y devuelve true
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(VideoJuego j1, VideoJuego j2)
        {
            if (!(j1 is null) && !(j2 is null))
                if (j1.codigoJuego == j2.codigoJuego && j1.plataforma == j2.plataforma)
                    return true;

            return false;
        }

        /// <summary>
        /// Si dos juegos no comparten mismo "codigoJuego" se los considera distintos y devuelve false
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator !=(VideoJuego j1, VideoJuego j2)
        {
            return !(j1 == j2);
        }

    }
}

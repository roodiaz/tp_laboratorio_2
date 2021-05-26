using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Desarrollo<T>
        where T : VideoJuego
    {
        private string desarrolladora;
        private List<T> listaJuegos;

        /// <summary>
        /// 
        /// </summary>
        private Desarrollo()
        {
            this.listaJuegos = new List<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="desarrolladora"></param>
        public Desarrollo(string desarrolladora)
            : this()
        {
            this.Desarrolladora = desarrolladora;
        }

        /// <summary>
        /// Propiedad de lectura y escritura para atributo "desarrolladora" con validacion 
        /// </summary>
        public string Desarrolladora
        {
            get { return this.desarrolladora; }
            set
            {
                //if (String.IsNullOrEmpty(value) || value.Length < 2)
                //    this.desarrolladora = "Sin especificar";
                //else
                this.desarrolladora = value;
            }
        }

        public string InfoJuegosEnDisenio()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"JUEGOS EN DISENIO: \n");

            foreach (VideoJuego item in this.listaJuegos)
            {
                if (item.EstadoJuego == EstadoJuego.faseDiseño)
                    sb.AppendLine($"{item.InfoJuego()}");
            }

            return sb.ToString();
        }

        public string InfoJuegosEnDesarrollo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"JUEGOS EN DESARROLLO: \n");

            foreach (VideoJuego item in this.listaJuegos)
            {
                if (item.EstadoJuego == EstadoJuego.faseDesarrollo)
                    sb.AppendLine($"{item.InfoJuego()}");
            }

            return sb.ToString();
        }

        public string InfoJuegosEnTesteo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"JUEGOS EN TESTEO: \n");

            foreach (VideoJuego item in this.listaJuegos)
            {
                if (item.EstadoJuego == EstadoJuego.faseTesteo)
                    sb.AppendLine($"{item.InfoJuego()}");
            }

            return sb.ToString();
        }

        public string InfoJuegosEnDistribucion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"JUEGOS EN DISTRIBUCION: \n");

            foreach (VideoJuego item in this.listaJuegos)
            {
                if (item.EstadoJuego == EstadoJuego.faseDistribucion)
                    sb.AppendLine($"{item.InfoJuego()}");
            }

            return sb.ToString();
        }

        public string InfoJuegos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE DESARROLLADORA: {this.Desarrolladora}");
            sb.AppendLine("\n###### LISTA DE JUEGOS ###### \n");
            sb.AppendLine(InfoJuegosEnDisenio());
            sb.AppendLine(InfoJuegosEnDesarrollo());
            sb.AppendLine(InfoJuegosEnTesteo());
            sb.AppendLine(InfoJuegosEnDistribucion());

            return sb.ToString();
        }

        public static bool operator +(Desarrollo<T> d, VideoJuego v)
        {
            if (!(d is null) && !(v is null))
            {

                d.listaJuegos.Add((T)v);
                return true;

            }

            return false;
        }
    }
}

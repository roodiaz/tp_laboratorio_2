using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Produccion<T>
        where T : VideoJuego
    {
        const string distribuidora = "Sony Computer Entertainment";
        private List<T> listaJuegos;

        /// <summary>
        /// 
        /// </summary>
        public Produccion()
        {
            this.listaJuegos = new List<T>();
        }

        public List<T> Lista
        {
            get { return this.listaJuegos; }
        }

        public string InfoJuegosFisicos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n###### LISTA DE JUEGOS FISICOS ###### \n");

            foreach (VideoJuego item in this.listaJuegos)
            {
                if(item.GetType() == typeof(Fisico))
                {
                    sb.AppendLine(item.InfoJuego());
                    sb.AppendLine("----------------------------------------");
                }
                
            }

            return sb.ToString();
        }

        public string InfoJuegosDigitales()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n###### LISTA DE JUEGOS DIGITALES ###### \n");

            foreach (VideoJuego item in this.listaJuegos)
            {
                if(item.GetType() == typeof(Digital))
                {
                    sb.AppendLine(item.InfoJuego());
                    sb.AppendLine("----------------------------------------");
                }
                
            }

            return sb.ToString();
        }

        public string InfoJuegos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(InfoJuegosDigitales());
            sb.AppendLine(InfoJuegosFisicos());

            return sb.ToString();
        }

        public string Distribuidora
        {
            get { return distribuidora; }
        }

        public static bool operator ==(Produccion<T> d, VideoJuego v)
        {
            if (!(d is null) && !(v is null))
            {
                foreach (T item in d.listaJuegos)
                {
                    if (item == v)
                        return true;
                }
            }

            return false;
        }

        public static bool operator !=(Produccion<T> d, VideoJuego v)
        {
            return !(d == v);
        }

        public static bool operator +(Produccion<T> d, VideoJuego v)
        {
            if (d != v)
            {
                d.listaJuegos.Add((T)v);
                return true;
            }

            return false;
        }
    }
}

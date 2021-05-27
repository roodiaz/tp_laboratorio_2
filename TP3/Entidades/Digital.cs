using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Digital : VideoJuego
    {
        public enum EstadoJuegoDigital
        {
            sinAsignar,
            cargarAServidor,
            liberarJuego

        }

        private double tamanio;
        private EstadoJuegoDigital estado;

        /// <summary>
        /// constructor de videojuego digital
        /// </summary>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name="plataforma">plataforma para desarrollo</param>
        /// <param name="region">region del juego</param>
        public Digital(string codigoJuego, Plataforma plataforma, Region region)
            : base(codigoJuego, plataforma, region)
        {
            this.estado = EstadoJuegoDigital.sinAsignar;
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
        public Digital(string nombre, string codigoJuego, Region region, Plataforma plataforma, double tamanio, EstadoJuegoDigital estado)
            : base(nombre, codigoJuego, region, plataforma)
        {
            this.Tamanio = tamanio;
            this.estado = estado;

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
        /// 
        /// </summary>
        public EstadoJuegoDigital Estado
        {
            get { return this.estado; }
        }

        /// <summary>
        /// sobreescritura del metodo base infoJuego que agrega informacion 
        /// </summary>
        /// <returns></returns>
        public override string InfoJuego()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.InfoJuego());
            sb.AppendLine($"TAMANIO: {this.Tamanio}GB");
            sb.AppendLine($"ESTADO DEL JUEGO: {this.Estado}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return string.Format($"NOMBRE JUEGO: {this.Nombre}, ESTADO DEL JUEGO: {this.Estado} ");
        }

        public string Producir(EstadoJuegoDigital e)
        {
            string estado = String.Empty;

            switch (e)
            {
                case EstadoJuegoDigital.cargarAServidor:
                    if (this.Estado == EstadoJuegoDigital.sinAsignar)
                    {
                        this.estado = EstadoJuegoDigital.cargarAServidor;
                        estado = "Preparando juego para cargar a los servidores";
                    }
                    else if (this.estado == EstadoJuegoDigital.cargarAServidor)
                        estado = "El juego ya esta cargado en los servidores";
                    else
                        estado = "Debe mandar a cargar el juego al servidor";
                    break;
                case EstadoJuegoDigital.liberarJuego:
                    if (this.Estado == EstadoJuegoDigital.cargarAServidor)
                    {
                        this.estado = EstadoJuegoDigital.liberarJuego;
                        estado = "Preparando juego para lanzar";
                    }
                    else if (this.estado == EstadoJuegoDigital.liberarJuego)
                        estado = "Juego ya liberado";
                    else
                        estado = "Debe liberar el juego";
                    break;
            }

            return estado;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fisico : VideoJuego
    {
        public enum EstadoJuegoFisico
        {
            sinAsignar,
            grabadoDisco,
            fabricacionCaja,
            impresionCaratula,
            empaquetado,
            distribucion
        }
        private double costoProduccionPorUnidad;
        private int stock;
        private EstadoJuegoFisico estado;

        /// <summary>
        /// constructor de videojuegofisico
        /// </summary>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name="plataforma">plataforma para desarrollo</param>
        /// <param name="region">region del juego</param>
        public Fisico(string codigoJuego, Plataforma plataforma,Region region)
            : base(codigoJuego, plataforma, region)
        {
            this.estado = EstadoJuegoFisico.sinAsignar;
        }

        /// <summary>
        /// constructor de videojuego fisico
        /// </summary>
        /// <param name = "nombre" > nombre del juego</param>
        /// <param name = "codigoJuego" > codigo unico de juego</param>
        /// <param name = "region" > region del juego</param>
        /// <param name = "plataforma" > plataforma para desarrollo</param>
        /// <param name="estado">fase de desarrollo del juego</param>
        /// <param name="costo">costo del juego</param>
        public Fisico(string nombre,string codigoJuego, Region region, Plataforma plataforma, double costo, EstadoJuegoFisico estado)
            : base(nombre,codigoJuego,region,plataforma)
        {
            this.CostoProduccionPorUnidad = costo;
            this.Stock = 0;
            this.estado = estado;
        }

        /// <summary>
        /// propiedad lectura/escritura de atributo costo
        /// </summary>
        public double CostoProduccionPorUnidad
        {
            get { return this.costoProduccionPorUnidad; }
            set
            {
                if (value > 0)
                    this.costoProduccionPorUnidad = value;
                else
                    this.costoProduccionPorUnidad = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public EstadoJuegoFisico Estado
        {
            get { return this.estado; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Stock
        {
            get { return this.stock; }
            set
            {
                if (value > 0)
                    this.stock = value;
                else
                    this.stock = 0;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public double CostoProduccionPorStock
        {
            get
            {
                double aux = this.CostoProduccionPorUnidad;

                return aux *= this.Stock;
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
            sb.AppendLine($"COSTO POR UNIDAD: {this.CostoProduccionPorUnidad}US");
            sb.AppendLine($"COSTO POR PRODUCCION TOTAL: {this.CostoProduccionPorStock}US");
            sb.AppendLine($"STOCK: {this.Stock}");
            sb.AppendLine($"ESTADO DE PRODUCCION: {this.Estado}");

            return sb.ToString();
        }


        /// <summary>
        /// Sobrecarga de metodo ToString para que solo devuelve nombre y estado de videojuego
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"NOMBRE JUEGO: {this.Nombre}, ESTADO DEL JUEGO: {this.Estado}");
        }

        public string Producir(EstadoJuegoFisico e )
        {
            string estado = string.Empty;

            switch (e)
            {
                case EstadoJuegoFisico.fabricacionCaja:
                    if (this.Estado == EstadoJuegoFisico.sinAsignar)
                    {
                        this.estado = EstadoJuegoFisico.fabricacionCaja;
                        estado = "Cajas recibidas para fabricar";
                    }
                    else if (this.Estado == EstadoJuegoFisico.fabricacionCaja)
                        estado = "Las cajas ya estan fabricadas";
                    else
                        estado = "Debe mandar a fabricar cajas";
                    break;
                case EstadoJuegoFisico.impresionCaratula:
                    if (this.Estado == EstadoJuegoFisico.fabricacionCaja)
                    {
                        this.estado = EstadoJuegoFisico.impresionCaratula;
                        estado = "Caratulas recibidas para impresion";
                    }
                    else if (this.Estado == EstadoJuegoFisico.impresionCaratula)
                        estado = "Las caratulas ya estan fabricadas";
                    else
                        estado = "Debe mandar a imprimir las caratulas";
                    break;
                case EstadoJuegoFisico.grabadoDisco:
                    if (this.Estado == EstadoJuegoFisico.impresionCaratula)
                    {
                        this.estado = EstadoJuegoFisico.grabadoDisco;
                        estado = "Grabado de videojuegos en Blu-Ray en proceso";
                    }
                    else if (this.Estado == EstadoJuegoFisico.grabadoDisco)
                        estado = "Los Blu-Ray ya estan grabados";
                    else
                        estado = "Debe mandar a grabar los Blu-Ray ";
                    break;
                case EstadoJuegoFisico.empaquetado:
                    if (this.Estado == EstadoJuegoFisico.grabadoDisco)
                    {
                        this.estado = EstadoJuegoFisico.empaquetado;
                        estado = "Juegos recibidos para empaquetar";
                        
                    }
                    else if (this.Estado == EstadoJuegoFisico.empaquetado)
                        estado = "Juegos ya empaquetados";
                    else
                        estado = "Debe mandar a empaquetar los juegos";
                    break;
                case EstadoJuegoFisico.distribucion:
                    if (this.Estado == EstadoJuegoFisico.empaquetado || this.Estado == EstadoJuegoFisico.distribucion)
                    {
                        this.estado = EstadoJuegoFisico.distribucion;
                        estado = "Listo para su distribucion";                       
                    }
                    else
                        estado = "Debe distribuir los juegos";
                    break;
            }

            return estado;
        }

        //public string Distribuir(int stockAFabricar)
        //{
        //    string estado = string.Empty;

        //    if (this.Estado == EstadoJuegoFisico.distribucion)
        //    {
        //        this.stock += stockAFabricar;
        //        estado = "Juegos fabricados con exito";
        //    }
        //    else
        //        estado = "Los juegos ya estan fabricados";

        //    return estado;
        //}


    }
}

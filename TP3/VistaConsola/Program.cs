using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Desarrollo<VideoJuego> capcom = new Desarrollo<VideoJuego>("Capcom");
            Desarrollo<VideoJuego> rockstar = new Desarrollo<VideoJuego>("Rockstar Games");

            Digital gtaDigital = new Digital("GTA 5","3564879",Region.Region_1_USA,Plataforma.PlayStation4,EstadoJuego.faseTesteo,0,45.5);
            Digital RE8 = new Digital("RESIDENT EVIL 8", "3098078", Region.Region_2_Europa, Plataforma.PlayStation5, EstadoJuego.faseDistribucion, 89.99, 63.8);

            Fisico spider = new Fisico("Spider man", "3657456", Region.Region_3_Asia, Plataforma.PlayStation4, EstadoJuego.faseDistribucion, 49.99);
            Fisico fifa = new Fisico("fifa 2022", "3654789", Region.Region_2_Europa, Plataforma.PlayStation3, EstadoJuego.faseDesarrollo, 0);

            bool ok;

            ok = capcom + RE8;
            ok = capcom + spider;
            ok = rockstar + gtaDigital;
            ok = rockstar + fifa;

            Console.WriteLine(capcom.InfoJuegos());
 
            Console.ReadKey();
        }
    }
}

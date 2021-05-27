using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmPrincipal : Form
    {
        Produccion<VideoJuego> listaJuegos;

        public FrmPrincipal()
        {
            InitializeComponent();
            listaJuegos = new Produccion<VideoJuego>();
            this.lblNombreDistribuidora.Text = listaJuegos.Distribuidora;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Digital d1 = new Digital("Watch dogs: Legion", "3092834", Entidades.Region.Region_3_Asia, Plataforma.PlayStation5, 56.89, Digital.EstadoJuegoDigital.cargarAServidor);
            Digital d2 = new Digital("FIFA 2022", "3005254", Entidades.Region.Region_1_USA, Plataforma.PlayStation4, 44.87, Digital.EstadoJuegoDigital.sinAsignar);
            Digital d3 = new Digital("Far Cry 3", "3007023", Entidades.Region.Region_2_Europa, Plataforma.PlayStation3, 14.87, Digital.EstadoJuegoDigital.liberarJuego);
            Digital d4 = new Digital("Returnal", "3468251", Entidades.Region.Region_1_USA, Plataforma.PlayStation5, 51.87, Digital.EstadoJuegoDigital.sinAsignar);
            Fisico f1 = new Fisico("Spider Man: Miles Morales", "3564324", Entidades.Region.Region_2_Europa, Plataforma.PlayStation5, 45.99, Fisico.EstadoJuegoFisico.sinAsignar);
            Fisico f2 = new Fisico("Resident Evil 7", "3098154", Entidades.Region.Region_1_USA, Plataforma.PlayStation4, 36.78, Fisico.EstadoJuegoFisico.grabadoDisco);
            Fisico f3 = new Fisico("The last of us", "3245675", Entidades.Region.Region_3_Asia, Plataforma.PlayStation3, 25.89, Fisico.EstadoJuegoFisico.impresionCaratula);
            Fisico f4 = new Fisico("Resident Evil 8", "3114690", Entidades.Region.Region_1_USA, Plataforma.PlayStation5, 56.43, Fisico.EstadoJuegoFisico.fabricacionCaja);
            Fisico f5 = new Fisico("Call of duty: Cold war", "3008904", Entidades.Region.Region_2_Europa, Plataforma.PlayStation5, 49.45, Fisico.EstadoJuegoFisico.sinAsignar);

            bool ok;

            ok = listaJuegos + d1;
            ok = listaJuegos + d2;
            ok = listaJuegos + d3;
            ok = listaJuegos + d4;
            ok = listaJuegos + f1;
            ok = listaJuegos + f2;
            ok = listaJuegos + f3;
            ok = listaJuegos + f4;
            ok = listaJuegos + f5;

        }

        private void btnJuegoFisico_Click(object sender, EventArgs e)
        {
            FrmGenerarFisico aux = new FrmGenerarFisico(this.listaJuegos);
            aux.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnCargarDatosJuegos_Click(object sender, EventArgs e)
        {

        }


    }
}

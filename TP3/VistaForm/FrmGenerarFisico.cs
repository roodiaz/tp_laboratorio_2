using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FrmGenerarFisico : Form
    {
        private Produccion<VideoJuego> lista;

        public FrmGenerarFisico(Produccion<VideoJuego> p)
        {
            InitializeComponent();
            this.lista = p;

        }

        private void FrmGenerarFisico_Load(object sender, EventArgs e)
        {
            foreach (VideoJuego item in this.lista.Lista)
            {
                if (item.GetType() == typeof(Fisico))
                    this.lbListaFisicos.Items.Add(item);
            }

        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Fisico fisico = (Fisico)lbListaFisicos.SelectedItem;


            if (!(lbListaFisicos.SelectedItem is null))
            {




            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un videojuego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

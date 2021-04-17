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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicializa los componentes
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            lblResultado.Text = "0";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        /// <summary>
        /// Cierra el forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar calculadora?", "Salir",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Convierte de decimal a binario
        /// Se desactiva el boton para convertir a binario y se activa el de convertir a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string numero = lblResultado.Text;

            Numero num = new Numero();
            lblResultado.Text = num.DecimalBinario(numero);

        }

        /// <summary>
        /// Convierte binario a decimal
        /// Habilita el boton de convertir a binario y se desactiva el boton de convertir a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string numero = lblResultado.Text;

            Numero num = new Numero();
            lblResultado.Text = num.BinarioDecimal(numero);

        }

        /// <summary>
        /// Borra los datos de los TextBox, ComboBox y Label de la pantalla.
        /// Deshabilita los botones de convertir a binario y a decimal.
        /// </summary>
        void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperator.Text = "";
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        /// <summary>
        /// Limpia los campos y setea todo de cero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Crea dos intancias de la clase Numero y usar el método Operar.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado del método Operar.</returns>
        private static double Operar(string num1, string num2, string operador)
        {
            double resultado;
            Numero n1 = new Numero(num1);
            Numero n2 = new Numero(num2);

            return resultado = Calculadora.Operar(n1, n2, operador);

        }

        /// <summary>
        /// Instancia la calculadora y ambos operadores, consigue los valores de las textbox y valida lo necesario para poder operar.
        /// habilita el boton de convertir a binario y calcula la operacion y la escribe en el lbl de resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = Convert.ToString(cmbOperator.SelectedItem);

            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, operador));

            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
            btnLimpiar.Enabled = true;
        }
    }
}

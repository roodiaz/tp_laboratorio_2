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
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Desea salir?", "Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cierra el forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Borra los datos de los TextBox, ComboBox y Label de la pantalla
        /// Deshabilita los botones de convertir a binario y a decimal
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "0";
            this.cmbOperador.SelectedIndex = -1;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
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
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);          

            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }

        /// <summary>
        /// Instancia la calculadora y ambos operadores, consigue los valores de las textbox y valida lo necesario para poder operar.
        /// habilita el boton de convertir a binario y calcula la operacion y la escribe en el lbl de resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (cmbOperador.SelectedItem is null)
                MessageBox.Show("debe seleccionar operador!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(txtNumero1.Text == string.Empty || txtNumero2.Text == string.Empty)
                MessageBox.Show("Falta ingresar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString()));
                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.SelectedItem} {txtNumero2.Text} = {lblResultado.Text}");
                btnConvertirABinario.Enabled = true;
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
            Operando num = new Operando();

            lblResultado.Text = num.DecimalBinario(lblResultado.Text);

            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Convierte binario a decimal
        /// Habilita el boton de convertir a binario y se desactiva el boton de convertir a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {           
            Operando num = new Operando();

            lblResultado.Text = num.BinarioDecimal(lblResultado.Text);

            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
        
    }
}

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
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte a binario un Decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando binario = new Operando(0);

            lblResultado.Text = binario.DecimalBinario(lblResultado.Text);

        }

        /// <summary>
        /// Convierte a decimal un binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando binAdeci = new Operando(0);

            lblResultado.Text = binAdeci.BinarioDecimal(lblResultado.Text);

        }

        /// <summary>
        /// Limpia TextBox, LisBox, Label del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Realiza las operaciones matematicas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = this.txtNumero1.Text;
            string numero2 = this.txtNumero2.Text;

            lblResultado.Text = Operar(numero1, numero2, cmbOperador.SelectedItem.ToString()).ToString();

            lstOperaciones.Items.Add($"{numero1} {cmbOperador.SelectedItem} {numero2} = {lblResultado.Text}");

            if(numero2 == "0" && cmbOperador.SelectedItem.ToString() == "/" )
            {
                MessageBox.Show("Error, no es posible dividir por 0");
            }
        }

        public FormCalculadora()
        {
            InitializeComponent();
            
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.SelectedIndex = 0;
            Limpiar();
        }

        /// <summary>
        /// Limpia textBox, listBox, Label
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            lblResultado.Text = "";
            lstOperaciones.Items.Clear();
        }
    
        /// <summary>
        /// Realiza la operacion matematica
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns> Resultado </returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?", "Confirme por favor.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    
    }
}

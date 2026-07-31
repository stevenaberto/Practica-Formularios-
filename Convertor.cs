using System;
using System.Drawing;
using System.Windows.Forms;

namespace Avanzado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboConversion.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un tipo de conversión.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double resultado = 0;
            string sufijo = "";

            switch (cboConversion.SelectedIndex)
            {
                case 0: resultado = valor * 0.621371; sufijo = " Millas"; break;
                case 1: resultado = valor / 0.621371; sufijo = " Km"; break;
                case 2: resultado = (valor * 9 / 5) + 32; sufijo = " °F"; break;
                case 3: resultado = (valor - 32) * 5 / 9; sufijo = " °C"; break;
            }

            lblResultado.Text = "Resultado: " + resultado.ToString("0.00") + sufijo;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            cboConversion.SelectedIndex = -1;
            lblResultado.Text = "Resultado: ---";
            txtValor.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
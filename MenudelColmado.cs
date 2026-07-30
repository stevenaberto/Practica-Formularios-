using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace MenuColmado
{
    public partial class MenudelColmado : Form
    {
        // Diccionario: producto -> precio unitario
        private Dictionary<string, decimal> productos = new Dictionary<string, decimal>();

        public MenudelColmado()
        {
            InitializeComponent();
        }

        private void MenudelColmado_Load(object sender, EventArgs e)
        {
            // Productos de ejemplo con su precio
            productos.Add("Arroz (lb)", 35.00m);
            productos.Add("Habichuelas (lb)", 60.00m);
            productos.Add("Aceite (botella)", 150.00m);
            productos.Add("Leche (cartón)", 90.00m);
            productos.Add("Pan (unidad)", 20.00m);
            productos.Add("Huevos (cartón x30)", 320.00m);

            foreach (var item in productos)
                cboProductos.Items.Add(item.Key);

            if (cboProductos.Items.Count > 0)
                cboProductos.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar que haya un producto seleccionado
            if (cboProductos.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            // Validar que la cantidad sea un número válido
            if (!decimal.TryParse(txtCantidad.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida (número mayor que 0).");
                return;
            }

            string producto = cboProductos.SelectedItem.ToString();
            decimal precioUnitario = productos[producto];
            decimal total = precioUnitario * cantidad;

            string formaPago = rbEfectivo.Checked ? "Efectivo" : "Tarjeta";

            lblTotal.Text = $"Total: RD$ {total.ToString("N2", CultureInfo.InvariantCulture)} " +
                            $"({formaPago})";
        }
    }
}
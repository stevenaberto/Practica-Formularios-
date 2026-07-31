using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegistroClientes
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            // Validar teléfono (10 dígitos numéricos)
            if (!Regex.IsMatch(telefono, @"^\d{10}$"))
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos numéricos (sin guiones ni espacios).");
                return;
            }

            // Validar correo (formato básico: algo@algo.algo)
            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingresa un correo válido (ejemplo: nombre@dominio.com).");
                return;
            }

            // Agregar a la lista y limpiar campos
            lstClientes.Items.Add($"{nombre} | Tel: {telefono} | {correo}");

            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }
    }
}
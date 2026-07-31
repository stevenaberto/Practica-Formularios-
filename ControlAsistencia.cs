using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlAsistencia
{
    public partial class ControlAsistencia : Form
    {
        // Diccionario: nombre del estudiante -> presente (true/false)
        private Dictionary<string, bool> asistencia = new Dictionary<string, bool>();

        public ControlAsistencia()
        {
            InitializeComponent();
        }

        private void ControlAsistencia_Load(object sender, EventArgs e)
        {
            // Lista de estudiantes de ejemplo
            string[] estudiantes = { "Ana Pérez", "Luis Gómez", "María Rosa",
                                      "Carlos Díaz", "Sofía Martínez" };

            foreach (string nombre in estudiantes)
            {
                asistencia[nombre] = false; // todos empiezan como ausentes
                lstEstudiantes.Items.Add(nombre);
            }
        }

        // Al seleccionar un estudiante, el checkbox muestra su estado actual
        private void lstEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem != null)
            {
                string nombre = lstEstudiantes.SelectedItem.ToString() ?? "";
                chkPresente.Checked = asistencia[nombre];
            }
        }

        // Botón "Marcar": guarda el estado del checkbox para el estudiante seleccionado
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            if (lstEstudiantes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un estudiante primero.");
                return;
            }

            string nombre = lstEstudiantes.SelectedItem.ToString() ?? "";
            asistencia[nombre] = chkPresente.Checked;

            MessageBox.Show($"{nombre} marcado como " +
                (chkPresente.Checked ? "PRESENTE" : "AUSENTE"));
        }

        // Botón "Generar Resumen": arma el texto con presentes y ausentes
        private void btnResumen_Click(object sender, EventArgs e)
        {
            int presentes = asistencia.Count(a => a.Value == true);
            int ausentes = asistencia.Count(a => a.Value == false);

            string resumen = "=== RESUMEN DE ASISTENCIA ===\r\n\r\n";
            resumen += $"Total de estudiantes: {asistencia.Count}\r\n";
            resumen += $"Presentes: {presentes}\r\n";
            resumen += $"Ausentes: {ausentes}\r\n\r\n";

            resumen += "-- Presentes --\r\n";
            foreach (var item in asistencia.Where(a => a.Value == true))
                resumen += $"✔ {item.Key}\r\n";

            resumen += "\r\n-- Ausentes --\r\n";
            foreach (var item in asistencia.Where(a => a.Value == false))
                resumen += $"✘ {item.Key}\r\n";

            txtResumen.Text = resumen;
        }
    }
}
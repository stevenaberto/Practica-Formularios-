namespace ControlAsistencia
{
    partial class ControlAsistencia
    {
        /// <summary>
        /// Variable de diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.chkPresente = new System.Windows.Forms.CheckBox();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de Asistencia";
            //
            // lstEstudiantes
            //
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.Location = new System.Drawing.Point(12, 60);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(200, 150);
            this.lstEstudiantes.TabIndex = 1;
            this.lstEstudiantes.SelectedIndexChanged += new System.EventHandler(this.lstEstudiantes_SelectedIndexChanged);
            //
            // chkPresente
            //
            this.chkPresente.AutoSize = true;
            this.chkPresente.Location = new System.Drawing.Point(230, 60);
            this.chkPresente.Name = "chkPresente";
            this.chkPresente.Size = new System.Drawing.Size(83, 24);
            this.chkPresente.TabIndex = 2;
            this.chkPresente.Text = "Presente";
            this.chkPresente.UseVisualStyleBackColor = true;
            //
            // btnMarcar
            //
            this.btnMarcar.Location = new System.Drawing.Point(230, 100);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(100, 30);
            this.btnMarcar.TabIndex = 3;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            //
            // btnResumen
            //
            this.btnResumen.Location = new System.Drawing.Point(12, 220);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(150, 30);
            this.btnResumen.TabIndex = 4;
            this.btnResumen.Text = "Generar Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            //
            // txtResumen
            //
            this.txtResumen.Location = new System.Drawing.Point(12, 260);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ReadOnly = true;
            this.txtResumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResumen.Size = new System.Drawing.Size(400, 180);
            this.txtResumen.TabIndex = 5;
            //
            // ControlAsistencia
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 460);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.chkPresente);
            this.Controls.Add(this.lstEstudiantes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ControlAsistencia";
            this.Text = "Control de Asistencia";
            this.Load += new System.EventHandler(this.ControlAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.CheckBox chkPresente;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.TextBox txtResumen;
    }
}
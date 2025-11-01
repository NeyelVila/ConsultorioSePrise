namespace Consultorio.Presentacion1
{
    partial class frmConsultorioMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSalaEspera = new System.Windows.Forms.Label();
            this.dgvSalaEspera = new System.Windows.Forms.DataGridView();
            this.btnLlamarSiguiente = new System.Windows.Forms.Button();
            this.btnActualizarEspera = new System.Windows.Forms.Button();
            this.gbPacienteActual = new System.Windows.Forms.GroupBox();
            this.btnGuardarAtencion = new System.Windows.Forms.Button();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblPacienteHoraTurno = new System.Windows.Forms.Label();
            this.lblPacienteDNI = new System.Windows.Forms.Label();
            this.lblPacienteNombre = new System.Windows.Forms.Label();
            this.gbHistorial = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblBienvenidoMedico = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaEspera)).BeginInit();
            this.gbPacienteActual.SuspendLayout();
            this.gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalaEspera
            // 
            this.lblSalaEspera.AutoSize = true;
            this.lblSalaEspera.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaEspera.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSalaEspera.Location = new System.Drawing.Point(9, 63);
            this.lblSalaEspera.Name = "lblSalaEspera";
            this.lblSalaEspera.Size = new System.Drawing.Size(208, 17);
            this.lblSalaEspera.TabIndex = 0;
            this.lblSalaEspera.Text = "\"Sala de Espera (Acreditados)\"";
            // 
            // dgvSalaEspera
            // 
            this.dgvSalaEspera.AllowUserToAddRows = false;
            this.dgvSalaEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaEspera.Location = new System.Drawing.Point(12, 80);
            this.dgvSalaEspera.Name = "dgvSalaEspera";
            this.dgvSalaEspera.ReadOnly = true;
            this.dgvSalaEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaEspera.Size = new System.Drawing.Size(331, 528);
            this.dgvSalaEspera.TabIndex = 1;
            // 
            // btnLlamarSiguiente
            // 
            this.btnLlamarSiguiente.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLlamarSiguiente.Location = new System.Drawing.Point(12, 614);
            this.btnLlamarSiguiente.Name = "btnLlamarSiguiente";
            this.btnLlamarSiguiente.Size = new System.Drawing.Size(178, 27);
            this.btnLlamarSiguiente.TabIndex = 2;
            this.btnLlamarSiguiente.Text = "\"Llamar Siguiente Paciente\"";
            this.btnLlamarSiguiente.UseVisualStyleBackColor = true;
            this.btnLlamarSiguiente.Click += new System.EventHandler(this.btnLlamarSiguiente_Click);
            // 
            // btnActualizarEspera
            // 
            this.btnActualizarEspera.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActualizarEspera.Location = new System.Drawing.Point(205, 616);
            this.btnActualizarEspera.Name = "btnActualizarEspera";
            this.btnActualizarEspera.Size = new System.Drawing.Size(178, 27);
            this.btnActualizarEspera.TabIndex = 3;
            this.btnActualizarEspera.Text = "\"Actualizar Lista\"";
            this.btnActualizarEspera.UseVisualStyleBackColor = true;
            this.btnActualizarEspera.Click += new System.EventHandler(this.btnActualizarEspera_Click);
            // 
            // gbPacienteActual
            // 
            this.gbPacienteActual.BackColor = System.Drawing.Color.Transparent;
            this.gbPacienteActual.Controls.Add(this.btnGuardarAtencion);
            this.gbPacienteActual.Controls.Add(this.txtTratamiento);
            this.gbPacienteActual.Controls.Add(this.lblTratamiento);
            this.gbPacienteActual.Controls.Add(this.txtDiagnostico);
            this.gbPacienteActual.Controls.Add(this.lblDiagnostico);
            this.gbPacienteActual.Controls.Add(this.txtMotivoConsulta);
            this.gbPacienteActual.Controls.Add(this.lblMotivo);
            this.gbPacienteActual.Controls.Add(this.lblPacienteHoraTurno);
            this.gbPacienteActual.Controls.Add(this.lblPacienteDNI);
            this.gbPacienteActual.Controls.Add(this.lblPacienteNombre);
            this.gbPacienteActual.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPacienteActual.Location = new System.Drawing.Point(372, 80);
            this.gbPacienteActual.Name = "gbPacienteActual";
            this.gbPacienteActual.Size = new System.Drawing.Size(321, 528);
            this.gbPacienteActual.TabIndex = 4;
            this.gbPacienteActual.TabStop = false;
            this.gbPacienteActual.Text = "Paciente en Consulta";
            // 
            // btnGuardarAtencion
            // 
            this.btnGuardarAtencion.Enabled = false;
            this.btnGuardarAtencion.Location = new System.Drawing.Point(68, 444);
            this.btnGuardarAtencion.Name = "btnGuardarAtencion";
            this.btnGuardarAtencion.Size = new System.Drawing.Size(180, 66);
            this.btnGuardarAtencion.TabIndex = 9;
            this.btnGuardarAtencion.Text = "Guardar y Finalizar Atención";
            this.btnGuardarAtencion.UseVisualStyleBackColor = true;
            this.btnGuardarAtencion.Click += new System.EventHandler(this.btnGuardarAtencion_Click);
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(9, 357);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTratamiento.Size = new System.Drawing.Size(290, 50);
            this.txtTratamiento.TabIndex = 8;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Location = new System.Drawing.Point(18, 328);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(187, 17);
            this.lblTratamiento.TabIndex = 7;
            this.lblTratamiento.Text = "Tratamiento / Indicaciones:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(9, 268);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(290, 50);
            this.txtDiagnostico.TabIndex = 6;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(12, 252);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(89, 17);
            this.lblDiagnostico.TabIndex = 5;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Location = new System.Drawing.Point(9, 181);
            this.txtMotivoConsulta.Multiline = true;
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotivoConsulta.Size = new System.Drawing.Size(290, 50);
            this.txtMotivoConsulta.TabIndex = 4;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(12, 165);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(137, 17);
            this.lblMotivo.TabIndex = 3;
            this.lblMotivo.Text = "Motivo de Consulta:";
            // 
            // lblPacienteHoraTurno
            // 
            this.lblPacienteHoraTurno.AutoSize = true;
            this.lblPacienteHoraTurno.Location = new System.Drawing.Point(6, 107);
            this.lblPacienteHoraTurno.Name = "lblPacienteHoraTurno";
            this.lblPacienteHoraTurno.Size = new System.Drawing.Size(59, 17);
            this.lblPacienteHoraTurno.TabIndex = 2;
            this.lblPacienteHoraTurno.Text = "Turno: -";
            // 
            // lblPacienteDNI
            // 
            this.lblPacienteDNI.AutoSize = true;
            this.lblPacienteDNI.Location = new System.Drawing.Point(6, 71);
            this.lblPacienteDNI.Name = "lblPacienteDNI";
            this.lblPacienteDNI.Size = new System.Drawing.Size(46, 17);
            this.lblPacienteDNI.TabIndex = 1;
            this.lblPacienteDNI.Text = "DNI: -";
            // 
            // lblPacienteNombre
            // 
            this.lblPacienteNombre.AutoSize = true;
            this.lblPacienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteNombre.Location = new System.Drawing.Point(5, 31);
            this.lblPacienteNombre.Name = "lblPacienteNombre";
            this.lblPacienteNombre.Size = new System.Drawing.Size(95, 20);
            this.lblPacienteNombre.TabIndex = 0;
            this.lblPacienteNombre.Text = "Paciente: -";
            // 
            // gbHistorial
            // 
            this.gbHistorial.BackColor = System.Drawing.Color.Transparent;
            this.gbHistorial.Controls.Add(this.dgvHistorial);
            this.gbHistorial.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbHistorial.Location = new System.Drawing.Point(699, 80);
            this.gbHistorial.Name = "gbHistorial";
            this.gbHistorial.Size = new System.Drawing.Size(480, 528);
            this.gbHistorial.TabIndex = 5;
            this.gbHistorial.TabStop = false;
            this.gbHistorial.Text = "Historial Clínico";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.Location = new System.Drawing.Point(6, 19);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(468, 503);
            this.dgvHistorial.TabIndex = 1;
            // 
            // lblBienvenidoMedico
            // 
            this.lblBienvenidoMedico.AutoSize = true;
            this.lblBienvenidoMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidoMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenidoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoMedico.Location = new System.Drawing.Point(0, 0);
            this.lblBienvenidoMedico.Name = "lblBienvenidoMedico";
            this.lblBienvenidoMedico.Size = new System.Drawing.Size(134, 18);
            this.lblBienvenidoMedico.TabIndex = 6;
            this.lblBienvenidoMedico.Text = "Bienvenido, Dr. -";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Control;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 718);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(1191, 54);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmConsultorioMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Consultorio.Presentacion1.Properties.Resources.Gemini_Generated_Image_2px2xd2px2xd2px21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 772);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenidoMedico);
            this.Controls.Add(this.gbHistorial);
            this.Controls.Add(this.gbPacienteActual);
            this.Controls.Add(this.btnActualizarEspera);
            this.Controls.Add(this.btnLlamarSiguiente);
            this.Controls.Add(this.dgvSalaEspera);
            this.Controls.Add(this.lblSalaEspera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultorioMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultorioMedico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaEspera)).EndInit();
            this.gbPacienteActual.ResumeLayout(false);
            this.gbPacienteActual.PerformLayout();
            this.gbHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalaEspera;
        private System.Windows.Forms.DataGridView dgvSalaEspera;
        private System.Windows.Forms.Button btnLlamarSiguiente;
        private System.Windows.Forms.Button btnActualizarEspera;
        private System.Windows.Forms.GroupBox gbPacienteActual;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblPacienteHoraTurno;
        private System.Windows.Forms.Label lblPacienteDNI;
        private System.Windows.Forms.Label lblPacienteNombre;
        private System.Windows.Forms.Button btnGuardarAtencion;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.GroupBox gbHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblBienvenidoMedico;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
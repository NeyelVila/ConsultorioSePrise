namespace Consultorio.Presentacion1
{
    partial class frmGestionTurnos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnRegistrarPaciente = new System.Windows.Forms.Button();
            this.txtObraSocial = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.txtBuscarDNI = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfirmarTurno = new System.Windows.Forms.Button();
            this.chkEsSobreturno = new System.Windows.Forms.CheckBox();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.dtpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.dgvTurnosDelDia = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDelDia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.btnRegistrarPaciente);
            this.groupBox1.Controls.Add(this.txtObraSocial);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.btnBuscarDNI);
            this.groupBox1.Controls.Add(this.txtBuscarDNI);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\"Datos Paciente\"";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(68, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.Text = "textBox1";
            // 
            // btnRegistrarPaciente
            // 
            this.btnRegistrarPaciente.Location = new System.Drawing.Point(52, 313);
            this.btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            this.btnRegistrarPaciente.Size = new System.Drawing.Size(138, 31);
            this.btnRegistrarPaciente.TabIndex = 6;
            this.btnRegistrarPaciente.Text = "REGISTRAR PACIENTE";
            this.btnRegistrarPaciente.UseVisualStyleBackColor = true;
            this.btnRegistrarPaciente.Click += new System.EventHandler(this.btnRegistrarPaciente_Click);
            // 
            // txtObraSocial
            // 
            this.txtObraSocial.Location = new System.Drawing.Point(68, 263);
            this.txtObraSocial.Name = "txtObraSocial";
            this.txtObraSocial.Size = new System.Drawing.Size(100, 20);
            this.txtObraSocial.TabIndex = 5;
            this.txtObraSocial.Text = "txtObraSocial";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(6, 232);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(68, 172);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.Text = "txtTelefono";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(68, 65);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCompleto.TabIndex = 2;
            this.txtNombreCompleto.Text = "txtNombreCompleto";
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.Location = new System.Drawing.Point(170, 28);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDNI.TabIndex = 1;
            this.btnBuscarDNI.Text = "send";
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // txtBuscarDNI
            // 
            this.txtBuscarDNI.Location = new System.Drawing.Point(68, 28);
            this.txtBuscarDNI.Name = "txtBuscarDNI";
            this.txtBuscarDNI.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarDNI.TabIndex = 0;
            this.txtBuscarDNI.Text = "txtBuscarDNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfirmarTurno);
            this.groupBox2.Controls.Add(this.chkEsSobreturno);
            this.groupBox2.Controls.Add(this.cmbHorarios);
            this.groupBox2.Controls.Add(this.cmbProfesional);
            this.groupBox2.Controls.Add(this.cmbEspecialidad);
            this.groupBox2.Controls.Add(this.dtpFechaTurno);
            this.groupBox2.Location = new System.Drawing.Point(558, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 432);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "\"Asignar Turno\"";
            // 
            // btnConfirmarTurno
            // 
            this.btnConfirmarTurno.Location = new System.Drawing.Point(46, 285);
            this.btnConfirmarTurno.Name = "btnConfirmarTurno";
            this.btnConfirmarTurno.Size = new System.Drawing.Size(147, 23);
            this.btnConfirmarTurno.TabIndex = 5;
            this.btnConfirmarTurno.Text = "CONFIRMAR TURNO";
            this.btnConfirmarTurno.UseVisualStyleBackColor = true;
            this.btnConfirmarTurno.Click += new System.EventHandler(this.btnConfirmarTurno_Click);
            // 
            // chkEsSobreturno
            // 
            this.chkEsSobreturno.AutoSize = true;
            this.chkEsSobreturno.Location = new System.Drawing.Point(24, 237);
            this.chkEsSobreturno.Name = "chkEsSobreturno";
            this.chkEsSobreturno.Size = new System.Drawing.Size(103, 17);
            this.chkEsSobreturno.TabIndex = 4;
            this.chkEsSobreturno.Text = "Es SobreTurno?";
            this.chkEsSobreturno.UseVisualStyleBackColor = true;
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(55, 185);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(121, 21);
            this.cmbHorarios.TabIndex = 3;
            this.cmbHorarios.SelectedIndexChanged += new System.EventHandler(this.cmbHorarios_SelectedIndexChanged);
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(55, 125);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesional.TabIndex = 2;
            this.cmbProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbProfesional_SelectedIndexChanged);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(55, 77);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 1;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // dtpFechaTurno
            // 
            this.dtpFechaTurno.Location = new System.Drawing.Point(24, 33);
            this.dtpFechaTurno.Name = "dtpFechaTurno";
            this.dtpFechaTurno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTurno.TabIndex = 0;
            // 
            // dgvTurnosDelDia
            // 
            this.dgvTurnosDelDia.AllowUserToAddRows = false;
            this.dgvTurnosDelDia.AllowUserToDeleteRows = false;
            this.dgvTurnosDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosDelDia.Location = new System.Drawing.Point(271, 13);
            this.dgvTurnosDelDia.Name = "dgvTurnosDelDia";
            this.dgvTurnosDelDia.ReadOnly = true;
            this.dgvTurnosDelDia.Size = new System.Drawing.Size(281, 408);
            this.dgvTurnosDelDia.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(285, 437);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(417, 437);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmGestionTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvTurnosDelDia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGestionTurnos";
            this.Text = "frmGestionTurnos";
            this.Load += new System.EventHandler(this.frmGestionTurnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDelDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.TextBox txtObraSocial;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.TextBox txtBuscarDNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkEsSobreturno;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DateTimePicker dtpFechaTurno;
        private System.Windows.Forms.Button btnConfirmarTurno;
        private System.Windows.Forms.DataGridView dgvTurnosDelDia;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtApellido;
    }
}
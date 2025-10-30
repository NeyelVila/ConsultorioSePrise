namespace Consultorio.Presentacion1
{
    partial class frmAdmision
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFechaAdmision = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvTurnosDelDia = new System.Windows.Forms.DataGridView();
            this.btnAcreditar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDelDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "\"Admisión de Pacientes | SePrise\"";
            // 
            // dtpFechaAdmision
            // 
            this.dtpFechaAdmision.Location = new System.Drawing.Point(82, 64);
            this.dtpFechaAdmision.Name = "dtpFechaAdmision";
            this.dtpFechaAdmision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAdmision.TabIndex = 1;
            this.dtpFechaAdmision.Value = new System.DateTime(2025, 10, 29, 21, 22, 16, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(82, 114);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(175, 29);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "\"Actualizar Lista\"";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvTurnosDelDia
            // 
            this.dgvTurnosDelDia.AllowUserToAddRows = false;
            this.dgvTurnosDelDia.AllowUserToDeleteRows = false;
            this.dgvTurnosDelDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnosDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosDelDia.Location = new System.Drawing.Point(12, 149);
            this.dgvTurnosDelDia.Name = "dgvTurnosDelDia";
            this.dgvTurnosDelDia.ReadOnly = true;
            this.dgvTurnosDelDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosDelDia.Size = new System.Drawing.Size(958, 545);
            this.dgvTurnosDelDia.TabIndex = 4;
            // 
            // btnAcreditar
            // 
            this.btnAcreditar.Enabled = false;
            this.btnAcreditar.Location = new System.Drawing.Point(477, 701);
            this.btnAcreditar.Name = "btnAcreditar";
            this.btnAcreditar.Size = new System.Drawing.Size(155, 40);
            this.btnAcreditar.TabIndex = 5;
            this.btnAcreditar.Text = "\"Acreditar Paciente\"";
            this.btnAcreditar.UseVisualStyleBackColor = true;
            this.btnAcreditar.Click += new System.EventHandler(this.btnAcreditar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(743, 704);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 35);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAcreditar);
            this.Controls.Add(this.dgvTurnosDelDia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaAdmision);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAdmision";
            this.Text = "frmAdmision";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDelDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaAdmision;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvTurnosDelDia;
        private System.Windows.Forms.Button btnAcreditar;
        private System.Windows.Forms.Button btnVolver;
    }
}
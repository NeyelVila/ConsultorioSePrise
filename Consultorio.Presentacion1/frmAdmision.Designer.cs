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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDelDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(406, 28);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(471, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "\"Admisión de Pacientes | SePrise\"";
            // 
            // dtpFechaAdmision
            // 
            this.dtpFechaAdmision.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpFechaAdmision.Location = new System.Drawing.Point(109, 86);
            this.dtpFechaAdmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaAdmision.Name = "dtpFechaAdmision";
            this.dtpFechaAdmision.Size = new System.Drawing.Size(265, 28);
            this.dtpFechaAdmision.TabIndex = 1;
            this.dtpFechaAdmision.Value = new System.DateTime(2025, 10, 29, 21, 22, 16, 0);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(34, 86);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 25);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(109, 149);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(233, 38);
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
            this.dgvTurnosDelDia.Location = new System.Drawing.Point(16, 195);
            this.dgvTurnosDelDia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTurnosDelDia.Name = "dgvTurnosDelDia";
            this.dgvTurnosDelDia.ReadOnly = true;
            this.dgvTurnosDelDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosDelDia.Size = new System.Drawing.Size(1277, 531);
            this.dgvTurnosDelDia.TabIndex = 4;
            // 
            // btnAcreditar
            // 
            this.btnAcreditar.Enabled = false;
            this.btnAcreditar.Location = new System.Drawing.Point(1060, 734);
            this.btnAcreditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcreditar.Name = "btnAcreditar";
            this.btnAcreditar.Size = new System.Drawing.Size(233, 40);
            this.btnAcreditar.TabIndex = 5;
            this.btnAcreditar.Text = "\"Acreditar Paciente\"";
            this.btnAcreditar.UseVisualStyleBackColor = true;
            this.btnAcreditar.Click += new System.EventHandler(this.btnAcreditar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1128, 152);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(165, 35);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Consultorio.Presentacion1.Properties.Resources.iconoSEPRISE_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(1123, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Consultorio.Presentacion1.Properties.Resources.Gemini_Generated_Image_2px2xd2px2xd2px21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 863);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAcreditar);
            this.Controls.Add(this.dgvTurnosDelDia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaAdmision);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmision";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosDelDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
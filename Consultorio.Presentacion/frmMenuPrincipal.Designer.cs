namespace Consultorio.Presentacion
{
    partial class frmMenuPrincipal
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
            this.btnGestionTurnos = new System.Windows.Forms.Button();
            this.btnGestionPacientes = new System.Windows.Forms.Button();
            this.btnGestionProfesionales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionTurnos
            // 
            this.btnGestionTurnos.Location = new System.Drawing.Point(204, 161);
            this.btnGestionTurnos.Name = "btnGestionTurnos";
            this.btnGestionTurnos.Size = new System.Drawing.Size(153, 56);
            this.btnGestionTurnos.TabIndex = 0;
            this.btnGestionTurnos.Text = "GESTION DE TURNOS";
            this.btnGestionTurnos.UseVisualStyleBackColor = true;
            // 
            // btnGestionPacientes
            // 
            this.btnGestionPacientes.Location = new System.Drawing.Point(524, 161);
            this.btnGestionPacientes.Name = "btnGestionPacientes";
            this.btnGestionPacientes.Size = new System.Drawing.Size(166, 56);
            this.btnGestionPacientes.TabIndex = 0;
            this.btnGestionPacientes.Text = "GESTION DE PACIENTES";
            this.btnGestionPacientes.UseVisualStyleBackColor = true;
            // 
            // btnGestionProfesionales
            // 
            this.btnGestionProfesionales.Location = new System.Drawing.Point(347, 241);
            this.btnGestionProfesionales.Name = "btnGestionProfesionales";
            this.btnGestionProfesionales.Size = new System.Drawing.Size(186, 58);
            this.btnGestionProfesionales.TabIndex = 0;
            this.btnGestionProfesionales.Text = "GESTION DE PROFESIONALES";
            this.btnGestionProfesionales.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultorio.Presentacion.Properties.Resources.iconoSEPRISE;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(673, 12);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(106, 23);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnGestionProfesionales);
            this.Controls.Add(this.btnGestionPacientes);
            this.Controls.Add(this.btnGestionTurnos);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionTurnos;
        private System.Windows.Forms.Button btnGestionPacientes;
        private System.Windows.Forms.Button btnGestionProfesionales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
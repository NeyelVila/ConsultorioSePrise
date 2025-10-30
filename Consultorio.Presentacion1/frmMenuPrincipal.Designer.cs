namespace Consultorio.Presentacion1
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAdmision = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionTurnos
            // 
            this.btnGestionTurnos.Location = new System.Drawing.Point(184, 97);
            this.btnGestionTurnos.Name = "btnGestionTurnos";
            this.btnGestionTurnos.Size = new System.Drawing.Size(141, 63);
            this.btnGestionTurnos.TabIndex = 0;
            this.btnGestionTurnos.Text = "GESTION DE TURNOS";
            this.btnGestionTurnos.UseVisualStyleBackColor = true;
            this.btnGestionTurnos.Click += new System.EventHandler(this.btnGestionTurnos_Click);
            // 
            // btnGestionPacientes
            // 
            this.btnGestionPacientes.Location = new System.Drawing.Point(493, 97);
            this.btnGestionPacientes.Name = "btnGestionPacientes";
            this.btnGestionPacientes.Size = new System.Drawing.Size(134, 51);
            this.btnGestionPacientes.TabIndex = 1;
            this.btnGestionPacientes.Text = "GESTION DE PACIENTES";
            this.btnGestionPacientes.UseVisualStyleBackColor = true;
            this.btnGestionPacientes.Click += new System.EventHandler(this.btnGestionPacientes_Click);
            // 
            // btnGestionProfesionales
            // 
            this.btnGestionProfesionales.Location = new System.Drawing.Point(339, 200);
            this.btnGestionProfesionales.Name = "btnGestionProfesionales";
            this.btnGestionProfesionales.Size = new System.Drawing.Size(138, 64);
            this.btnGestionProfesionales.TabIndex = 2;
            this.btnGestionProfesionales.Text = "GESTION DE PROFESIONALES";
            this.btnGestionProfesionales.UseVisualStyleBackColor = true;
            this.btnGestionProfesionales.Click += new System.EventHandler(this.btnGestionProfesionales_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(621, 13);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(162, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAdmision
            // 
            this.btnAdmision.Location = new System.Drawing.Point(270, 295);
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Size = new System.Drawing.Size(288, 76);
            this.btnAdmision.TabIndex = 5;
            this.btnAdmision.Text = "\"ADMISION DE PACIENTES\"";
            this.btnAdmision.UseVisualStyleBackColor = true;
            this.btnAdmision.Click += new System.EventHandler(this.btnAdmision_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consultorio.Presentacion1.Properties.Resources.iconoSEPRISE;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdmision);
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
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdmision;
    }
}
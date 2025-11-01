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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGestionTurnos
            // 
            this.btnGestionTurnos.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionTurnos.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionTurnos.Location = new System.Drawing.Point(47, 70);
            this.btnGestionTurnos.Name = "btnGestionTurnos";
            this.btnGestionTurnos.Size = new System.Drawing.Size(164, 70);
            this.btnGestionTurnos.TabIndex = 0;
            this.btnGestionTurnos.Text = "GESTION DE TURNOS";
            this.btnGestionTurnos.UseVisualStyleBackColor = false;
            this.btnGestionTurnos.Click += new System.EventHandler(this.btnGestionTurnos_Click);
            // 
            // btnGestionPacientes
            // 
            this.btnGestionPacientes.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionPacientes.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPacientes.Location = new System.Drawing.Point(433, 70);
            this.btnGestionPacientes.Name = "btnGestionPacientes";
            this.btnGestionPacientes.Size = new System.Drawing.Size(164, 70);
            this.btnGestionPacientes.TabIndex = 1;
            this.btnGestionPacientes.Text = "GESTION DE PACIENTES";
            this.btnGestionPacientes.UseVisualStyleBackColor = false;
            this.btnGestionPacientes.Click += new System.EventHandler(this.btnGestionPacientes_Click);
            // 
            // btnGestionProfesionales
            // 
            this.btnGestionProfesionales.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionProfesionales.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProfesionales.Location = new System.Drawing.Point(433, 180);
            this.btnGestionProfesionales.Name = "btnGestionProfesionales";
            this.btnGestionProfesionales.Size = new System.Drawing.Size(164, 70);
            this.btnGestionProfesionales.TabIndex = 2;
            this.btnGestionProfesionales.Text = "GESTION DE PROFESIONALES";
            this.btnGestionProfesionales.UseVisualStyleBackColor = false;
            this.btnGestionProfesionales.Click += new System.EventHandler(this.btnGestionProfesionales_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Location = new System.Drawing.Point(232, 361);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(162, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "CERRAR SESION";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAdmision
            // 
            this.btnAdmision.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmision.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmision.Location = new System.Drawing.Point(47, 191);
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Size = new System.Drawing.Size(164, 70);
            this.btnAdmision.TabIndex = 5;
            this.btnAdmision.Text = "\"ADMISION DE PACIENTES\"";
            this.btnAdmision.UseVisualStyleBackColor = false;
            this.btnAdmision.Click += new System.EventHandler(this.btnAdmision_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Consultorio.Presentacion1.Properties.Resources.Gemini_Generated_Image_2px2xd2px2xd2px2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmision);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnGestionProfesionales);
            this.Controls.Add(this.btnGestionPacientes);
            this.Controls.Add(this.btnGestionTurnos);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGestionTurnos;
        private System.Windows.Forms.Button btnGestionPacientes;
        private System.Windows.Forms.Button btnGestionProfesionales;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAdmision;
        private System.Windows.Forms.Label label1;
    }
}
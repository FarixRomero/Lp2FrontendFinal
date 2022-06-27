namespace LP2Clinica
{
    partial class frmAdministrarMedico
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditarDatos = new System.Windows.Forms.Button();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.btnVerCalendario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.nombrecompleto = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(389, 477);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(146, 33);
            this.btnCerrar.TabIndex = 86;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditarDatos
            // 
            this.btnEditarDatos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditarDatos.FlatAppearance.BorderSize = 0;
            this.btnEditarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDatos.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDatos.ForeColor = System.Drawing.Color.White;
            this.btnEditarDatos.Location = new System.Drawing.Point(62, 361);
            this.btnEditarDatos.Name = "btnEditarDatos";
            this.btnEditarDatos.Size = new System.Drawing.Size(146, 33);
            this.btnEditarDatos.TabIndex = 85;
            this.btnEditarDatos.TabStop = false;
            this.btnEditarDatos.Text = "Editar Datos";
            this.btnEditarDatos.UseVisualStyleBackColor = false;
            this.btnEditarDatos.Click += new System.EventHandler(this.btnEditarDatos_Click);
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrarCita.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistrarCita.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCita.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCita.Location = new System.Drawing.Point(226, 419);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(146, 33);
            this.btnRegistrarCita.TabIndex = 87;
            this.btnRegistrarCita.TabStop = false;
            this.btnRegistrarCita.Text = "Registrar Cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = false;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // btnVerCalendario
            // 
            this.btnVerCalendario.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnVerCalendario.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVerCalendario.FlatAppearance.BorderSize = 0;
            this.btnVerCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCalendario.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCalendario.ForeColor = System.Drawing.Color.White;
            this.btnVerCalendario.Location = new System.Drawing.Point(62, 419);
            this.btnVerCalendario.Name = "btnVerCalendario";
            this.btnVerCalendario.Size = new System.Drawing.Size(146, 33);
            this.btnVerCalendario.TabIndex = 89;
            this.btnVerCalendario.TabStop = false;
            this.btnVerCalendario.Text = "Ver Calendario";
            this.btnVerCalendario.UseVisualStyleBackColor = false;
            this.btnVerCalendario.Click += new System.EventHandler(this.btnVerCalendario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(351, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 103;
            this.label4.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 102;
            this.label5.Text = "Correo Electronico:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblEspecialidad.Location = new System.Drawing.Point(58, 234);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(129, 22);
            this.lblEspecialidad.TabIndex = 100;
            this.lblEspecialidad.Text = "_Especialidad_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 99;
            this.label2.Text = "Especialidad:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblDNI.Location = new System.Drawing.Point(58, 167);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(60, 22);
            this.lblDNI.TabIndex = 98;
            this.lblDNI.Text = "_DNI_";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LP2Clinica.Properties.Resources.profilepicture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::LP2Clinica.Properties.Resources.Madurez_emocional_7;
            this.pictureBox1.Location = new System.Drawing.Point(355, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblNombreCompleto.Location = new System.Drawing.Point(58, 99);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(173, 22);
            this.lblNombreCompleto.TabIndex = 97;
            this.lblNombreCompleto.Text = "_Nombre Completo_";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.BackColor = System.Drawing.Color.Transparent;
            this.dni.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.White;
            this.dni.Location = new System.Drawing.Point(58, 145);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(45, 22);
            this.dni.TabIndex = 96;
            this.dni.Text = "DNI:";
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.AutoSize = true;
            this.nombrecompleto.BackColor = System.Drawing.Color.Transparent;
            this.nombrecompleto.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrecompleto.ForeColor = System.Drawing.Color.White;
            this.nombrecompleto.Location = new System.Drawing.Point(58, 77);
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.Size = new System.Drawing.Size(158, 22);
            this.nombrecompleto.TabIndex = 95;
            this.nombrecompleto.Text = "Nombre Completo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(62, 309);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(250, 25);
            this.txtCorreo.TabIndex = 115;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(355, 309);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 25);
            this.txtUser.TabIndex = 116;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(226, 361);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 33);
            this.btnGuardar.TabIndex = 117;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(389, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 33);
            this.btnCancelar.TabIndex = 118;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // frmAdministrarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(610, 548);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.nombrecompleto);
            this.Controls.Add(this.btnVerCalendario);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditarDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdministrarMedico";
            this.Text = "frmAdministrarMedico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditarDatos;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Button btnVerCalendario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label nombrecompleto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
﻿namespace LP2Clinica
{
    partial class PrincipalCliente
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
            this.Menú = new System.Windows.Forms.Panel();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.lblCambiarPassword = new System.Windows.Forms.Label();
            this.btnBuscarMedico = new System.Windows.Forms.Button();
            this.btnModificarCuenta = new System.Windows.Forms.Button();
            this.btnReservarCita = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChats = new System.Windows.Forms.Button();
            this.Menú.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menú
            // 
            this.Menú.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.Menú.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Menú.Controls.Add(this.btnChats);
            this.Menú.Controls.Add(this.btnCalificar);
            this.Menú.Controls.Add(this.btnCerrarSesion);
            this.Menú.Controls.Add(this.btnVerPerfil);
            this.Menú.Controls.Add(this.lblCambiarPassword);
            this.Menú.Controls.Add(this.pictureBox3);
            this.Menú.Controls.Add(this.btnBuscarMedico);
            this.Menú.Controls.Add(this.pictureBox2);
            this.Menú.Controls.Add(this.btnModificarCuenta);
            this.Menú.Controls.Add(this.pictureBox1);
            this.Menú.Controls.Add(this.btnReservarCita);
            this.Menú.Location = new System.Drawing.Point(2, 2);
            this.Menú.Name = "Menú";
            this.Menú.Size = new System.Drawing.Size(329, 653);
            this.Menú.TabIndex = 0;
            // 
            // btnCalificar
            // 
            this.btnCalificar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCalificar.Location = new System.Drawing.Point(33, 437);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(267, 63);
            this.btnCalificar.TabIndex = 23;
            this.btnCalificar.Text = "Calificar atencion";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCerrarSesion.Location = new System.Drawing.Point(143, 159);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(140, 31);
            this.btnCerrarSesion.TabIndex = 22;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVerPerfil.Location = new System.Drawing.Point(143, 122);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(140, 31);
            this.btnVerPerfil.TabIndex = 21;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // lblCambiarPassword
            // 
            this.lblCambiarPassword.AutoSize = true;
            this.lblCambiarPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCambiarPassword.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblCambiarPassword.Location = new System.Drawing.Point(146, 97);
            this.lblCambiarPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambiarPassword.Name = "lblCambiarPassword";
            this.lblCambiarPassword.Size = new System.Drawing.Size(107, 22);
            this.lblCambiarPassword.TabIndex = 20;
            this.lblCambiarPassword.Text = "Bienvenid@";
            // 
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscarMedico.ImageKey = "(ninguno)";
            this.btnBuscarMedico.Location = new System.Drawing.Point(33, 299);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(267, 63);
            this.btnBuscarMedico.TabIndex = 6;
            this.btnBuscarMedico.Text = "Buscar Medico";
            this.btnBuscarMedico.UseVisualStyleBackColor = false;
            this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscarMedico_Click);
            // 
            // btnModificarCuenta
            // 
            this.btnModificarCuenta.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModificarCuenta.Location = new System.Drawing.Point(33, 368);
            this.btnModificarCuenta.Name = "btnModificarCuenta";
            this.btnModificarCuenta.Size = new System.Drawing.Size(267, 63);
            this.btnModificarCuenta.TabIndex = 4;
            this.btnModificarCuenta.Text = "Modificar datos";
            this.btnModificarCuenta.UseVisualStyleBackColor = false;
            this.btnModificarCuenta.Click += new System.EventHandler(this.btnModificarCuenta_Click);
            // 
            // btnReservarCita
            // 
            this.btnReservarCita.BackColor = System.Drawing.Color.PowderBlue;
            this.btnReservarCita.Location = new System.Drawing.Point(33, 230);
            this.btnReservarCita.Name = "btnReservarCita";
            this.btnReservarCita.Size = new System.Drawing.Size(267, 63);
            this.btnReservarCita.TabIndex = 1;
            this.btnReservarCita.Text = "Reservar cita";
            this.btnReservarCita.UseVisualStyleBackColor = false;
            this.btnReservarCita.Click += new System.EventHandler(this.btnReservarCita_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(330, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(815, 654);
            this.panelContenedor.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::LP2Clinica.Properties.Resources.user3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(29, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 88);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LP2Clinica.Properties.Resources.QHALI;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(49, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 42);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LP2Clinica.Properties.Resources.bone_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 309);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnChats
            // 
            this.btnChats.BackColor = System.Drawing.Color.PowderBlue;
            this.btnChats.ImageKey = "(ninguno)";
            this.btnChats.Location = new System.Drawing.Point(33, 505);
            this.btnChats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChats.Name = "btnChats";
            this.btnChats.Size = new System.Drawing.Size(267, 63);
            this.btnChats.TabIndex = 38;
            this.btnChats.Text = "Chats";
            this.btnChats.UseVisualStyleBackColor = false;
            this.btnChats.Click += new System.EventHandler(this.btnChats_Click);
            // 
            // PrincipalCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1145, 659);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.Menú);
            this.IsMdiContainer = true;
            this.Name = "PrincipalCliente";
            this.ShowIcon = false;
            this.Text = "Menú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalCliente_FormClosed);
            this.SizeChanged += new System.EventHandler(this.PrincipalCliente_SizeChanged);
            this.Menú.ResumeLayout(false);
            this.Menú.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menú;
        private System.Windows.Forms.Button btnReservarCita;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnModificarCuenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscarMedico;
        private System.Windows.Forms.Label lblCambiarPassword;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnChats;
    }
}
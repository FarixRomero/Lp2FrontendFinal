namespace LP2Clinica
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.rbMedico = new System.Windows.Forms.RadioButton();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.pRegistro = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.pRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(19, 22);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(45, 22);
            this.lblDNI.TabIndex = 21;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.LightGray;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(22, 48);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(279, 26);
            this.txtDNI.TabIndex = 22;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(19, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 22);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(19, 136);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 22);
            this.lblApellido.TabIndex = 24;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightGray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(22, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 26);
            this.txtNombre.TabIndex = 25;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.LightGray;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(22, 162);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(279, 26);
            this.txtApellido.TabIndex = 26;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(17, 265);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(139, 22);
            this.lblTipo.TabIndex = 29;
            this.lblTipo.Text = "Tipo de Usuario:";
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaciente.ForeColor = System.Drawing.Color.White;
            this.rbPaciente.Location = new System.Drawing.Point(23, 294);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(92, 26);
            this.rbPaciente.TabIndex = 30;
            this.rbPaciente.TabStop = true;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = true;
            // 
            // rbMedico
            // 
            this.rbMedico.AutoSize = true;
            this.rbMedico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedico.ForeColor = System.Drawing.Color.White;
            this.rbMedico.Location = new System.Drawing.Point(23, 319);
            this.rbMedico.Name = "rbMedico";
            this.rbMedico.Size = new System.Drawing.Size(84, 26);
            this.rbMedico.TabIndex = 31;
            this.rbMedico.TabStop = true;
            this.rbMedico.Text = "Medico";
            this.rbMedico.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdministrador.ForeColor = System.Drawing.Color.White;
            this.rbAdministrador.Location = new System.Drawing.Point(22, 346);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(131, 26);
            this.rbAdministrador.TabIndex = 32;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // pRegistro
            // 
            this.pRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.pRegistro.Controls.Add(this.lblFecha);
            this.pRegistro.Controls.Add(this.dtpFechaNacimiento);
            this.pRegistro.Controls.Add(this.rbAdministrador);
            this.pRegistro.Controls.Add(this.rbMedico);
            this.pRegistro.Controls.Add(this.rbPaciente);
            this.pRegistro.Controls.Add(this.lblTipo);
            this.pRegistro.Controls.Add(this.txtApellido);
            this.pRegistro.Controls.Add(this.txtNombre);
            this.pRegistro.Controls.Add(this.lblApellido);
            this.pRegistro.Controls.Add(this.lblNombre);
            this.pRegistro.Controls.Add(this.txtDNI);
            this.pRegistro.Controls.Add(this.lblDNI);
            this.pRegistro.Location = new System.Drawing.Point(34, 93);
            this.pRegistro.Name = "pRegistro";
            this.pRegistro.Size = new System.Drawing.Size(331, 404);
            this.pRegistro.TabIndex = 16;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(411, 308);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(158, 33);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // bnCancelar
            // 
            this.bnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bnCancelar.FlatAppearance.BorderSize = 0;
            this.bnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancelar.ForeColor = System.Drawing.Color.White;
            this.bnCancelar.Location = new System.Drawing.Point(411, 353);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(158, 33);
            this.bnCancelar.TabIndex = 25;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = false;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubirFoto.BackgroundImage")));
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSubirFoto.Location = new System.Drawing.Point(533, 246);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(36, 34);
            this.btnSubirFoto.TabIndex = 27;
            this.btnSubirFoto.UseVisualStyleBackColor = false;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.ErrorImage")));
            this.pbFoto.Image = global::LP2Clinica.Properties.Resources.user3;
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(411, 115);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(158, 174);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 26;
            this.pbFoto.TabStop = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(23, 223);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(278, 25);
            this.dtpFechaNacimiento.TabIndex = 33;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(24, 198);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(180, 22);
            this.lblFecha.TabIndex = 34;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 548);
            this.Controls.Add(this.btnSubirFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.bnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pRegistro);
            this.DoubleBuffered = true;
            this.Name = "frmRegistro";
            this.Text = "Registrar Cuenta Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistro_FormClosing);
            this.pRegistro.ResumeLayout(false);
            this.pRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.RadioButton rbMedico;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.Panel pRegistro;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}
namespace LP2Clinica
{
    partial class frmOpcionesMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcionesMedico));
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.pModificar = new System.Windows.Forms.Panel();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.nombrecompleto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.pModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrarCita.Enabled = false;
            this.btnRegistrarCita.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistrarCita.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCita.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCita.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCita.Location = new System.Drawing.Point(276, 452);
            this.btnRegistrarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(280, 41);
            this.btnRegistrarCita.TabIndex = 81;
            this.btnRegistrarCita.TabStop = false;
            this.btnRegistrarCita.Text = "Registrar Cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = false;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // pModificar
            // 
            this.pModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.pModificar.Controls.Add(this.lblEspecialidad);
            this.pModificar.Controls.Add(this.label2);
            this.pModificar.Controls.Add(this.lblDNI);
            this.pModificar.Controls.Add(this.lblNombreCompleto);
            this.pModificar.Controls.Add(this.dni);
            this.pModificar.Controls.Add(this.nombrecompleto);
            this.pModificar.Location = new System.Drawing.Point(182, 180);
            this.pModificar.Margin = new System.Windows.Forms.Padding(4);
            this.pModificar.Name = "pModificar";
            this.pModificar.Size = new System.Drawing.Size(469, 255);
            this.pModificar.TabIndex = 79;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblEspecialidad.Location = new System.Drawing.Point(64, 199);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(163, 28);
            this.lblEspecialidad.TabIndex = 35;
            this.lblEspecialidad.Text = "_Especialidad_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Especialidad:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblDNI.Location = new System.Drawing.Point(64, 114);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(74, 28);
            this.lblDNI.TabIndex = 33;
            this.lblDNI.Text = "_DNI_";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblNombreCompleto.Location = new System.Drawing.Point(64, 42);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(220, 28);
            this.lblNombreCompleto.TabIndex = 32;
            this.lblNombreCompleto.Text = "_Nombre Completo_";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.BackColor = System.Drawing.Color.Transparent;
            this.dni.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.ForeColor = System.Drawing.Color.White;
            this.dni.Location = new System.Drawing.Point(64, 86);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(56, 28);
            this.dni.TabIndex = 23;
            this.dni.Text = "DNI:";
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.AutoSize = true;
            this.nombrecompleto.BackColor = System.Drawing.Color.Transparent;
            this.nombrecompleto.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrecompleto.ForeColor = System.Drawing.Color.White;
            this.nombrecompleto.Location = new System.Drawing.Point(64, 14);
            this.nombrecompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.Size = new System.Drawing.Size(202, 28);
            this.nombrecompleto.TabIndex = 21;
            this.nombrecompleto.Text = "Nombre Completo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(276, 513);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(280, 41);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.ErrorImage")));
            this.pbFoto.Image = global::LP2Clinica.Properties.Resources.user3;
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(313, 4);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(178, 168);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 83;
            this.pbFoto.TabStop = false;
            // 
            // frmOpcionesMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 606);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.pModificar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpcionesMedico";
            this.Text = "frmOpcionesMedico";
            this.pModificar.ResumeLayout(false);
            this.pModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Panel pModificar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label nombrecompleto;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}
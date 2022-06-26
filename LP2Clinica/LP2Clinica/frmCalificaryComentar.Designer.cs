namespace LP2Clinica
{
    partial class frmCalificaryComentar
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
            this.lblCodigoCita = new System.Windows.Forms.Label();
            this.txtCodigoCita = new System.Windows.Forms.TextBox();
            this.gbDatosMedico = new System.Windows.Forms.GroupBox();
            this.lblEspecialidadResultado = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblNombreCompletoResultado = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.rbPuntaje1 = new System.Windows.Forms.RadioButton();
            this.rbPuntaje2 = new System.Windows.Forms.RadioButton();
            this.rbPuntaje3 = new System.Windows.Forms.RadioButton();
            this.rbPuntaje4 = new System.Windows.Forms.RadioButton();
            this.rbPuntaje5 = new System.Windows.Forms.RadioButton();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbDatosMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 30);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 48);
            this.lblTitulo.TabIndex = 97;
            this.lblTitulo.Text = "NOS IMPORTA TU OPINIÓN";
            // 
            // lblCodigoCita
            // 
            this.lblCodigoCita.AutoSize = true;
            this.lblCodigoCita.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoCita.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCita.ForeColor = System.Drawing.Color.White;
            this.lblCodigoCita.Location = new System.Drawing.Point(44, 94);
            this.lblCodigoCita.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoCita.Name = "lblCodigoCita";
            this.lblCodigoCita.Size = new System.Drawing.Size(313, 28);
            this.lblCodigoCita.TabIndex = 100;
            this.lblCodigoCita.Text = "Ingresa el código de tu medico:";
            // 
            // txtCodigoCita
            // 
            this.txtCodigoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCita.Location = new System.Drawing.Point(365, 94);
            this.txtCodigoCita.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCita.Name = "txtCodigoCita";
            this.txtCodigoCita.Size = new System.Drawing.Size(250, 30);
            this.txtCodigoCita.TabIndex = 101;
            // 
            // gbDatosMedico
            // 
            this.gbDatosMedico.BackColor = System.Drawing.Color.Transparent;
            this.gbDatosMedico.Controls.Add(this.lblEspecialidadResultado);
            this.gbDatosMedico.Controls.Add(this.lblEspecialidad);
            this.gbDatosMedico.Controls.Add(this.lblNombreCompletoResultado);
            this.gbDatosMedico.Controls.Add(this.lblNombreCompleto);
            this.gbDatosMedico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMedico.ForeColor = System.Drawing.Color.White;
            this.gbDatosMedico.Location = new System.Drawing.Point(49, 132);
            this.gbDatosMedico.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosMedico.Name = "gbDatosMedico";
            this.gbDatosMedico.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosMedico.Size = new System.Drawing.Size(712, 148);
            this.gbDatosMedico.TabIndex = 102;
            this.gbDatosMedico.TabStop = false;
            this.gbDatosMedico.Text = "Datos del Médico";
            // 
            // lblEspecialidadResultado
            // 
            this.lblEspecialidadResultado.AutoSize = true;
            this.lblEspecialidadResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidadResultado.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblEspecialidadResultado.Location = new System.Drawing.Point(280, 96);
            this.lblEspecialidadResultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEspecialidadResultado.Name = "lblEspecialidadResultado";
            this.lblEspecialidadResultado.Size = new System.Drawing.Size(256, 28);
            this.lblEspecialidadResultado.TabIndex = 106;
            this.lblEspecialidadResultado.Text = "_Especialidad Resultado_";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.Transparent;
            this.lblEspecialidad.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.Color.White;
            this.lblEspecialidad.Location = new System.Drawing.Point(9, 94);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(161, 31);
            this.lblEspecialidad.TabIndex = 105;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblNombreCompletoResultado
            // 
            this.lblNombreCompletoResultado.AutoSize = true;
            this.lblNombreCompletoResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCompletoResultado.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompletoResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblNombreCompletoResultado.Location = new System.Drawing.Point(280, 45);
            this.lblNombreCompletoResultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreCompletoResultado.Name = "lblNombreCompletoResultado";
            this.lblNombreCompletoResultado.Size = new System.Drawing.Size(212, 28);
            this.lblNombreCompletoResultado.TabIndex = 104;
            this.lblNombreCompletoResultado.Text = "_Nombre Completo_";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNombreCompleto.Location = new System.Drawing.Point(9, 42);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(223, 31);
            this.lblNombreCompleto.TabIndex = 103;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblCalificacion.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.ForeColor = System.Drawing.Color.White;
            this.lblCalificacion.Location = new System.Drawing.Point(44, 309);
            this.lblCalificacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(461, 28);
            this.lblCalificacion.TabIndex = 103;
            this.lblCalificacion.Text = "Califica la atención del medico durante la cita:";
            // 
            // rbPuntaje1
            // 
            this.rbPuntaje1.AutoSize = true;
            this.rbPuntaje1.BackColor = System.Drawing.Color.Transparent;
            this.rbPuntaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPuntaje1.ForeColor = System.Drawing.Color.White;
            this.rbPuntaje1.Location = new System.Drawing.Point(49, 341);
            this.rbPuntaje1.Margin = new System.Windows.Forms.Padding(4);
            this.rbPuntaje1.Name = "rbPuntaje1";
            this.rbPuntaje1.Size = new System.Drawing.Size(45, 29);
            this.rbPuntaje1.TabIndex = 104;
            this.rbPuntaje1.TabStop = true;
            this.rbPuntaje1.Text = "1";
            this.rbPuntaje1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPuntaje1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rbPuntaje1.UseVisualStyleBackColor = false;
            // 
            // rbPuntaje2
            // 
            this.rbPuntaje2.AutoSize = true;
            this.rbPuntaje2.BackColor = System.Drawing.Color.Transparent;
            this.rbPuntaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPuntaje2.ForeColor = System.Drawing.Color.White;
            this.rbPuntaje2.Location = new System.Drawing.Point(117, 341);
            this.rbPuntaje2.Margin = new System.Windows.Forms.Padding(4);
            this.rbPuntaje2.Name = "rbPuntaje2";
            this.rbPuntaje2.Size = new System.Drawing.Size(45, 29);
            this.rbPuntaje2.TabIndex = 105;
            this.rbPuntaje2.TabStop = true;
            this.rbPuntaje2.Text = "2";
            this.rbPuntaje2.UseVisualStyleBackColor = false;
            // 
            // rbPuntaje3
            // 
            this.rbPuntaje3.AutoSize = true;
            this.rbPuntaje3.BackColor = System.Drawing.Color.Transparent;
            this.rbPuntaje3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPuntaje3.ForeColor = System.Drawing.Color.White;
            this.rbPuntaje3.Location = new System.Drawing.Point(190, 341);
            this.rbPuntaje3.Margin = new System.Windows.Forms.Padding(4);
            this.rbPuntaje3.Name = "rbPuntaje3";
            this.rbPuntaje3.Size = new System.Drawing.Size(45, 29);
            this.rbPuntaje3.TabIndex = 106;
            this.rbPuntaje3.TabStop = true;
            this.rbPuntaje3.Text = "3";
            this.rbPuntaje3.UseVisualStyleBackColor = false;
            // 
            // rbPuntaje4
            // 
            this.rbPuntaje4.AutoSize = true;
            this.rbPuntaje4.BackColor = System.Drawing.Color.Transparent;
            this.rbPuntaje4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPuntaje4.ForeColor = System.Drawing.Color.White;
            this.rbPuntaje4.Location = new System.Drawing.Point(265, 341);
            this.rbPuntaje4.Margin = new System.Windows.Forms.Padding(4);
            this.rbPuntaje4.Name = "rbPuntaje4";
            this.rbPuntaje4.Size = new System.Drawing.Size(45, 29);
            this.rbPuntaje4.TabIndex = 107;
            this.rbPuntaje4.TabStop = true;
            this.rbPuntaje4.Text = "4";
            this.rbPuntaje4.UseVisualStyleBackColor = false;
            // 
            // rbPuntaje5
            // 
            this.rbPuntaje5.AutoSize = true;
            this.rbPuntaje5.BackColor = System.Drawing.Color.Transparent;
            this.rbPuntaje5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPuntaje5.ForeColor = System.Drawing.Color.White;
            this.rbPuntaje5.Location = new System.Drawing.Point(334, 341);
            this.rbPuntaje5.Margin = new System.Windows.Forms.Padding(4);
            this.rbPuntaje5.Name = "rbPuntaje5";
            this.rbPuntaje5.Size = new System.Drawing.Size(45, 29);
            this.rbPuntaje5.TabIndex = 108;
            this.rbPuntaje5.TabStop = true;
            this.rbPuntaje5.Text = "5";
            this.rbPuntaje5.UseVisualStyleBackColor = false;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.Transparent;
            this.lblComentario.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.Color.White;
            this.lblComentario.Location = new System.Drawing.Point(44, 391);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(230, 28);
            this.lblComentario.TabIndex = 109;
            this.lblComentario.Text = "Dejanos tu comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.PowderBlue;
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(49, 423);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(715, 37);
            this.txtComentario.TabIndex = 110;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(553, 532);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(211, 41);
            this.btnRegistrar.TabIndex = 112;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(49, 532);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 41);
            this.btnCancelar.TabIndex = 113;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(654, 92);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 34);
            this.btnBuscar.TabIndex = 114;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmCalificaryComentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_3;
            this.ClientSize = new System.Drawing.Size(793, 606);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.rbPuntaje5);
            this.Controls.Add(this.rbPuntaje4);
            this.Controls.Add(this.rbPuntaje3);
            this.Controls.Add(this.rbPuntaje2);
            this.Controls.Add(this.rbPuntaje1);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.gbDatosMedico);
            this.Controls.Add(this.txtCodigoCita);
            this.Controls.Add(this.lblCodigoCita);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalificaryComentar";
            this.Text = "Registro de comentario y calificación ";
            this.gbDatosMedico.ResumeLayout(false);
            this.gbDatosMedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoCita;
        private System.Windows.Forms.TextBox txtCodigoCita;
        private System.Windows.Forms.GroupBox gbDatosMedico;
        private System.Windows.Forms.Label lblEspecialidadResultado;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblNombreCompletoResultado;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.RadioButton rbPuntaje1;
        private System.Windows.Forms.RadioButton rbPuntaje2;
        private System.Windows.Forms.RadioButton rbPuntaje3;
        private System.Windows.Forms.RadioButton rbPuntaje4;
        private System.Windows.Forms.RadioButton rbPuntaje5;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
    }
}
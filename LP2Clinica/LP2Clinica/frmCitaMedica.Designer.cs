namespace LP2Clinica
{
    partial class frmCitaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitaMedica));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.nombrecompleto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreDoctor = new System.Windows.Forms.Label();
            this.lblFechaProgramada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoCita = new System.Windows.Forms.ComboBox();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LP2Clinica.Properties.Resources.profilepicture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::LP2Clinica.Properties.Resources.Madurez_emocional_7;
            this.pictureBox1.Location = new System.Drawing.Point(390, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(91, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 119);
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblNombreCliente.Location = new System.Drawing.Point(68, 330);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(220, 28);
            this.lblNombreCliente.TabIndex = 94;
            this.lblNombreCliente.Text = "_Nombre Completo_";
            // 
            // nombrecompleto
            // 
            this.nombrecompleto.AutoSize = true;
            this.nombrecompleto.BackColor = System.Drawing.Color.Transparent;
            this.nombrecompleto.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrecompleto.ForeColor = System.Drawing.Color.White;
            this.nombrecompleto.Location = new System.Drawing.Point(123, 302);
            this.nombrecompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.Size = new System.Drawing.Size(87, 28);
            this.nombrecompleto.TabIndex = 93;
            this.nombrecompleto.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 95;
            this.label1.Text = "Doctor:";
            // 
            // lblNombreDoctor
            // 
            this.lblNombreDoctor.AutoSize = true;
            this.lblNombreDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDoctor.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblNombreDoctor.Location = new System.Drawing.Point(354, 330);
            this.lblNombreDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDoctor.Name = "lblNombreDoctor";
            this.lblNombreDoctor.Size = new System.Drawing.Size(220, 28);
            this.lblNombreDoctor.TabIndex = 96;
            this.lblNombreDoctor.Text = "_Nombre Completo_";
            // 
            // lblFechaProgramada
            // 
            this.lblFechaProgramada.AutoSize = true;
            this.lblFechaProgramada.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaProgramada.Font = new System.Drawing.Font("Tw Cen MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaProgramada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.lblFechaProgramada.Location = new System.Drawing.Point(172, 68);
            this.lblFechaProgramada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaProgramada.Name = "lblFechaProgramada";
            this.lblFechaProgramada.Size = new System.Drawing.Size(258, 43);
            this.lblFechaProgramada.TabIndex = 98;
            this.lblFechaProgramada.Text = "_día/mes/año_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 28);
            this.label3.TabIndex = 97;
            this.label3.Text = "Cita Programada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 452);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 101;
            this.label2.Text = "Estado de cita:";
            // 
            // cbEstadoCita
            // 
            this.cbEstadoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCita.FormattingEnabled = true;
            this.cbEstadoCita.Location = new System.Drawing.Point(197, 483);
            this.cbEstadoCita.Name = "cbEstadoCita";
            this.cbEstadoCita.Size = new System.Drawing.Size(259, 33);
            this.cbEstadoCita.TabIndex = 102;
            // 
            // bnCancelar
            // 
            this.bnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bnCancelar.FlatAppearance.BorderSize = 0;
            this.bnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancelar.ForeColor = System.Drawing.Color.White;
            this.bnCancelar.Location = new System.Drawing.Point(334, 555);
            this.bnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(191, 41);
            this.bnCancelar.TabIndex = 111;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = false;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(121, 555);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(191, 41);
            this.btnConfirmar.TabIndex = 110;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmCitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 665);
            this.Controls.Add(this.bnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbEstadoCita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaProgramada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.nombrecompleto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "frmCitaMedica";
            this.Text = "CitaMedica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label nombrecompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreDoctor;
        private System.Windows.Forms.Label lblFechaProgramada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstadoCita;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
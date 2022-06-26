namespace LP2Clinica
{
    partial class NuevoRegistroDeterminarTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoRegistroDeterminarTipo));
            this.label3 = new System.Windows.Forms.Label();
            this.rbMedico = new System.Windows.Forms.RadioButton();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 56);
            this.label3.TabIndex = 98;
            this.label3.Text = "¿A que tipo de usuario\r\n deseas registrar?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbMedico
            // 
            this.rbMedico.AutoSize = true;
            this.rbMedico.BackColor = System.Drawing.Color.Transparent;
            this.rbMedico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedico.ForeColor = System.Drawing.Color.White;
            this.rbMedico.Location = new System.Drawing.Point(190, 204);
            this.rbMedico.Margin = new System.Windows.Forms.Padding(4);
            this.rbMedico.Name = "rbMedico";
            this.rbMedico.Size = new System.Drawing.Size(103, 32);
            this.rbMedico.TabIndex = 100;
            this.rbMedico.TabStop = true;
            this.rbMedico.Text = "Medico";
            this.rbMedico.UseVisualStyleBackColor = false;
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.BackColor = System.Drawing.Color.Transparent;
            this.rbPaciente.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaciente.ForeColor = System.Drawing.Color.White;
            this.rbPaciente.Location = new System.Drawing.Point(190, 164);
            this.rbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(114, 32);
            this.rbPaciente.TabIndex = 99;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = false;
            // 
            // bnCancelar
            // 
            this.bnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bnCancelar.FlatAppearance.BorderSize = 0;
            this.bnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancelar.ForeColor = System.Drawing.Color.White;
            this.bnCancelar.Location = new System.Drawing.Point(37, 296);
            this.bnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(211, 41);
            this.bnCancelar.TabIndex = 102;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = false;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(270, 296);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(211, 41);
            this.btnSiguiente.TabIndex = 101;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // NuevoRegistroDeterminarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 386);
            this.Controls.Add(this.bnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.rbMedico);
            this.Controls.Add(this.rbPaciente);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "NuevoRegistroDeterminarTipo";
            this.Text = "NuevoRegistroDeterminarTipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMedico;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button btnSiguiente;
    }
}
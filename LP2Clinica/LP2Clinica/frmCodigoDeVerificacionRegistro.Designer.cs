namespace LP2Clinica
{
    partial class frmCodigoDeVerificacionRegistro
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
            this.bnCancelar = new System.Windows.Forms.Button();
            this.bnIngresar = new System.Windows.Forms.Button();
            this.pRegistro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoVerificacion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnCancelar
            // 
            this.bnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bnCancelar.FlatAppearance.BorderSize = 0;
            this.bnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancelar.ForeColor = System.Drawing.Color.White;
            this.bnCancelar.Location = new System.Drawing.Point(230, 445);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(158, 33);
            this.bnCancelar.TabIndex = 26;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = false;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // bnIngresar
            // 
            this.bnIngresar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bnIngresar.FlatAppearance.BorderSize = 0;
            this.bnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnIngresar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnIngresar.ForeColor = System.Drawing.Color.White;
            this.bnIngresar.Location = new System.Drawing.Point(230, 391);
            this.bnIngresar.Name = "bnIngresar";
            this.bnIngresar.Size = new System.Drawing.Size(158, 33);
            this.bnIngresar.TabIndex = 27;
            this.bnIngresar.Text = "Ingresar";
            this.bnIngresar.UseVisualStyleBackColor = false;
            this.bnIngresar.Click += new System.EventHandler(this.bnIngresar_Click);
            // 
            // pRegistro
            // 
            this.pRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.pRegistro.Controls.Add(this.label1);
            this.pRegistro.Controls.Add(this.txtCodigoVerificacion);
            this.pRegistro.Controls.Add(this.lblCodigo);
            this.pRegistro.Location = new System.Drawing.Point(147, 155);
            this.pRegistro.Name = "pRegistro";
            this.pRegistro.Size = new System.Drawing.Size(331, 210);
            this.pRegistro.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 88);
            this.label1.TabIndex = 23;
            this.label1.Text = "Debe ingresar su codigo de \r\nseguridad asociado,\r\npara verificar que es medico\r\n " +
    "o administrador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoVerificacion
            // 
            this.txtCodigoVerificacion.BackColor = System.Drawing.Color.LightGray;
            this.txtCodigoVerificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVerificacion.Location = new System.Drawing.Point(22, 161);
            this.txtCodigoVerificacion.Name = "txtCodigoVerificacion";
            this.txtCodigoVerificacion.Size = new System.Drawing.Size(279, 26);
            this.txtCodigoVerificacion.TabIndex = 22;
            this.txtCodigoVerificacion.UseSystemPasswordChar = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(19, 135);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(194, 22);
            this.lblCodigo.TabIndex = 21;
            this.lblCodigo.Text = "Codigo de Verificación:";
            // 
            // frmCodigoDeVerificacionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 570);
            this.Controls.Add(this.pRegistro);
            this.Controls.Add(this.bnIngresar);
            this.Controls.Add(this.bnCancelar);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCodigoDeVerificacionRegistro";
            this.Text = "frmCodigoDeVerificacionRegistro";
            this.pRegistro.ResumeLayout(false);
            this.pRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button bnIngresar;
        private System.Windows.Forms.Panel pRegistro;
        private System.Windows.Forms.TextBox txtCodigoVerificacion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
    }
}
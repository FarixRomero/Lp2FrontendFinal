namespace LP2Clinica
{
    partial class frmCodigoContraseña
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
            this.btEnviarCodigo = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCodigoverificacion = new System.Windows.Forms.TextBox();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btEnviarCodigo
            // 
            this.btEnviarCodigo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btEnviarCodigo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btEnviarCodigo.FlatAppearance.BorderSize = 0;
            this.btEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviarCodigo.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviarCodigo.ForeColor = System.Drawing.Color.White;
            this.btEnviarCodigo.Location = new System.Drawing.Point(231, 158);
            this.btEnviarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btEnviarCodigo.Name = "btEnviarCodigo";
            this.btEnviarCodigo.Size = new System.Drawing.Size(167, 41);
            this.btEnviarCodigo.TabIndex = 36;
            this.btEnviarCodigo.Text = "Enviar Código";
            this.btEnviarCodigo.UseVisualStyleBackColor = false;
            this.btEnviarCodigo.Click += new System.EventHandler(this.btEnviarCodigo_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(63, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 30);
            this.txtEmail.TabIndex = 35;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(59, 88);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 28);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email:";
            // 
            // txtCodigoverificacion
            // 
            this.txtCodigoverificacion.BackColor = System.Drawing.Color.LightGray;
            this.txtCodigoverificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoverificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoverificacion.Location = new System.Drawing.Point(64, 281);
            this.txtCodigoverificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoverificacion.Name = "txtCodigoverificacion";
            this.txtCodigoverificacion.Size = new System.Drawing.Size(334, 30);
            this.txtCodigoverificacion.TabIndex = 33;
            this.txtCodigoverificacion.UseSystemPasswordChar = true;
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaNueva.ForeColor = System.Drawing.Color.White;
            this.lblContraseñaNueva.Location = new System.Drawing.Point(58, 249);
            this.lblContraseñaNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(239, 28);
            this.lblContraseñaNueva.TabIndex = 32;
            this.lblContraseñaNueva.Text = "Codigo de verificación";
            // 
            // frmCodigoContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(457, 399);
            this.Controls.Add(this.btEnviarCodigo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCodigoverificacion);
            this.Controls.Add(this.lblContraseñaNueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmCodigoContraseña";
            this.Text = "frmCodigoContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnviarCodigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCodigoverificacion;
        private System.Windows.Forms.Label lblContraseñaNueva;
    }
}
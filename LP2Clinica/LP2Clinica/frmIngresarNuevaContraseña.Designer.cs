namespace LP2Clinica
{
    partial class frmIngresarNuevaContraseña
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
            this.pContraseña = new System.Windows.Forms.Panel();
            this.txtContraseñaConfirmada = new System.Windows.Forms.TextBox();
            this.lblContraseñaConfirmada = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.pContraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContraseña
            // 
            this.pContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.pContraseña.Controls.Add(this.txtContraseñaConfirmada);
            this.pContraseña.Controls.Add(this.lblContraseñaConfirmada);
            this.pContraseña.Controls.Add(this.txtContraseñaNueva);
            this.pContraseña.Controls.Add(this.lblContraseñaNueva);
            this.pContraseña.Location = new System.Drawing.Point(-2, 0);
            this.pContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.pContraseña.Name = "pContraseña";
            this.pContraseña.Size = new System.Drawing.Size(457, 399);
            this.pContraseña.TabIndex = 18;
            // 
            // txtContraseñaConfirmada
            // 
            this.txtContraseñaConfirmada.BackColor = System.Drawing.Color.LightGray;
            this.txtContraseñaConfirmada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseñaConfirmada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaConfirmada.Location = new System.Drawing.Point(51, 275);
            this.txtContraseñaConfirmada.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseñaConfirmada.Name = "txtContraseñaConfirmada";
            this.txtContraseñaConfirmada.Size = new System.Drawing.Size(334, 30);
            this.txtContraseñaConfirmada.TabIndex = 25;
            this.txtContraseñaConfirmada.UseSystemPasswordChar = true;
            // 
            // lblContraseñaConfirmada
            // 
            this.lblContraseñaConfirmada.AutoSize = true;
            this.lblContraseñaConfirmada.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseñaConfirmada.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaConfirmada.ForeColor = System.Drawing.Color.White;
            this.lblContraseñaConfirmada.Location = new System.Drawing.Point(46, 229);
            this.lblContraseñaConfirmada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaConfirmada.Name = "lblContraseñaConfirmada";
            this.lblContraseñaConfirmada.Size = new System.Drawing.Size(307, 28);
            this.lblContraseñaConfirmada.TabIndex = 23;
            this.lblContraseñaConfirmada.Text = "Confirmar nueva contraseña:";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.BackColor = System.Drawing.Color.LightGray;
            this.txtContraseñaNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNueva.Location = new System.Drawing.Point(51, 113);
            this.txtContraseñaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(335, 30);
            this.txtContraseñaNueva.TabIndex = 22;
            this.txtContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaNueva.ForeColor = System.Drawing.Color.White;
            this.lblContraseñaNueva.Location = new System.Drawing.Point(46, 81);
            this.lblContraseñaNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(207, 28);
            this.lblContraseñaNueva.TabIndex = 21;
            this.lblContraseñaNueva.Text = "Contraseña Nueva:";
            // 
            // frmIngresarNuevaContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(114)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 401);
            this.Controls.Add(this.pContraseña);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresarNuevaContraseña";
            this.Text = "frmIngresarNuevaContraseña";
            this.pContraseña.ResumeLayout(false);
            this.pContraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContraseña;
        private System.Windows.Forms.TextBox txtContraseñaConfirmada;
        private System.Windows.Forms.Label lblContraseñaConfirmada;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.Label lblContraseñaNueva;
    }
}
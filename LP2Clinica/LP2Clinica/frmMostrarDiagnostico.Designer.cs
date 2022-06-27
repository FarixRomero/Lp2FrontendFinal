namespace LP2Clinica
{
    partial class frmMostrarDiagnostico
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
            this.lblResultadoDiagnostico = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pbDiagnostico = new System.Windows.Forms.PictureBox();
            this.lblObservacionDiagnostico = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoDiagnostico = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtgRecetaMedicaXDiagnostico = new System.Windows.Forms.DataGridView();
            this.lblRecetaMedica = new System.Windows.Forms.Label();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiagnostico)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecetaMedicaXDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(425, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 51);
            this.lblTitulo.TabIndex = 79;
            this.lblTitulo.Text = "Diagnóstico";
            // 
            // lblResultadoDiagnostico
            // 
            this.lblResultadoDiagnostico.AutoSize = true;
            this.lblResultadoDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoDiagnostico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDiagnostico.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblResultadoDiagnostico.Location = new System.Drawing.Point(24, 126);
            this.lblResultadoDiagnostico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultadoDiagnostico.Name = "lblResultadoDiagnostico";
            this.lblResultadoDiagnostico.Size = new System.Drawing.Size(260, 28);
            this.lblResultadoDiagnostico.TabIndex = 32;
            this.lblResultadoDiagnostico.Text = "_Resultado Diagnostico_";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(24, 98);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(118, 28);
            this.lblResultado.TabIndex = 21;
            this.lblResultado.Text = "Resultado:";
            // 
            // pbDiagnostico
            // 
            this.pbDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.pbDiagnostico.Image = global::LP2Clinica.Properties.Resources._0bdfc3016d176e14e58e824d5f0fa027_removebg_preview;
            this.pbDiagnostico.Location = new System.Drawing.Point(16, 78);
            this.pbDiagnostico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDiagnostico.Name = "pbDiagnostico";
            this.pbDiagnostico.Size = new System.Drawing.Size(249, 242);
            this.pbDiagnostico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiagnostico.TabIndex = 80;
            this.pbDiagnostico.TabStop = false;
            // 
            // lblObservacionDiagnostico
            // 
            this.lblObservacionDiagnostico.AutoSize = true;
            this.lblObservacionDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacionDiagnostico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionDiagnostico.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblObservacionDiagnostico.Location = new System.Drawing.Point(24, 202);
            this.lblObservacionDiagnostico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacionDiagnostico.Name = "lblObservacionDiagnostico";
            this.lblObservacionDiagnostico.Size = new System.Drawing.Size(271, 28);
            this.lblObservacionDiagnostico.TabIndex = 34;
            this.lblObservacionDiagnostico.Text = "_Resultado Observación_";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacion.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.ForeColor = System.Drawing.Color.White;
            this.lblObservacion.Location = new System.Drawing.Point(24, 175);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(141, 28);
            this.lblObservacion.TabIndex = 33;
            this.lblObservacion.Text = "Observación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigoDiagnostico);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.lblObservacionDiagnostico);
            this.groupBox1.Controls.Add(this.lblResultadoDiagnostico);
            this.groupBox1.Controls.Add(this.lblObservacion);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(293, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(463, 255);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Diagnóstico";
            // 
            // lblCodigoDiagnostico
            // 
            this.lblCodigoDiagnostico.AutoSize = true;
            this.lblCodigoDiagnostico.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoDiagnostico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDiagnostico.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCodigoDiagnostico.Location = new System.Drawing.Point(24, 53);
            this.lblCodigoDiagnostico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDiagnostico.Name = "lblCodigoDiagnostico";
            this.lblCodigoDiagnostico.Size = new System.Drawing.Size(232, 28);
            this.lblCodigoDiagnostico.TabIndex = 36;
            this.lblCodigoDiagnostico.Text = "_Código Diagnostico_";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(24, 26);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(251, 28);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "Código del Diagnóstico:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(16, 549);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(159, 37);
            this.btnCerrar.TabIndex = 82;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // dtgRecetaMedicaXDiagnostico
            // 
            this.dtgRecetaMedicaXDiagnostico.AllowUserToAddRows = false;
            this.dtgRecetaMedicaXDiagnostico.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dtgRecetaMedicaXDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecetaMedicaXDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCantidad});
            this.dtgRecetaMedicaXDiagnostico.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dtgRecetaMedicaXDiagnostico.Location = new System.Drawing.Point(16, 399);
            this.dtgRecetaMedicaXDiagnostico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgRecetaMedicaXDiagnostico.Name = "dtgRecetaMedicaXDiagnostico";
            this.dtgRecetaMedicaXDiagnostico.RowHeadersWidth = 51;
            this.dtgRecetaMedicaXDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecetaMedicaXDiagnostico.Size = new System.Drawing.Size(740, 128);
            this.dtgRecetaMedicaXDiagnostico.TabIndex = 94;
            this.dtgRecetaMedicaXDiagnostico.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgRecetaMedicaXDiagnostico_CellFormatting);
            // 
            // lblRecetaMedica
            // 
            this.lblRecetaMedica.AutoSize = true;
            this.lblRecetaMedica.BackColor = System.Drawing.Color.Transparent;
            this.lblRecetaMedica.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecetaMedica.ForeColor = System.Drawing.Color.White;
            this.lblRecetaMedica.Location = new System.Drawing.Point(16, 368);
            this.lblRecetaMedica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecetaMedica.Name = "lblRecetaMedica";
            this.lblRecetaMedica.Size = new System.Drawing.Size(164, 28);
            this.lblRecetaMedica.TabIndex = 37;
            this.lblRecetaMedica.Text = "Receta Médica:";
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "CODIGO";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "NOMBRE";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 200;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 125;
            // 
            // frmMostrarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(793, 606);
            this.Controls.Add(this.lblRecetaMedica);
            this.Controls.Add(this.dtgRecetaMedicaXDiagnostico);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbDiagnostico);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMostrarDiagnostico";
            this.Text = "Datos del Diagnóstico";
            ((System.ComponentModel.ISupportInitialize)(this.pbDiagnostico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecetaMedicaXDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultadoDiagnostico;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pbDiagnostico;
        private System.Windows.Forms.Label lblObservacionDiagnostico;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigoDiagnostico;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dtgRecetaMedicaXDiagnostico;
        private System.Windows.Forms.Label lblRecetaMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    }
}
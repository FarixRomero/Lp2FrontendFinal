namespace LP2Clinica
{
    partial class frmBuscarDiagnostico
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNIPaciente = new System.Windows.Forms.TextBox();
            this.lblDNIPaciente = new System.Windows.Forms.Label();
            this.dgvDiagnostico = new System.Windows.Forms.DataGridView();
            this.idDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(415, 41);
            this.lblTitulo.TabIndex = 61;
            this.lblTitulo.Text = "BUSQUEDA DE DIAGNÓSTICOS";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(414, 84);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 29);
            this.btnBuscar.TabIndex = 93;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDNIPaciente
            // 
            this.txtDNIPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIPaciente.Location = new System.Drawing.Point(19, 87);
            this.txtDNIPaciente.Name = "txtDNIPaciente";
            this.txtDNIPaciente.Size = new System.Drawing.Size(374, 26);
            this.txtDNIPaciente.TabIndex = 92;
            // 
            // lblDNIPaciente
            // 
            this.lblDNIPaciente.AutoSize = true;
            this.lblDNIPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblDNIPaciente.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIPaciente.ForeColor = System.Drawing.Color.White;
            this.lblDNIPaciente.Location = new System.Drawing.Point(15, 62);
            this.lblDNIPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIPaciente.Name = "lblDNIPaciente";
            this.lblDNIPaciente.Size = new System.Drawing.Size(218, 22);
            this.lblDNIPaciente.TabIndex = 91;
            this.lblDNIPaciente.Text = "Ingresa el DNI del paciente:";
            // 
            // dgvDiagnostico
            // 
            this.dgvDiagnostico.AllowUserToAddRows = false;
            this.dgvDiagnostico.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDiagnostico,
            this.Resultado,
            this.Observaciones});
            this.dgvDiagnostico.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvDiagnostico.Location = new System.Drawing.Point(19, 125);
            this.dgvDiagnostico.Name = "dgvDiagnostico";
            this.dgvDiagnostico.RowHeadersWidth = 51;
            this.dgvDiagnostico.Size = new System.Drawing.Size(554, 318);
            this.dgvDiagnostico.TabIndex = 90;
            this.dgvDiagnostico.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDiagnostico_CellFormatting);
            // 
            // idDiagnostico
            // 
            this.idDiagnostico.HeaderText = "idDiagnostico";
            this.idDiagnostico.Name = "idDiagnostico";
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            this.Resultado.Width = 200;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 200;
            // 
            // frmBuscarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 531);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDNIPaciente);
            this.Controls.Add(this.lblDNIPaciente);
            this.Controls.Add(this.dgvDiagnostico);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarDiagnostico";
            this.Text = "Busqueda de Diagnostico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDNIPaciente;
        private System.Windows.Forms.Label lblDNIPaciente;
        private System.Windows.Forms.DataGridView dgvDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}
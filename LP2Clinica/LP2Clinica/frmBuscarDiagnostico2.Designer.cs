namespace LP2Clinica
{
    partial class frmBuscarDiagnostico2
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNIPaciente = new System.Windows.Forms.TextBox();
            this.lblDNIPaciente = new System.Windows.Forms.Label();
            this.dgvDiagnostico = new System.Windows.Forms.DataGridView();
            this.idDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(419, 99);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 29);
            this.btnBuscar.TabIndex = 98;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDNIPaciente
            // 
            this.txtDNIPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIPaciente.Location = new System.Drawing.Point(24, 102);
            this.txtDNIPaciente.Name = "txtDNIPaciente";
            this.txtDNIPaciente.Size = new System.Drawing.Size(374, 26);
            this.txtDNIPaciente.TabIndex = 97;
            // 
            // lblDNIPaciente
            // 
            this.lblDNIPaciente.AutoSize = true;
            this.lblDNIPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblDNIPaciente.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIPaciente.ForeColor = System.Drawing.Color.White;
            this.lblDNIPaciente.Location = new System.Drawing.Point(20, 77);
            this.lblDNIPaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIPaciente.Name = "lblDNIPaciente";
            this.lblDNIPaciente.Size = new System.Drawing.Size(218, 22);
            this.lblDNIPaciente.TabIndex = 96;
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
            this.dgvDiagnostico.Location = new System.Drawing.Point(24, 140);
            this.dgvDiagnostico.Name = "dgvDiagnostico";
            this.dgvDiagnostico.RowHeadersWidth = 51;
            this.dgvDiagnostico.Size = new System.Drawing.Size(554, 318);
            this.dgvDiagnostico.TabIndex = 95;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(17, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(415, 41);
            this.lblTitulo.TabIndex = 94;
            this.lblTitulo.Text = "BUSQUEDA DE DIAGNÓSTICOS";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(419, 469);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(159, 29);
            this.btnSeleccionar.TabIndex = 99;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarDiagnostico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_4;
            this.ClientSize = new System.Drawing.Size(595, 511);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDNIPaciente);
            this.Controls.Add(this.lblDNIPaciente);
            this.Controls.Add(this.dgvDiagnostico);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBuscarDiagnostico2";
            this.Text = "Busqueda de Diagnosticos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnostico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDNIPaciente;
        private System.Windows.Forms.Label lblDNIPaciente;
        private System.Windows.Forms.DataGridView dgvDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}
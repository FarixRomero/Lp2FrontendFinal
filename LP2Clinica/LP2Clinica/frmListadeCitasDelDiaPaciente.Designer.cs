namespace LP2Clinica
{
    partial class frmListadeCitasDelDiaPaciente
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
            this.dgvCitasMedicas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasMedicas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCitasMedicas
            // 
            this.dgvCitasMedicas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCitasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasMedicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomb,
            this.esp,
            this.Fecha});
            this.dgvCitasMedicas.Location = new System.Drawing.Point(79, 194);
            this.dgvCitasMedicas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCitasMedicas.Name = "dgvCitasMedicas";
            this.dgvCitasMedicas.RowHeadersWidth = 51;
            this.dgvCitasMedicas.Size = new System.Drawing.Size(663, 388);
            this.dgvCitasMedicas.TabIndex = 88;
            this.dgvCitasMedicas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCitasMedicas_CellFormatting);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 60;
            // 
            // nomb
            // 
            this.nomb.HeaderText = "Nombre Completo";
            this.nomb.MinimumWidth = 6;
            this.nomb.Name = "nomb";
            this.nomb.Width = 300;
            // 
            // esp
            // 
            this.esp.HeaderText = "Especialidad";
            this.esp.MinimumWidth = 6;
            this.esp.Name = "esp";
            this.esp.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(198, 94);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(410, 51);
            this.lblTitulo.TabIndex = 89;
            this.lblTitulo.Text = "Lista de Espera por cita";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(531, 612);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(211, 37);
            this.btnSeleccionar.TabIndex = 90;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // frmListadeCitasDelDiaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_B1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 747);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvCitasMedicas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadeCitasDelDiaPaciente";
            this.Text = "frmListadeCitasDelDiaPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasMedicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCitasMedicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn esp;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}
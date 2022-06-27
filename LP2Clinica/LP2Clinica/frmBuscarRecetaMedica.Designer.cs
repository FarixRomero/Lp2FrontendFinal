namespace LP2Clinica
{
    partial class frmBuscarRecetaMedica
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.idRecetaMedica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(425, 41);
            this.lblTitulo.TabIndex = 95;
            this.lblTitulo.Text = "BUSQUEDA DE RECETA MÉDICA";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(523, 427);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(159, 29);
            this.btnSeleccionar.TabIndex = 109;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(523, 66);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 29);
            this.btnBuscar.TabIndex = 108;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.Location = new System.Drawing.Point(19, 70);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(374, 26);
            this.txtIngreso.TabIndex = 107;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.White;
            this.lblIngreso.Location = new System.Drawing.Point(15, 45);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(289, 22);
            this.lblIngreso.TabIndex = 106;
            this.lblIngreso.Text = "Ingresa el nombre o dni del paciente:";
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToAddRows = false;
            this.dgvReceta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecetaMedica,
            this.NombrePaciente,
            this.Codigo,
            this.Nombre});
            this.dgvReceta.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvReceta.Location = new System.Drawing.Point(19, 102);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.Size = new System.Drawing.Size(664, 318);
            this.dgvReceta.TabIndex = 105;
            this.dgvReceta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReceta_CellFormatting);
            // 
            // idRecetaMedica
            // 
            this.idRecetaMedica.HeaderText = "idRecetaMedica";
            this.idRecetaMedica.Name = "idRecetaMedica";
            // 
            // NombrePaciente
            // 
            this.NombrePaciente.HeaderText = "Nombre del Paciente";
            this.NombrePaciente.Name = "NombrePaciente";
            this.NombrePaciente.Width = 200;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo Receta";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Diagnostico";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // frmBuscarRecetaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_3;
            this.ClientSize = new System.Drawing.Size(695, 462);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBuscarRecetaMedica";
            this.Text = "Busqueda de Recetas Médica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecetaMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}
namespace LP2Clinica
{
    partial class frmBuscarMedicamento
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
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.idMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 41);
            this.lblTitulo.TabIndex = 95;
            this.lblTitulo.Text = "BUSQUEDA DE MEDICAMENTOS";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(414, 449);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(159, 29);
            this.btnSeleccionar.TabIndex = 104;
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
            this.btnBuscar.Location = new System.Drawing.Point(414, 79);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 29);
            this.btnBuscar.TabIndex = 103;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.Location = new System.Drawing.Point(19, 82);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(374, 26);
            this.txtIngreso.TabIndex = 102;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblIngreso.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.ForeColor = System.Drawing.Color.White;
            this.lblIngreso.Location = new System.Drawing.Point(15, 57);
            this.lblIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(279, 22);
            this.lblIngreso.TabIndex = 101;
            this.lblIngreso.Text = "Ingresa el nombre del medicamento";
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamento,
            this.Codigo,
            this.Nombre});
            this.dgvMedicamentos.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvMedicamentos.Location = new System.Drawing.Point(19, 120);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.RowHeadersWidth = 51;
            this.dgvMedicamentos.Size = new System.Drawing.Size(554, 318);
            this.dgvMedicamentos.TabIndex = 100;
            this.dgvMedicamentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMedicamentos_CellFormatting);
            // 
            // idMedicamento
            // 
            this.idMedicamento.HeaderText = "idMedicamento";
            this.idMedicamento.Name = "idMedicamento";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Medicamento";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // frmBuscarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_3;
            this.ClientSize = new System.Drawing.Size(595, 511);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBuscarMedicamento";
            this.Text = "Busqueda de Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}
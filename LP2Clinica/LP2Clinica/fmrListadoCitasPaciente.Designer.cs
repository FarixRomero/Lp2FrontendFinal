namespace LP2Clinica
{
    partial class fmrListadoCitasPaciente
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.dtgCitas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCitas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(39, 553);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 41);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(337, -111);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(481, 51);
            this.lblTitulo.TabIndex = 101;
            this.lblTitulo.Text = "GESTIÓN DE CONSULTORIOS";
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDiagnostico.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostico.ForeColor = System.Drawing.Color.White;
            this.btnDiagnostico.Location = new System.Drawing.Point(494, 553);
            this.btnDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(247, 39);
            this.btnDiagnostico.TabIndex = 100;
            this.btnDiagnostico.Text = "Ver diagnostico";
            this.btnDiagnostico.UseVisualStyleBackColor = false;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // dtgCitas
            // 
            this.dtgCitas.AllowUserToAddRows = false;
            this.dtgCitas.AllowUserToDeleteRows = false;
            this.dtgCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDoctor,
            this.colFecha,
            this.colEstado});
            this.dtgCitas.Location = new System.Drawing.Point(39, 128);
            this.dtgCitas.Margin = new System.Windows.Forms.Padding(4);
            this.dtgCitas.Name = "dtgCitas";
            this.dtgCitas.ReadOnly = true;
            this.dtgCitas.RowHeadersWidth = 51;
            this.dtgCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCitas.Size = new System.Drawing.Size(716, 399);
            this.dtgCitas.TabIndex = 96;
            this.dtgCitas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgCitas_CellFormatting);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colDoctor
            // 
            this.colDoctor.HeaderText = "Doctor";
            this.colDoctor.MinimumWidth = 6;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            this.colDoctor.Width = 300;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 125;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 125;
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(91)))));
            this.lblCitas.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.ForeColor = System.Drawing.Color.White;
            this.lblCitas.Location = new System.Drawing.Point(30, 31);
            this.lblCitas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(312, 51);
            this.lblCitas.TabIndex = 103;
            this.lblCitas.Text = "LISTADO DE CITAS";
            this.lblCitas.Click += new System.EventHandler(this.label1_Click);
            // 
            // fmrListadoCitasPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_3;
            this.ClientSize = new System.Drawing.Size(797, 607);
            this.Controls.Add(this.lblCitas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.dtgCitas);
            this.Name = "fmrListadoCitasPaciente";
            this.Text = "fmrListadoCitasPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.DataGridView dtgCitas;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
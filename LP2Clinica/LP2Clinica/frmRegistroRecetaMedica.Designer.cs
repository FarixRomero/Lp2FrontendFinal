namespace LP2Clinica
{
    partial class frmRegistroRecetaMedica
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.CodMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarDiagnostico = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbLineasReceta = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.pbReceta = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblCodigoReceta = new System.Windows.Forms.Label();
            this.txtCodigoReceta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.gbLineasReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(13, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(409, 41);
            this.lblTitulo.TabIndex = 74;
            this.lblTitulo.Text = "REGISTRO DE RECETA MÉDICA";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.LightGray;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Location = new System.Drawing.Point(318, 145);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(144, 20);
            this.txtResultado.TabIndex = 22;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(219, 143);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(93, 22);
            this.lblResultado.TabIndex = 21;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(425, 447);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(158, 33);
            this.btnRegistrar.TabIndex = 95;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(20, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 33);
            this.btnCancelar.TabIndex = 94;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToAddRows = false;
            this.dgvReceta.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodMedicamento,
            this.Producto,
            this.Cantidad});
            this.dgvReceta.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dgvReceta.Location = new System.Drawing.Point(20, 351);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.Size = new System.Drawing.Size(566, 90);
            this.dgvReceta.TabIndex = 93;
            this.dgvReceta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReceta_CellFormatting);
            // 
            // CodMedicamento
            // 
            this.CodMedicamento.HeaderText = "Codigo del medicamento";
            this.CodMedicamento.Name = "CodMedicamento";
            this.CodMedicamento.Width = 150;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Nombre del medicamento";
            this.Producto.Name = "Producto";
            this.Producto.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(26, 85);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 29);
            this.btnEliminar.TabIndex = 91;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarDiagnostico
            // 
            this.btnBuscarDiagnostico.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarDiagnostico.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDiagnostico.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDiagnostico.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDiagnostico.Location = new System.Drawing.Point(473, 118);
            this.btnBuscarDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarDiagnostico.Name = "btnBuscarDiagnostico";
            this.btnBuscarDiagnostico.Size = new System.Drawing.Size(113, 55);
            this.btnBuscarDiagnostico.TabIndex = 90;
            this.btnBuscarDiagnostico.Text = "Buscar Diagnóstico";
            this.btnBuscarDiagnostico.UseVisualStyleBackColor = false;
            this.btnBuscarDiagnostico.Click += new System.EventHandler(this.btnBuscarDiagnostico_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(220, 85);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(151, 29);
            this.btnBuscar.TabIndex = 99;
            this.btnBuscar.Text = "Buscar Receta";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(219, 118);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(130, 22);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID Diagnóstico:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LightGray;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(355, 120);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(107, 20);
            this.txtID.TabIndex = 24;
            // 
            // gbLineasReceta
            // 
            this.gbLineasReceta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbLineasReceta.Controls.Add(this.btnBuscarProducto);
            this.gbLineasReceta.Controls.Add(this.btnResta);
            this.gbLineasReceta.Controls.Add(this.btnSuma);
            this.gbLineasReceta.Controls.Add(this.txtCantidad);
            this.gbLineasReceta.Controls.Add(this.txtProducto);
            this.gbLineasReceta.Controls.Add(this.txtCodigoProducto);
            this.gbLineasReceta.Controls.Add(this.lblCantidad);
            this.gbLineasReceta.Controls.Add(this.lblProducto);
            this.gbLineasReceta.Controls.Add(this.lblCodigoProducto);
            this.gbLineasReceta.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLineasReceta.Location = new System.Drawing.Point(20, 245);
            this.gbLineasReceta.Name = "gbLineasReceta";
            this.gbLineasReceta.Size = new System.Drawing.Size(566, 100);
            this.gbLineasReceta.TabIndex = 100;
            this.gbLineasReceta.TabStop = false;
            this.gbLineasReceta.Text = "Lineas de Receta médica";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.White;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(308, 59);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(43, 27);
            this.btnBuscarProducto.TabIndex = 103;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(498, 50);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(49, 23);
            this.btnResta.TabIndex = 107;
            this.btnResta.Text = " -";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(498, 21);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(49, 23);
            this.btnSuma.TabIndex = 106;
            this.btnSuma.Text = " +";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(392, 25);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 24);
            this.txtCantidad.TabIndex = 105;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(156, 60);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(128, 24);
            this.txtProducto.TabIndex = 104;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(156, 23);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(128, 24);
            this.txtCodigoProducto.TabIndex = 101;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(304, 25);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(82, 22);
            this.lblCantidad.TabIndex = 103;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.Location = new System.Drawing.Point(6, 59);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(68, 19);
            this.lblProducto.TabIndex = 102;
            this.lblProducto.Text = "Producto:";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoProducto.Location = new System.Drawing.Point(6, 25);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(144, 19);
            this.lblCodigoProducto.TabIndex = 101;
            this.lblCodigoProducto.Text = "Código del producto:";
            // 
            // pbReceta
            // 
            this.pbReceta.BackColor = System.Drawing.Color.Transparent;
            this.pbReceta.Image = global::LP2Clinica.Properties.Resources.png_transparent_medical_prescription_computer_icons_pharmaceutical_drug_others_miscellaneous_text_orange_removebg_preview1;
            this.pbReceta.Location = new System.Drawing.Point(30, 121);
            this.pbReceta.Name = "pbReceta";
            this.pbReceta.Size = new System.Drawing.Size(183, 105);
            this.pbReceta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReceta.TabIndex = 101;
            this.pbReceta.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(122, 85);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 29);
            this.btnNuevo.TabIndex = 102;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblCodigoReceta
            // 
            this.lblCodigoReceta.AutoSize = true;
            this.lblCodigoReceta.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoReceta.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoReceta.ForeColor = System.Drawing.Color.White;
            this.lblCodigoReceta.Location = new System.Drawing.Point(219, 204);
            this.lblCodigoReceta.Name = "lblCodigoReceta";
            this.lblCodigoReceta.Size = new System.Drawing.Size(152, 22);
            this.lblCodigoReceta.TabIndex = 103;
            this.lblCodigoReceta.Text = "Código de Receta:";
            // 
            // txtCodigoReceta
            // 
            this.txtCodigoReceta.Location = new System.Drawing.Point(377, 204);
            this.txtCodigoReceta.Name = "txtCodigoReceta";
            this.txtCodigoReceta.Size = new System.Drawing.Size(206, 20);
            this.txtCodigoReceta.TabIndex = 108;
            // 
            // frmRegistroRecetaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 492);
            this.Controls.Add(this.txtCodigoReceta);
            this.Controls.Add(this.lblCodigoReceta);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pbReceta);
            this.Controls.Add(this.gbLineasReceta);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarDiagnostico);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroRecetaMedica";
            this.Text = "Registrar Receta Medica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.gbLineasReceta.ResumeLayout(false);
            this.gbLineasReceta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarDiagnostico;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbLineasReceta;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.PictureBox pbReceta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCodigoReceta;
        private System.Windows.Forms.TextBox txtCodigoReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}
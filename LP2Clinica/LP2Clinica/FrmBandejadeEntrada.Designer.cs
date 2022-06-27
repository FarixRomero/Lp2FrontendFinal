namespace LP2Clinica
{
    partial class FrmBandejadeEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBandejadeEntrada));
            this.dgvBandeja = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChat = new System.Windows.Forms.Panel();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBandeja
            // 
            this.dgvBandeja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.dgvBandeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandeja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.Nombre_Completo});
            this.dgvBandeja.Location = new System.Drawing.Point(-1, 0);
            this.dgvBandeja.Name = "dgvBandeja";
            this.dgvBandeja.RowHeadersWidth = 51;
            this.dgvBandeja.RowTemplate.Height = 24;
            this.dgvBandeja.Size = new System.Drawing.Size(275, 608);
            this.dgvBandeja.TabIndex = 0;
            this.dgvBandeja.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBandeja_CellFormatting);
            this.dgvBandeja.SelectionChanged += new System.EventHandler(this.dgvBandeja_SelectionChanged);
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Visible = false;
            this.Foto.Width = 125;
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.HeaderText = "Nombre";
            this.Nombre_Completo.MinimumWidth = 6;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.Visible = false;
            this.Nombre_Completo.Width = 125;
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.BackColor = System.Drawing.Color.Transparent;
            this.panelChat.Location = new System.Drawing.Point(280, 0);
            this.panelChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(512, 520);
            this.panelChat.TabIndex = 8;
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEnviarMensaje.ImageKey = "(ninguno)";
            this.btnEnviarMensaje.Location = new System.Drawing.Point(659, 535);
            this.btnEnviarMensaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(126, 51);
            this.btnEnviarMensaje.TabIndex = 38;
            this.btnEnviarMensaje.Text = "Enviar Mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = false;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(281, 537);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(371, 30);
            this.txtMensaje.TabIndex = 111;
            this.txtMensaje.Text = "Escribir su mensaje";
            // 
            // FrmBandejadeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 607);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.dgvBandeja);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBandejadeEntrada";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmBandejadeEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBandeja;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}
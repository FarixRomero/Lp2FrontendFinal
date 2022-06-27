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
            this.panelChat = new System.Windows.Forms.Panel();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.Nombre_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBandeja
            // 
            this.dgvBandeja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.dgvBandeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandeja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Completo});
            this.dgvBandeja.Location = new System.Drawing.Point(11, 11);
            this.dgvBandeja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBandeja.Name = "dgvBandeja";
            this.dgvBandeja.RowHeadersWidth = 51;
            this.dgvBandeja.RowTemplate.Height = 24;
            this.dgvBandeja.Size = new System.Drawing.Size(206, 494);
            this.dgvBandeja.TabIndex = 0;
            this.dgvBandeja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBandeja_CellContentClick);
            this.dgvBandeja.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBandeja_CellFormatting);
            this.dgvBandeja.SelectionChanged += new System.EventHandler(this.dgvBandeja_SelectionChanged);
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.BackColor = System.Drawing.Color.Transparent;
            this.panelChat.Location = new System.Drawing.Point(222, 11);
            this.panelChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(384, 422);
            this.panelChat.TabIndex = 8;
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEnviarMensaje.ImageKey = "(ninguno)";
            this.btnEnviarMensaje.Location = new System.Drawing.Point(506, 446);
            this.btnEnviarMensaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(94, 41);
            this.btnEnviarMensaje.TabIndex = 38;
            this.btnEnviarMensaje.Text = "Enviar Mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = false;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(223, 447);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(279, 26);
            this.txtMensaje.TabIndex = 111;
            this.txtMensaje.Text = "Escribir su mensaje";
            // 
            // Nombre_Completo
            // 
            this.Nombre_Completo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre_Completo.HeaderText = "Nombre";
            this.Nombre_Completo.MinimumWidth = 50;
            this.Nombre_Completo.Name = "Nombre_Completo";
            this.Nombre_Completo.Visible = false;
            this.Nombre_Completo.Width = 200;
            // 
            // FrmBandejadeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 640);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.dgvBandeja);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Completo;
    }
}
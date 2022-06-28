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
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.dgvBandeja = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensajeEs = new System.Windows.Forms.Label();
            this.PanelChatFlow = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEnviarMensaje.ImageKey = "(ninguno)";
            this.btnEnviarMensaje.Location = new System.Drawing.Point(638, 461);
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
            this.txtMensaje.Location = new System.Drawing.Point(354, 476);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(279, 26);
            this.txtMensaje.TabIndex = 111;
            // 
            // dgvBandeja
            // 
            this.dgvBandeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandeja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.dgvBandeja.Location = new System.Drawing.Point(35, 12);
            this.dgvBandeja.Name = "dgvBandeja";
            this.dgvBandeja.Size = new System.Drawing.Size(254, 523);
            this.dgvBandeja.TabIndex = 112;
            this.dgvBandeja.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBandeja_CellFormatting);
            this.dgvBandeja.SelectionChanged += new System.EventHandler(this.dgvBandeja_SelectionChanged);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // lblMensajeEs
            // 
            this.lblMensajeEs.AutoSize = true;
            this.lblMensajeEs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensajeEs.Location = new System.Drawing.Point(351, 461);
            this.lblMensajeEs.Name = "lblMensajeEs";
            this.lblMensajeEs.Size = new System.Drawing.Size(85, 13);
            this.lblMensajeEs.TabIndex = 113;
            this.lblMensajeEs.Text = "Escriba Mensaje";
            // 
            // PanelChatFlow
            // 
            this.PanelChatFlow.Location = new System.Drawing.Point(354, 14);
            this.PanelChatFlow.Name = "PanelChatFlow";
            this.PanelChatFlow.Size = new System.Drawing.Size(246, 444);
            this.PanelChatFlow.TabIndex = 114;
            this.PanelChatFlow.WrapContents = false;
            // 
            // FrmBandejadeEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 619);
            this.Controls.Add(this.PanelChatFlow);
            this.Controls.Add(this.lblMensajeEs);
            this.Controls.Add(this.dgvBandeja);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnEnviarMensaje);
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
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.DataGridView dgvBandeja;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label lblMensajeEs;
        private System.Windows.Forms.FlowLayoutPanel PanelChatFlow;
    }
}
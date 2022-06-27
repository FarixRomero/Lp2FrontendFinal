namespace LP2Clinica
{
    partial class ImprimirDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImprimirDiagnostico));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoCita = new System.Windows.Forms.TextBox();
            this.lblCodigoCita = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.sfdArchivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(665, 139);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 34);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoCita
            // 
            this.txtCodigoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCita.Location = new System.Drawing.Point(344, 141);
            this.txtCodigoCita.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCita.Name = "txtCodigoCita";
            this.txtCodigoCita.Size = new System.Drawing.Size(313, 30);
            this.txtCodigoCita.TabIndex = 117;
            // 
            // lblCodigoCita
            // 
            this.lblCodigoCita.AutoSize = true;
            this.lblCodigoCita.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoCita.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCita.ForeColor = System.Drawing.Color.White;
            this.lblCodigoCita.Location = new System.Drawing.Point(55, 141);
            this.lblCodigoCita.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoCita.Name = "lblCodigoCita";
            this.lblCodigoCita.Size = new System.Drawing.Size(240, 28);
            this.lblCodigoCita.TabIndex = 116;
            this.lblCodigoCita.Text = "Ingresa el id de la Cita:";
            this.lblCodigoCita.Click += new System.EventHandler(this.lblCodigoCita_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 49);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(337, 48);
            this.lblTitulo.TabIndex = 115;
            this.lblTitulo.Text = "Diagnostico completo";
            // 
            // visorPDF
            // 
            this.visorPDF.Enabled = true;
            this.visorPDF.Location = new System.Drawing.Point(42, 193);
            this.visorPDF.Name = "visorPDF";
            this.visorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPDF.OcxState")));
            this.visorPDF.Size = new System.Drawing.Size(729, 402);
            this.visorPDF.TabIndex = 119;
            // 
            // ImprimirDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LP2Clinica.Properties.Resources.PANTALLA_3;
            this.ClientSize = new System.Drawing.Size(797, 607);
            this.Controls.Add(this.visorPDF);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoCita);
            this.Controls.Add(this.lblCodigoCita);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ImprimirDiagnostico";
            this.Text = "ImprimirDiagnostico";
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoCita;
        private System.Windows.Forms.Label lblCodigoCita;
        private System.Windows.Forms.Label lblTitulo;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
        private System.Windows.Forms.SaveFileDialog sfdArchivo;
    }
}
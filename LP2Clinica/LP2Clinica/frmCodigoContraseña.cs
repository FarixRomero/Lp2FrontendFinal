using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Clinica
{
    public partial class frmCodigoContraseña : Form
    {
        private bool _ingresacodigo = false; 
        Button _boton=null;
        public frmCodigoContraseña()
        {
            InitializeComponent();
        }
        public bool Ingresacodigo { get => _ingresacodigo; set => _ingresacodigo = value; }
        public void Enviarboton( Button boton) {
            _boton = boton;
        }
        public string verificaringreso() {
            if (txtCodigoverificacion.Text == "1234")
            { //aqui debe validarse el código de verificación
                _ingresacodigo = true;
            }
            else { 
                _ingresacodigo = false; 
            }
            return txtEmail.Text;
        }
        private void btEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe ingresar un correo electrónico válido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //txtEmail.Text = "";
                MessageBox.Show("Se ha enviado el código a su correo electrónico", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _boton.Enabled = true;
            }
        }
    }
}

/******************************************************************************
                    EQUIPO LOS JAVOS - LENGUAJE DE PROGRAMACIÓN 2
*******************************************************************************/

/***EL CODIGO DE VERIFICACIÓN A PROBAR ES 1234 ****/

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
    public partial class frmCodigoDeVerificacionRegistro : Form
    {
        private bool _pasarsiguiente = false;
        public frmCodigoDeVerificacionRegistro()
        {
            InitializeComponent();
            //MessageBox.Show("El código de verificación es 1234", "Mensaje de código", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool pasarsiguiente { get => _pasarsiguiente; set => _pasarsiguiente = value; }
        private void bnCancelar_Click(object sender, EventArgs e)
        {
            // Aqui debe llevarme a la pantalla de registro inicial
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) this.Close();
            
        }

        private void bnIngresar_Click(object sender, EventArgs e)
        {
            if(txtCodigoVerificacion.Text == "")
            {
                MessageBox.Show("El código de verificación no es el correcto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoVerificacion.Text = "";
            }
            else if (txtCodigoVerificacion.Text=="1234")
            {
                MessageBox.Show("¡Se ha verificado con exito!", "Mensaje de verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _pasarsiguiente = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un código de verificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

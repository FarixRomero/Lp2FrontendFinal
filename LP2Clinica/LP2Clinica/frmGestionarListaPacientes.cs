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
    public partial class frmGestionarListaPacientes : Form
    {
        private PrincipalAdministrador Principal = null;
        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        public frmGestionarListaPacientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion de Lista Pacientes?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Principal.Show();
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //se registra una nueva cita
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //se activa una pantalla adicional donde se cambia el estado de la cita
            // en esta pantalla también se puede eliminar la cita 
            frmCitaMedica cita = new frmCitaMedica();
            cita.ShowDialog();
        }
    }
}

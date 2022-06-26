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
    public partial class frmGestionarEspecialidad : Form
    {
        private PrincipalAdministrador Principal = null;
        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        public frmGestionarEspecialidad()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion de Especialidades?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Principal.Show();
                this.Close();
            }
        }
    }
}

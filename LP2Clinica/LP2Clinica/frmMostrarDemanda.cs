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
    public partial class frmMostrarDemanda : Form
    {
        PrincipalAdministrador Principal = null;
        public frmMostrarDemanda()
        {
            InitializeComponent();
        }
        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de esta pestaña?",
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

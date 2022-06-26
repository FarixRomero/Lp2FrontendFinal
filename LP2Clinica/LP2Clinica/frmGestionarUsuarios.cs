using LP2Clinica.RRHHWS;
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
    public partial class frmGestionarUsuarios : Form
    {
        private PrincipalAdministrador Principal = null;
        private RRHHWS.administrador _administrador = null;

        public administrador Administrador { get => _administrador; set => _administrador = value; }

        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        public frmGestionarUsuarios(RRHHWS.administrador administrador)
        {
            InitializeComponent();
            _administrador = administrador;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion de Usuarios?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Principal.Show();
                this.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // modificar que? , xdxdxd 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoRegistroDeterminarTipo nuevoregistro = new NuevoRegistroDeterminarTipo(_administrador);
            nuevoregistro.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // se escoge elimina la cartilla seleccionada con el siguiente mensaje:
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas ELIMINAR a este usuario?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                //Aqui se modifica en la base de datos el estado activo del Medico
                this.Close();
            }
        }
    }
}

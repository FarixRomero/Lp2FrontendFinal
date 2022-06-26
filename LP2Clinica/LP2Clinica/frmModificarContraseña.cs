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
    public partial class frmModificarContraseña : Form
    {
        private Form formularioActivo = null;
        private frmCodigoContraseña comprobarcodigo = null;
        private frmIngresarNuevaContraseña nuevacontraseña = null;
        private int formulario = 0;
        private string correo = "";
        
        public frmModificarContraseña()
        {
            InitializeComponent();
            comprobarcodigo = new frmCodigoContraseña();
            nuevacontraseña = new frmIngresarNuevaContraseña();
            btnConfirmar.Enabled = false;
            comprobarcodigo.Enviarboton(btnConfirmar);
            abrirFormulario(comprobarcodigo);
            
        }
        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar inconclusa esta tarea?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (formulario)//depende del formulario el botón confirmar se comportará de una forma u otra
            {
                case 0:
                    correo = comprobarcodigo.verificaringreso();
                    if (!comprobarcodigo.Ingresacodigo) MessageBox.Show("Debe ingresar un codigo de verificación valido", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        //debemos pasar a poder ingresar la nueva contraseña 
                        abrirFormulario(nuevacontraseña);
                        formulario = 1;
                    }
                    break;
                case 1:
                    //nuevacontraseña.verificaringreso();
                    if (!nuevacontraseña.verificaringreso(correo)) MessageBox.Show("El ingreso de la nueva contraseña debe ser válida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        MessageBox.Show("Se ha logrado cambiar la contraseña exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    break;
            }

        }
    }
}

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
    public partial class frmAdministrarMedico : Form
    {
        Form formularioActivo = null;
        public frmAdministrarMedico()
        {
            InitializeComponent();
            abrirFormulario(new CartillaInformacion());
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            //Aqui se modifican los datos y para ello se envia a otro formulario donde se muestra 
            //la información que se va a modificar
            modificardatosmedicos modificarmedico= new modificardatosmedicos();
            modificarmedico.Principal = this;
            modificarmedico.Anterior = new CartillaInformacion();
            abrirFormulario(modificarmedico);
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
        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {

        }

        private void btnVerCalendario_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas ELIMINAR a este médico?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                //Aqui se modifica en la base de datos el estado activo del Medico
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

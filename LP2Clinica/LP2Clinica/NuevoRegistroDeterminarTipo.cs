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
    public partial class NuevoRegistroDeterminarTipo : Form
    {
        private RRHHWS.administrador _administradorSeleccionado = null;
        public NuevoRegistroDeterminarTipo(RRHHWS.administrador administrador)
        {
            InitializeComponent();
            _administradorSeleccionado = administrador;
        }

        public administrador AdministradorSeleccionado { get => _administradorSeleccionado; set => _administradorSeleccionado = value; }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
             
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ( rbMedico.Checked)
            {
               
                frmRegistrarNuevoMedico registro = new frmRegistrarNuevoMedico(_administradorSeleccionado);
                //registro.AdministradorEncargado = _administradorSeleccionado;
                registro.Show();
                this.Close(); // OJO CON EL CLOSE PA QUE NO SE PIERDA LA DATA ANTERIOR

            }
            else if (rbPaciente.Checked)
            {
                frmRegistroNuevoPaciente registro = new frmRegistroNuevoPaciente();
                registro.Show();
                this.Close(); // OJO CON EL CLOSE PA QUE NO SE PIERDA LA DATA ANTERIOR

            }
            else
            {
                MessageBox.Show("Señale el tipo de usuario", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

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
        private RRHHWS.medico _medico;
        private RRHHWS.RRHHWSClient daoRRHH;
        private Estado _estado;
        public frmAdministrarMedico(RRHHWS.medico medico)
        {
            InitializeComponent();

            daoRRHH = new RRHHWS.RRHHWSClient();
            this._medico = medico;

            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnEditarDatos.Enabled = true;
                    btnGuardar.Visible = false;
                    btnCancelar.Visible = false;
                    btnRegistrarCita.Enabled = true;
                    btnVerCalendario.Enabled = true;
                    btnCerrar.Enabled = true;
                    txtCorreo.Enabled = false;
                    txtUser.Enabled = false;
                    break;

                case Estado.Modificar:
                    btnEditarDatos.Enabled = true;
                    btnGuardar.Visible = true;
                    btnCancelar.Visible = true;
                    btnRegistrarCita.Enabled = false;
                    btnVerCalendario.Enabled = false;
                    btnCerrar.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtUser.Enabled = true;
                    break;

                case Estado.Buscar:
                    
                    break;
            }
        }
        public void limpiarComponentes()
        {
            lblNombreCompleto.Text = _medico.nombre + " " + _medico.apellido;
            lblDNI.Text = _medico.DNI;
            lblEspecialidad.Text = _medico.especialidad.nombre;
            txtCorreo.Text = _medico.email;
            txtUser.Text = _medico.username;
        }

        private void btnEditarDatos_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RRHHWS.medico medicoModificado = _medico;
            medicoModificado.email = txtCorreo.Text;
            medicoModificado.username = txtUser.Text;

            int resultado = daoRRHH.modificarUsuario(medicoModificado);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha modificado el medico correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
                limpiarComponentes();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con la modificación del médico", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

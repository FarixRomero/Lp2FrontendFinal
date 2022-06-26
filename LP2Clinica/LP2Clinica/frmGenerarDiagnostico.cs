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
    public partial class frmGenerarDiagnostico : Form
    {
        private Estado _estado;
        private GestionMedicaWS.diagnostico _diagnostico;
        private GestionMedicaWS.citaMedica _citaMedica;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        
        private PrincipalMedico Principal = null;
        public void SetPrincipal(PrincipalMedico principal)
        {
            Principal = principal;
        }
        public frmGenerarDiagnostico()
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarcomponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnEliminar.Enabled  = false;
                    btnNuevo.Enabled     = true;
                    btnEditar.Enabled    = false;
                    btnCancelar.Enabled  = true;
                    btnRegistrar.Enabled = false;
                    gpPaciente.Enabled = false;
                    txtResultado.Enabled = false;
                    txtObservacion.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnEliminar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnRegistrar.Enabled = true;
                    gpPaciente.Enabled = true;
                    txtResultado.Enabled = true;
                    txtObservacion.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnEliminar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnRegistrar.Enabled = true;
                    gpPaciente.Enabled = true;
                    txtResultado.Enabled = true;
                    txtObservacion.Enabled = true;
                    break;
            }
        }

        public void limpiarcomponentes() {
            txtIDCita.Text = "";
            txtObservacion.Text = "";
            txtResultado.Text = "";
            lblNombrePaciente.Text = "-";
            lblFechaCita.Text = "--/--/--";
            lblEstadoDiagnostico.Text = "-";
            _diagnostico = new GestionMedicaWS.diagnostico();
            _citaMedica = new GestionMedicaWS.citaMedica();
        }
        private void bnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro de diagnostico?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Principal.Show();
                this.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            _diagnostico.resultado = txtResultado.Text;
            _diagnostico.observacion = txtObservacion.Text;

            _diagnostico.citaMedica = new GestionMedicaWS.citaMedica();
            _diagnostico.citaMedica = _citaMedica;//_diagnostico.citaMedica.id_cita = Int32.Parse(txtIDCita.Text);

            _diagnostico.historialClinico = new GestionMedicaWS.historialClinico();
            _diagnostico.historialClinico.nroHistoria = daoGestionMedica.obtenerIDHistorialPorIDPaciente(_citaMedica.paciente.id_paciente);

            if(_estado == Estado.Nuevo)
            {
                int resultado = daoGestionMedica.insertarDiagnostico(_diagnostico);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado el diagnostico correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error con el registro del diagnostico", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(_estado == Estado.Modificar)
            {
                int resultado = daoGestionMedica.modificarDiagnostico(_diagnostico);
                if(resultado != 0)
                {
                    MessageBox.Show("Se ha modificado el diagnostico correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error con el registro del diagnostico", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarcomponentes();
            establecerEstadoComponentes();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(txtIDCita.Text != "")
            {
                _citaMedica = daoGestionMedica.buscarCitaMedicaPorId(Int32.Parse(txtIDCita.Text));

                lblNombrePaciente.Text = _citaMedica.paciente.nombre + " " + _citaMedica.paciente.apellido;
                lblEstadoDiagnostico.Text = _citaMedica.estado.ToString();
                lblFechaCita.Text = _citaMedica.fecha.ToShortDateString();

                _diagnostico = daoGestionMedica.buscarDiagnosticoPorIdCita(Int32.Parse(txtIDCita.Text));

                if(_diagnostico.id_diagnostico != 0)
                {
                    txtResultado.Text = _diagnostico.resultado; txtResultado.Enabled = false;
                    txtObservacion.Text = _diagnostico.observacion; txtObservacion.Enabled = false;

                    btnRegistrar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnEditar.Enabled = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar este diagnostico?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                int resultado = daoGestionMedica.eliminarDiagnostico(_diagnostico);
                if (resultado != 0)
                    MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _estado = Estado.Inicial;
                limpiarcomponentes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }
    }
}

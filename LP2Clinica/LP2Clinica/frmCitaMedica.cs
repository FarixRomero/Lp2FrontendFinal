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
    public partial class frmCitaMedica : Form
    {
        private GestionMedicaWS.citaMedica _citaMedica;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        public frmCitaMedica(GestionMedicaWS.citaMedica citaMedica)
        {
            InitializeComponent();
            _citaMedica = citaMedica;
            cbEstadoCita.Items.Add("ATENDIDA");
            cbEstadoCita.Items.Add("RESERVADA");
            cbEstadoCita.Items.Add("CANCELADA");
            cbEstadoCita.Items.Add("CONCLUIDA");
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            lblFechaProgramada.Text = _citaMedica.fecha.ToString();
            lblNombreDoctor.Text = _citaMedica.horario.medico.nombre + " "
                + _citaMedica.horario.medico.apellido;
            //Modificar en el procedure
            //lblNombrePaciente.Text = _citaMedica.paciente.nombre + " "
            //   + _citaMedica.paciente.apellido;
        }

        public frmCitaMedica()
        {
            InitializeComponent();
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Haz guardado todos los cambios?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas confirmar la modificación?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //aqui se modifica el estado;
                _citaMedica.estado = cbEstadoCita.SelectedItem.ToString();

                int resultado = daoGestionMedica.modificarCitaMedica(_citaMedica);
                if (resultado == 1)
                {
                    MessageBox.Show("¡Se ha modificado el estado de cita con exito!", "Mensaje de verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

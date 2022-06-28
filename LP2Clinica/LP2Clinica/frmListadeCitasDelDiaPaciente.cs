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
    public partial class frmListadeCitasDelDiaPaciente : Form
    {
        GestionMedicaWS.citaMedica _citaseleccionada;
        GestionMedicaWS.paciente _paciente;
        private GestionMedicaWS.GestionMedicaWSClient daoGESTMED;

        public frmListadeCitasDelDiaPaciente()
        {
            InitializeComponent();
            
        }
        public frmListadeCitasDelDiaPaciente(GestionMedicaWS.paciente paciente)
        {
            InitializeComponent();
            _paciente = paciente;
            dgvCitasMedicas.AutoGenerateColumns = false;
            //aqui tendría que ir el procedure para cargar las citas 
            daoGESTMED = new GestionMedicaWS.GestionMedicaWSClient();


            GestionMedicaWS.citaMedica _citaFecha = new GestionMedicaWS.citaMedica() ;
            _citaFecha.fechaSpecified = true ;
            _citaFecha.fecha = DateTime.Now ;
            _citaFecha.paciente = paciente;

            GestionMedicaWS.citaMedica[] citasMedicas = daoGESTMED.listarCitasXPacienteYFecha(_citaFecha);
            if (citasMedicas != null)
                dgvCitasMedicas.DataSource = new BindingList<GestionMedicaWS.citaMedica>(citasMedicas.ToList());
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCitasMedicas.CurrentRow != null)
            {
                _citaseleccionada = (GestionMedicaWS.citaMedica)dgvCitasMedicas.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                // aqui se selecciona al doctor y se muestra sus datos en una pantalla
                frmCitasAntesQueTu verMedico = new frmCitasAntesQueTu(_citaseleccionada);
                verMedico.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Cita", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvCitasMedicas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // lo pongo como rrhhws.medico o como gestionmedicows.citas????
            GestionMedicaWS.citaMedica citaMed = (GestionMedicaWS.citaMedica)dgvCitasMedicas.Rows[e.RowIndex].DataBoundItem;
            if (citaMed != null)
            {
                dgvCitasMedicas.Rows[e.RowIndex].Cells[0].Value = citaMed.horario.medico.id_medico;
                dgvCitasMedicas.Rows[e.RowIndex].Cells[1].Value = citaMed.horario.medico.nombre + " " + citaMed.horario.medico.apellido;
                dgvCitasMedicas.Rows[e.RowIndex].Cells[2].Value = citaMed.horario.horasHorario.hora_inicio;
                dgvCitasMedicas.Rows[e.RowIndex].Cells[3].Value = citaMed.horario.horasHorario.hora_fin;

                //dgvCitasMedicas.Rows[e.RowIndex].Cells[1].Value = med.nombre + " " + med.apellido;
                //dgvCitasMedicas.Rows[e.RowIndex].Cells[2].Value = med.especialidad.nombre;
                //dgvCitasMedicas.Rows[e.RowIndex].Cells[3].Value = //fecha de la cita ;

            }
        }
    }
}

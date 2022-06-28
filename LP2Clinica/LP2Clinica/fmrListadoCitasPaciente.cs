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
    public partial class fmrListadoCitasPaciente : Form
    {
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        private PrincipalCliente Principal = null;
        private int idPaciente;
        private GestionMedicaWS.citaMedica _citaSeleccionada;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }

        public fmrListadoCitasPaciente()
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            IdPaciente = 44;
            GestionMedicaWS.citaMedica[] citaMedica = daoGestionMedica.buscarCitaXPaciente(IdPaciente);
            dtgCitas.AutoGenerateColumns = false;
            if (citaMedica != null && citaMedica.Length > 0) {
                dtgCitas.DataSource = 
                    new BindingList<GestionMedicaWS.citaMedica>(citaMedica.ToList());
            }
        }

        public void SetPrincipal(PrincipalCliente principal)
        {
            Principal = principal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgCitas.Rows[e.RowIndex].DataBoundItem != null) { 
                GestionMedicaWS.citaMedica cm =
                   (GestionMedicaWS.citaMedica)
                   dtgCitas.Rows[e.RowIndex].DataBoundItem;
                dtgCitas.Rows[e.RowIndex].Cells[0].Value = cm.id_cita;
                dtgCitas.Rows[e.RowIndex].Cells[1].Value =
                    cm.horario.medico.nombre + " " + cm.horario.medico.apellido;
                dtgCitas.Rows[e.RowIndex].Cells[2].Value = cm.fecha;
                dtgCitas.Rows[e.RowIndex].Cells[3].Value = cm.estado;
            }
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            _citaSeleccionada = new GestionMedicaWS.citaMedica();
            _citaSeleccionada = (GestionMedicaWS.citaMedica)dtgCitas.CurrentRow.DataBoundItem;
            frmMostrarDiagnostico formMostrarDiagnostico = new frmMostrarDiagnostico(_citaSeleccionada.id_cita);
            formMostrarDiagnostico.IdCita = _citaSeleccionada.id_cita;
            if (formMostrarDiagnostico.ShowDialog() == DialogResult.OK)
            {
                GestionMedicaWS.citaMedica[] citaMedica = daoGestionMedica.buscarCitaXPaciente(IdPaciente);
                if (citaMedica != null)
                {
                    dtgCitas.DataSource =
                        new BindingList<GestionMedicaWS.citaMedica>(citaMedica.ToList());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion citas medicas?",
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

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
    public partial class frmVerCitas : Form
    {
        private RRHHWS.medico _medico;
        private GestionMedicaWS.GestionMedicaWSClient daoGM;
        public frmVerCitas(RRHHWS.medico medico)
        {
            InitializeComponent();

            _medico = medico;
            daoGM = new GestionMedicaWS.GestionMedicaWSClient();

            dgvCitas.AutoGenerateColumns = false;

            GestionMedicaWS.citaMedica[] citas = daoGM.listarCitaMedicaXIDMedico(medico.id_medico);
            if (citas != null)
            {
                dgvCitas.DataSource = new BindingList<GestionMedicaWS.citaMedica>(citas.ToList());
            }
        }

        private void dgvCitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.citaMedica cita = (GestionMedicaWS.citaMedica)dgvCitas.Rows[e.RowIndex].DataBoundItem;
            dgvCitas.Rows[e.RowIndex].Cells[0].Value = cita.id_cita;
            dgvCitas.Rows[e.RowIndex].Cells[1].Value = cita.fecha.ToString("yyyy-MM-dd");
            dgvCitas.Rows[e.RowIndex].Cells[2].Value = DateTime.Parse(cita.horario.horasHorario.hora_inicio).ToString("hh:mm") + " - " + DateTime.Parse(cita.horario.horasHorario.hora_fin).ToString("hh:mm");
            dgvCitas.Rows[e.RowIndex].Cells[3].Value = cita.paciente.nombre;
            dgvCitas.Rows[e.RowIndex].Cells[4].Value = cita.paciente.DNI;
            dgvCitas.Rows[e.RowIndex].Cells[5].Value = cita.estado;
        }
    }
}

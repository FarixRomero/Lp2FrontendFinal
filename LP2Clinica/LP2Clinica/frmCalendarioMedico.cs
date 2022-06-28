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
    public partial class frmCalendarioMedico : Form
    {

        private GestionMedicaWS.GestionMedicaWSClient daoGM;
        public frmCalendarioMedico(RRHHWS.medico medico)
        {
            InitializeComponent();

            lblTitulo.Text = "Horarios de: " + medico.nombre + " " + medico.apellido;
            daoGM = new GestionMedicaWS.GestionMedicaWSClient();
            dgvHorarios.AutoGenerateColumns = false;

            GestionMedicaWS.horario[] horarios = daoGM.listarHorariosXIDMedico(medico.id_medico);
            if(horarios != null)
            {
                dgvHorarios.DataSource = new BindingList<GestionMedicaWS.horario>(horarios.ToList());
            }
        }

        private void dgvHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.horario horario = (GestionMedicaWS.horario)dgvHorarios.Rows[e.RowIndex].DataBoundItem;
            dgvHorarios.Rows[e.RowIndex].Cells[0].Value = horario.id_horario;
            dgvHorarios.Rows[e.RowIndex].Cells[1].Value = horario.horasHorario.hora_inicio;
            dgvHorarios.Rows[e.RowIndex].Cells[2].Value = horario.horasHorario.hora_fin;
            dgvHorarios.Rows[e.RowIndex].Cells[3].Value = horario.dia;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

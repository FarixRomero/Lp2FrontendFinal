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
    public partial class frmRegistroHorario : Form
    {

        private RRHHWS.RRHHWSClient daoRRHHHWS;

        private RRHHWS.horario _horario= null;
        private RRHHWS.semestre _semestre;

        public frmRegistroHorario()
        {
            InitializeComponent();
            dgvMedicos.AutoGenerateColumns = false;
            dgvHorario.AutoGenerateColumns = false;

            daoRRHHHWS = new RRHHWS.RRHHWSClient();
            //Inicializar con datos Horas
           
            lbDia.Items.Add("Lunes");
            lbDia.Items.Add("Martes");
            lbDia.Items.Add("Miercoles");
            lbDia.Items.Add("Jueves");
            lbDia.Items.Add("Viernes");
            lbDia.Items.Add("Sabado");
            _horario = new RRHHWS.horario();    

            RRHHWS.horasHorario[] horas = daoRRHHHWS.listarHorasHorario();
            if (horas != null)
                dgvHorario.DataSource = new BindingList<RRHHWS.horasHorario>(horas.ToList());
            _semestre = daoRRHHHWS.listarSemestreActivo()[0];
            //DateTImeNow :)
            lblSem.Text = _semestre.nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RRHHWS.medico[] medico = daoRRHHHWS.listarTodosMedicos();
            if (medico != null)
                dgvMedicos.DataSource = new BindingList<RRHHWS.medico>(medico.ToList());
         
        }

        private void dgvMedicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RRHHWS.medico med = (RRHHWS.medico)dgvMedicos.Rows[e.RowIndex].DataBoundItem;
            if (med != null)
            {
                dgvMedicos.Rows[e.RowIndex].Cells[0].Value = med.id_medico;
                dgvMedicos.Rows[e.RowIndex].Cells[1].Value = med.nombre + " " + med.apellido;
                dgvMedicos.Rows[e.RowIndex].Cells[2].Value = med.especialidad.nombre;

            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if((dgvMedicos.SelectedRows.Count + dgvHorario.SelectedRows.Count !=2) )
            {
                MessageBox.Show("Debe seleccionar todos los datos", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                _horario.dia = lbDia.Items[lbDia.SelectedIndex].ToString();
                _horario.medico = (RRHHWS.medico)dgvMedicos.CurrentRow.DataBoundItem;
                _horario.horasHorario = (RRHHWS.horasHorario)dgvHorario.CurrentRow.DataBoundItem;
                _horario.semestre = _semestre;
                int resultado = 0;
                resultado = daoRRHHHWS.insertarHorario(_horario);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha creado el horario correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cuenta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }

        }

        private void dgvHorario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RRHHWS.horasHorario horario = (RRHHWS.horasHorario)dgvHorario.Rows[e.RowIndex].DataBoundItem;
            if (horario != null)
            {
                //DateTime dt = DateTime.Parse(horario.hora_inicio.ToString());
                dgvHorario.Rows[e.RowIndex].Cells[0].Value = horario.hora_inicio;
                dgvHorario.Rows[e.RowIndex].Cells[1].Value = horario.hora_fin;
            }
        }
    }
}

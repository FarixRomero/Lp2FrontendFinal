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
    public partial class frmGestionarHorariosMedicos : Form
    {
        private RRHHWS.RRHHWSClient daoRRHHHWS;

        private RRHHWS.horario _horario = null;
        private RRHHWS.semestre _semestre;
        private RRHHWS.horario _horarioSelecionado;

        private PrincipalAdministrador Principal = null;
        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        public frmGestionarHorariosMedicos()
        {
            InitializeComponent();
            daoRRHHHWS = new RRHHWS.RRHHWSClient();
            dgvHorarios.AutoGenerateColumns = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion de Horarios Medicos?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Principal.Show();
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistroHorario horario = new frmRegistroHorario();
            if (horario.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RRHHWS.horario[] horarios = daoRRHHHWS.listarHorarios(txtIngreso.Text);
            if (horarios != null)
                dgvHorarios.DataSource = new BindingList<RRHHWS.horario>(horarios.ToList());
            else
                dgvHorarios.DataSource = new BindingList<RRHHWS.horario>();
        }

        private void dgvHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RRHHWS.horario horario = (RRHHWS.horario)dgvHorarios.Rows[e.RowIndex].DataBoundItem;
            if (horario != null)
            {
                dgvHorarios.Rows[e.RowIndex].Cells[0].Value = horario.medico.nombre + " "+ horario.medico.apellido;
                dgvHorarios.Rows[e.RowIndex].Cells[1].Value = horario.dia;
                dgvHorarios.Rows[e.RowIndex].Cells[2].Value = horario.horasHorario.hora_inicio;
                dgvHorarios.Rows[e.RowIndex].Cells[3].Value = horario.horasHorario.hora_fin;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.CurrentRow != null)
            {
                _horarioSelecionado = (RRHHWS.horario)dgvHorarios.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int resultado = daoRRHHHWS.eliminarHorario(_horarioSelecionado.id_horario);
                    if (resultado != 0)
                    {
                        dgvHorarios.Rows.RemoveAt(dgvHorarios.CurrentRow.Index);
                        MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

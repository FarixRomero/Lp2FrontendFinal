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
    public partial class frmGestionarCitasMedicas : Form
    {
        private PrincipalAdministrador Principal = null;
        private GestionMedicaWS.citaMedica _citaSeleccionada;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        private RRHHWS.administrador _administrador;

        public administrador Administrador { get => _administrador; set => _administrador = value; }

        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        public frmGestionarCitasMedicas()
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            dtgCita.AutoGenerateColumns = false;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _citaSeleccionada = new GestionMedicaWS.citaMedica();
            _citaSeleccionada = (GestionMedicaWS.citaMedica)dtgCita.CurrentRow.DataBoundItem;
            frmCitaMedica formCitaMedica = new frmCitaMedica(_citaSeleccionada);

            if (formCitaMedica.ShowDialog() == DialogResult.OK)
            {
                GestionMedicaWS.citaMedica[] citasMedicas = daoGestionMedica.listarCitaMedica();
                if (citasMedicas != null)
                    dtgCita.DataSource = new BindingList<GestionMedicaWS.citaMedica>(citasMedicas.ToList());

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestionMedicaWS.citaMedica[] citas = daoGestionMedica.listarCitaMedicaXAdmin(_administrador.id_administrador);
            if (citas != null)
                dtgCita.DataSource = new BindingList<GestionMedicaWS.citaMedica>(citas.ToList());
        }

        private void dtgCita_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.citaMedica cit = (GestionMedicaWS.citaMedica)dtgCita.Rows[e.RowIndex].DataBoundItem; 
            if (cit != null)
            {
                dtgCita.Rows[e.RowIndex].Cells[0].Value = cit.horario.medico.id_medico;
                dtgCita.Rows[e.RowIndex].Cells[1].Value = cit.horario.medico.nombre +" "+ cit.horario.medico.apellido;
                dtgCita.Rows[e.RowIndex].Cells[2].Value = cit.id_cita;
                dtgCita.Rows[e.RowIndex].Cells[3].Value = cit.estado;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgCita.CurrentRow != null)
            {
                _citaSeleccionada = (GestionMedicaWS.citaMedica)dtgCita.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar este consultorio",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int resultado = daoGestionMedica.eliminarCitaMedica(_citaSeleccionada);
                    if (resultado != 0)
                    {
                        dtgCita.Rows.RemoveAt(dtgCita.CurrentRow.Index);
                        MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

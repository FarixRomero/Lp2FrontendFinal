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
    public partial class frmMostrarPerfilDoctores : Form
    {
        PrincipalCliente Principal = null;
        private RRHHWS.RRHHWSClient daoMedico;
        private RRHHWS.medico _medicoseleccionado;
        public frmMostrarPerfilDoctores()
        {
            InitializeComponent();
            dgvPerfilDoctores.AutoGenerateColumns = false;
            daoMedico = new RRHHWS.RRHHWSClient();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             
            RRHHWS.medico[] medico = daoMedico.buscarMedicoPorNombre(txtIngreso.Text);
            if (medico != null)
                dgvPerfilDoctores.DataSource = new BindingList<RRHHWS.medico>(medico.ToList());
        }
        public void SetPrincipal(PrincipalCliente paginaContenedora)
        {
            Principal = paginaContenedora;
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (dgvPerfilDoctores.CurrentRow != null)
            {
                _medicoseleccionado = (RRHHWS.medico)dgvPerfilDoctores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                // aqui se selecciona al doctor y se muestra sus datos en una pantalla
                frmOpcionesMedico verMedico = new frmOpcionesMedico(_medicoseleccionado);
                PrincipalCliente auxiliar = Principal;
                verMedico.SetPrincipal(auxiliar);
                frmMostrarPerfilDoctores anterior = new frmMostrarPerfilDoctores();

                verMedico.SetAnterior(anterior);
                auxiliar.abrirFormulario(verMedico);
            }
            else {
                MessageBox.Show("Debe seleccionar un médico", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgvPerfilDoctores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RRHHWS.medico med = (RRHHWS.medico)dgvPerfilDoctores.Rows[e.RowIndex].DataBoundItem;
            if (med != null)
            {
                dgvPerfilDoctores.Rows[e.RowIndex].Cells[0].Value = med.id_medico;
                dgvPerfilDoctores.Rows[e.RowIndex].Cells[1].Value = med.nombre + " " + med.apellido;
                dgvPerfilDoctores.Rows[e.RowIndex].Cells[2].Value = med.especialidad.nombre;

            }
        }
    }
}

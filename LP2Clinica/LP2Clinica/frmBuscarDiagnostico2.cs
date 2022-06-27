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
    public partial class frmBuscarDiagnostico2 : Form
    {
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        private GestionMedicaWS.diagnostico diagnosticoSeleccionado;
        public frmBuscarDiagnostico2()
        {
            InitializeComponent();
            dgvDiagnostico.AutoGenerateColumns = false;
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
        }
        public GestionMedicaWS.diagnostico DiagnosticoSeleccionado { get => diagnosticoSeleccionado; set => diagnosticoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestionMedicaWS.diagnostico[] diagnosticos = daoGestionMedica.listarDiagnosticosPorDNIPaciente(txtDNIPaciente.Text);
            if (diagnosticos != null)
            {
                dgvDiagnostico.DataSource = new BindingList<GestionMedicaWS.diagnostico>(diagnosticos.ToList());
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDiagnostico.CurrentRow != null)
            {
                diagnosticoSeleccionado = (GestionMedicaWS.diagnostico)dgvDiagnostico.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvDiagnostico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.diagnostico diagnostico = (GestionMedicaWS.diagnostico)dgvDiagnostico.Rows[e.RowIndex].DataBoundItem;
            dgvDiagnostico.Rows[e.RowIndex].Cells[0].Value = diagnostico.id_diagnostico;
            dgvDiagnostico.Rows[e.RowIndex].Cells[1].Value = diagnostico.resultado;
            dgvDiagnostico.Rows[e.RowIndex].Cells[2].Value = diagnostico.observacion;
        }
    }
}

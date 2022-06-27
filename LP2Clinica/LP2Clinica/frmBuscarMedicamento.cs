using LP2Clinica.GestionMedicaWS;
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
    public partial class frmBuscarMedicamento : Form
    {
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        private GestionMedicaWS.medicamento medicamentoSeleccionado;

        public GestionMedicaWS.medicamento MedicamentoSeleccionado { get => medicamentoSeleccionado; set => medicamentoSeleccionado = value; }

        public frmBuscarMedicamento()
        {
            InitializeComponent();
            dgvMedicamentos.AutoGenerateColumns = false;
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
        }

        private void dgvMedicamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.medicamento medicamento = (GestionMedicaWS.medicamento)dgvMedicamentos.Rows[e.RowIndex].DataBoundItem;
            dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value = medicamento.id_medicamento;
            dgvMedicamentos.Rows[e.RowIndex].Cells[1].Value = medicamento.codigo;
            dgvMedicamentos.Rows[e.RowIndex].Cells[2].Value = medicamento.nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestionMedicaWS.medicamento[] medicamentos= daoGestionMedica.listarMedicamento(txtIngreso.Text);
            if (medicamentos != null && medicamentos.Length > 0)
            {
                dgvMedicamentos.DataSource = new BindingList<GestionMedicaWS.medicamento>(medicamentos.ToList());
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.CurrentRow != null)
            {
                MedicamentoSeleccionado = (GestionMedicaWS.medicamento)dgvMedicamentos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

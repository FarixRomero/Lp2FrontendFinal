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
    public partial class frmGestionarMedicamentos : Form
    {
        private GestionMedicaWS.GestionMedicaWSClient daoGESTMED;
        private GestionMedicaWS.medicamento _medicamentoSeleccionado;


        private PrincipalAdministrador Principal = null;


        public frmGestionarMedicamentos()
        {
            InitializeComponent();
            dgvMedicamento.AutoGenerateColumns = false;
            daoGESTMED = new GestionMedicaWS.GestionMedicaWSClient();

        }

        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion de Medicamentos?",
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
            // aqui debe llevar a un formulario donde se ingrese un nuevo medicamento?????
            //creo que no pensaron bien en eso xd porque eso es farmacia o idk
            frmRegistrarNuevoMedicamento nuevomedicamento = new frmRegistrarNuevoMedicamento();
            if (nuevomedicamento.ShowDialog() == DialogResult.OK)
            {
                GestionMedicaWS.medicamento[] medicamentos = daoGESTMED.listarMedicamento(txtIngreso.Text);
                if (medicamentos != null)
                    dgvMedicamento.DataSource = new BindingList<GestionMedicaWS.medicamento>(medicamentos.ToList());

            }

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar el medicamento????????????? porque hicimos esto :v
            //igual forma usar la cartilla de medicamento y la opción del seleccionado
            if (dgvMedicamento.CurrentRow != null)
            {
                _medicamentoSeleccionado = (GestionMedicaWS.medicamento)dgvMedicamento.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar a este empleado?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int resultado = daoGESTMED.eliminarMedicamento(_medicamentoSeleccionado);
                    if (resultado != 0)
                    {
                        dgvMedicamento.Rows.RemoveAt(dgvMedicamento.CurrentRow.Index);
                        MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestionMedicaWS.medicamento[] medicamentos = daoGESTMED.listarMedicamento(txtIngreso.Text);
            if (medicamentos != null)
                dgvMedicamento.DataSource = new BindingList<GestionMedicaWS.medicamento>(medicamentos.ToList());

        }

        private void dgvMedicamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.medicamento med = (GestionMedicaWS.medicamento)dgvMedicamento.Rows[e.RowIndex].DataBoundItem;
            if (med != null)
            {
                dgvMedicamento.Rows[e.RowIndex].Cells[0].Value = med.id_medicamento;
                dgvMedicamento.Rows[e.RowIndex].Cells[1].Value = med.codigo;
                dgvMedicamento.Rows[e.RowIndex].Cells[2].Value = med.nombre;

            }

        }
    }
}

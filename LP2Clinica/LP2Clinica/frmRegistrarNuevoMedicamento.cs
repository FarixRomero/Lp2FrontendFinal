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
    public partial class frmRegistrarNuevoMedicamento : Form
    {

        private GestionMedicaWS.GestionMedicaWSClient daoGESTMED;
        private GestionMedicaWS.medicamento _medicamentoAgregado;

        public medicamento MedicamentoAgregado { get => _medicamentoAgregado; set => _medicamentoAgregado = value; }

        public frmRegistrarNuevoMedicamento()
        {
            daoGESTMED = new GestionMedicaWS.GestionMedicaWSClient();
            _medicamentoAgregado = new GestionMedicaWS.medicamento();
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // aqui ingresamos este nuevo medicamento
            MedicamentoAgregado.codigo = txtCodigoMedicamento.Text;
            MedicamentoAgregado.nombre = txtNombreMedicamento.Text;

            int resultado = daoGESTMED.insertarMedicamento(MedicamentoAgregado);
            if(resultado != 0)
            {
                MessageBox.Show("Se ha creado el medicamento correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cancelamos el ingreos de nuevo medicamento
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

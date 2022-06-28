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
    public partial class frmMostrarDiagnostico : Form
    {
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        private PrincipalCliente Principal = null;
        private int _idCita;
        public frmMostrarDiagnostico()
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            //_idCita = 37;
            GestionMedicaWS.diagnostico diagnostico = daoGestionMedica.buscarDiagnosticoPorIdCita(IdCita);
            lblCodigoDiagnostico.Text = diagnostico.id_diagnostico.ToString();
            lblResultadoDiagnostico.Text = diagnostico.resultado;
            lblObservacionDiagnostico.Text = diagnostico.observacion;

            GestionMedicaWS.lineaRecetaMedica[] lrm = daoGestionMedica.buscarRecetaMedicaXIdCita(IdCita);
            dtgRecetaMedicaXDiagnostico.AutoGenerateColumns = false;
            if (lrm != null && lrm.Length > 0)
            {
                dtgRecetaMedicaXDiagnostico.DataSource = 
                    new BindingList<GestionMedicaWS.lineaRecetaMedica>(lrm.ToList());
            }
        }

        public frmMostrarDiagnostico(int _id)
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            _idCita = _id;
            GestionMedicaWS.diagnostico diagnostico = daoGestionMedica.buscarDiagnosticoPorIdCita(IdCita);
            lblCodigoDiagnostico.Text = diagnostico.id_diagnostico.ToString();
            lblResultadoDiagnostico.Text = diagnostico.resultado;
            lblObservacionDiagnostico.Text = diagnostico.observacion;

            GestionMedicaWS.lineaRecetaMedica[] lrm = daoGestionMedica.buscarRecetaMedicaXIdCita(IdCita);
            dtgRecetaMedicaXDiagnostico.AutoGenerateColumns = false;
            if (lrm != null && lrm.Length > 0)
            {
                dtgRecetaMedicaXDiagnostico.DataSource =
                    new BindingList<GestionMedicaWS.lineaRecetaMedica>(lrm.ToList());
            }
        }

        public void SetPrincipal(PrincipalCliente principal)
        {
            Principal = principal;
        }

        public int IdCita { get => _idCita; set => _idCita = value; }

        private void dtgRecetaMedicaXDiagnostico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.lineaRecetaMedica lrm = 
                (GestionMedicaWS.lineaRecetaMedica)
                dtgRecetaMedicaXDiagnostico.Rows[e.RowIndex].DataBoundItem;
            dtgRecetaMedicaXDiagnostico.Rows[e.RowIndex].Cells[0].Value = lrm.medicamento.codigo;
            dtgRecetaMedicaXDiagnostico.Rows[e.RowIndex].Cells[1].Value = lrm.medicamento.nombre;
            dtgRecetaMedicaXDiagnostico.Rows[e.RowIndex].Cells[2].Value = lrm.cantidad;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir del diagnostico?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

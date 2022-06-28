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
    public partial class frmGestionarMedicos : Form
    {
        private RRHHWS.administrador _administrador = null;
        private PrincipalAdministrador Principal = null;

        private RRHHWS.RRHHWSClient daoRRHHHWS;
        private RRHHWS.medico _medseleccionado;


        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        public frmGestionarMedicos()
        {
            InitializeComponent();
            dgvMedicos.AutoGenerateColumns = false;
            daoRRHHHWS = new RRHHWS.RRHHWSClient();
        }
        public frmGestionarMedicos(RRHHWS.administrador admin)
        {
            InitializeComponent();
            dgvMedicos.AutoGenerateColumns = false;
            daoRRHHHWS = new RRHHWS.RRHHWSClient();
            _administrador = admin;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion de Medicos?",
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
            //aqui debe registrarse un nuevo medico
            frmRegistrarNuevoMedico nuevomedico = new frmRegistrarNuevoMedico(_administrador);
            nuevomedico.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // aqui debe ir una pantalla especial para modificar la medico

            RRHHWS.medico _medicoSeleccionado = (RRHHWS.medico)dgvMedicos.CurrentRow.DataBoundItem;

            if(_medicoSeleccionado != null)
            {
                frmAdministrarMedico ad_medico = new frmAdministrarMedico(_medicoSeleccionado);
                ad_medico.ShowDialog();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RRHHWS.medico[] medico= daoRRHHHWS.buscarMedicoPorNombre(txtIngreso.Text);
            if (medico!= null)
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
    }
}

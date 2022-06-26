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
    public partial class frmGestionarConsultorio : Form
    {
        private PrincipalAdministrador Principal = null;
        private RRHHWS.RRHHWSClient daoRRHH;
        private RRHHWS.consultorio _consultorioSeleccionado;

        public RRHHWS.consultorio ConsultorioSeleccionado { get => _consultorioSeleccionado; set => _consultorioSeleccionado = value; }

        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }
        public frmGestionarConsultorio()
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();
            dtgConsultorio.AutoGenerateColumns = false;
            //_consultorioSeleccionado = new RRHHWS.consultorio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de Gestion de Consultorios?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Principal.Show();
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RRHHWS.consultorio[] consultorios = daoRRHH.listarConsultorios();
            if (consultorios != null)
                dtgConsultorio.DataSource = new BindingList<RRHHWS.consultorio>(consultorios.ToList());
        }

        private void dtgConsultorio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RRHHWS.consultorio cons = (RRHHWS.consultorio)dtgConsultorio.Rows[e.RowIndex].DataBoundItem;
            if (cons != null)
            {
                dtgConsultorio.Rows[e.RowIndex].Cells[0].Value = cons.id_consultorio;
                dtgConsultorio.Rows[e.RowIndex].Cells[1].Value = cons.nombre;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgConsultorio.CurrentRow != null)
            {
                _consultorioSeleccionado = (RRHHWS.consultorio)dtgConsultorio.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar este consultorio",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int resultado = daoRRHH.eliminarConsultorio(_consultorioSeleccionado);
                    if (resultado != 0)
                    {
                        dtgConsultorio.Rows.RemoveAt(dtgConsultorio.CurrentRow.Index);
                        MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmRegistrarNuevoConsultorio formRegistrarNuevoConsultorio = new frmRegistrarNuevoConsultorio();

            if (formRegistrarNuevoConsultorio.ShowDialog() == DialogResult.OK)
            {
                RRHHWS.consultorio[] consultorios = daoRRHH.listarConsultorios();
                if (consultorios != null)
                    dtgConsultorio.DataSource = new BindingList<RRHHWS.consultorio>(consultorios.ToList());
            }
        }
    }
}

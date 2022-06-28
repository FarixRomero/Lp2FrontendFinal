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
    public partial class frmBuscarRecetaMedica : Form
    {
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        private GestionMedicaWS.recetaMedica recetaSeleccionado;
        public frmBuscarRecetaMedica()
        {
            InitializeComponent();
            dgvReceta.AutoGenerateColumns = false;
            daoGestionMedica=new GestionMedicaWS.GestionMedicaWSClient();
        }

        public GestionMedicaWS.recetaMedica RecetaSeleccionado { get => recetaSeleccionado; set => recetaSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
            GestionMedicaWS.recetaMedica[] recetas = daoGestionMedica.listarRecetaMedicaXDNIoNombre(txtIngreso.Text);
            if(recetas!=null)
                dgvReceta.DataSource=new BindingList<GestionMedicaWS.recetaMedica>(recetas.ToList());
            

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            if (dgvReceta.CurrentRow != null)
            {
                //recetaSeleccionado = (GestionMedicaWS.recetaMedica)dgvReceta.CurrentRow.DataBoundItem;
                //recetaSeleccionado.lineasRecetaMedica = daoGestionMedica.listarLineasXIdReceta(recetaSeleccionado.idReceta);
                //this.DialogResult = DialogResult.OK;
            }
            
        }

        private void dgvReceta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.recetaMedica receta = (GestionMedicaWS.recetaMedica)dgvReceta.Rows[e.RowIndex].DataBoundItem;
            dgvReceta.Rows[e.RowIndex].Cells[0].Value = receta.idReceta;
            dgvReceta.Rows[e.RowIndex].Cells[1].Value = receta.diagnostico.citaMedica.paciente.nombre + " "+ receta.diagnostico.citaMedica.paciente.apellido;
            dgvReceta.Rows[e.RowIndex].Cells[2].Value = receta.codReceta;
            dgvReceta.Rows[e.RowIndex].Cells[3].Value = receta.diagnostico.resultado;
        }
    }
}

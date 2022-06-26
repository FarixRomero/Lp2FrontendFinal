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
    public partial class modificardatosmedicos : Form
    {
        frmAdministrarMedico _principal = null;
        CartillaInformacion _anterior = null;
        public modificardatosmedicos()
        {
            InitializeComponent();
        }
        public frmAdministrarMedico Principal { get => _principal; set => _principal = value; }
        public CartillaInformacion Anterior  { get => _anterior; set => _anterior = value; }
        private void bnCancelar_Click(object sender, EventArgs e)
        {

            frmAdministrarMedico auxiliar = _principal;
            CartillaInformacion ant = _anterior;
            auxiliar.abrirFormulario(ant);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha modificado los datos correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAdministrarMedico auxiliar = _principal;
            CartillaInformacion ant = _anterior;
            auxiliar.abrirFormulario(ant);
        }
    }
}

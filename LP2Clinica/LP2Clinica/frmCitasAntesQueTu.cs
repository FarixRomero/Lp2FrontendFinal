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
    public partial class frmCitasAntesQueTu : Form
    {
        GestionMedicaWS.citaMedica _cita;
        public frmCitasAntesQueTu()
        {
            InitializeComponent();
        }
        public frmCitasAntesQueTu(GestionMedicaWS.citaMedica cita)
        {
            InitializeComponent();
            _cita = cita; 
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

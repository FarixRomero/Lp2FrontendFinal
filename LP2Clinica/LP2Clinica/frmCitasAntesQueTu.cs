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
        private GestionMedicaWS.GestionMedicaWSClient daoGESTMED;
        private int numero = 0;
        public frmCitasAntesQueTu()
        {
            InitializeComponent();
        }
        public frmCitasAntesQueTu(GestionMedicaWS.citaMedica cita)
        {
            InitializeComponent();
            daoGESTMED = new GestionMedicaWS.GestionMedicaWSClient();
            numero = daoGESTMED.ContarCitasDelante(DateTime.Now.ToString("yyyy-MM-dd"),
                cita.horario.medico.id_medico,cita.horario.id_horario);
            _cita = cita;

            txtLabel.Text = numero.ToString();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

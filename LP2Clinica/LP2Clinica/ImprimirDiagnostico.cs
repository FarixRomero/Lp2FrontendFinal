using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Clinica
{
    public partial class ImprimirDiagnostico : Form
    {
        private PrincipalCliente Principal = null;
        private Byte[] arreglo;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        public ImprimirDiagnostico()
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
        }
        public void SetPrincipal(PrincipalCliente principal)
        {
            Principal = principal;
        }

        private void lblCodigoCita_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            arreglo = daoGestionMedica.generarReporteDiagnostico(Int32.Parse(txtCodigoCita.Text));
            File.WriteAllBytes("temporal.pdf", arreglo);
            visorPDF.LoadFile("temporal.pdf");
            visorPDF.setShowToolbar(true);
        }
    }
}

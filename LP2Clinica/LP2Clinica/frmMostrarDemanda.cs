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
    public partial class frmMostrarDemanda : Form
    {
        PrincipalAdministrador Principal = null;

        private RRHHWS.RRHHWSClient daoRRHH;
        private byte[] reporteBytes;

        public frmMostrarDemanda()
        {
            InitializeComponent();

            daoRRHH = new RRHHWS.RRHHWSClient();

            cbEspecialidad.DataSource = daoRRHH.listarTodosEspecialidades();
            cbEspecialidad.DisplayMember = "nombre";
            cbEspecialidad.ValueMember = "id_especialidad";

            cbEspecialidad.SelectedIndex = -1;

        }
        public void SetPrincipal(PrincipalAdministrador principal)
        {
            Principal = principal;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            reporteBytes = daoRRHH.generarReporteDemanda(Int32.Parse(cbEspecialidad.SelectedValue.ToString()));
            File.WriteAllBytes("ReporteDemanda.pdf", reporteBytes);
            visorPDF.LoadFile("ReporteDemanda.pdf");
            visorPDF.setShowToolbar(true);
            
        }
    }
}

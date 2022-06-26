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
    public partial class frmRegistrarNuevoConsultorio : Form
    {
        private RRHHWS.RRHHWSClient daoRRHH;
        private RRHHWS.consultorio consultorio;
        public frmRegistrarNuevoConsultorio()
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            consultorio = new RRHHWS.consultorio();
            consultorio.nombre = txtNombre.Text;

            int resultado = daoRRHH.insertarConsultorio(consultorio);
            if (resultado == 1)
            {
                MessageBox.Show("Se registro el consultorio de manera correcta",
                    "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Erro al ingresar el dato",
                    "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar inconcluso el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                frmRegistro NuevoRegistro = new frmRegistro();
                NuevoRegistro.Show();
                this.Close();
            }
        }
    }
}

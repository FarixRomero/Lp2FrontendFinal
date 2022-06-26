using LP2Clinica.RRHHWS;
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
    public partial class frmRegistroPaciente : Form
    {
        private GestionMedicaWS.paciente _paciente=null;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;

        public frmRegistroPaciente(GestionMedicaWS.paciente paciente)
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            _paciente = paciente;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtContraseña.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Debe llenar todos los datos", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _paciente.email = txtEmail.Text;
                _paciente.username = txtUsername.Text;
                _paciente.password = txtContraseña.Text;

                if (rbSi.Checked)
                {
                    _paciente.seguro = true;
                }
                else if (rbNO.Checked)
                {
                    _paciente.seguro = false;
                }
                else
                {
                    MessageBox.Show("Debe marcar una opción", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                _paciente.tipoUsuario = 'P';
                int resultado = 0;
                resultado = daoGestionMedica.insertarPaciente(_paciente);
                if (resultado != 0 )
                {
                    MessageBox.Show("Se ha creado la cuenta correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cuenta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
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

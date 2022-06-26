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
    public partial class frmRegistroNuevoPaciente : Form
    {
        private GestionMedicaWS.GestionMedicaWSClient daoGest;
        private GestionMedicaWS.paciente _paciente= null;

        public frmRegistroNuevoPaciente()
        {
            InitializeComponent();
            daoGest = new GestionMedicaWS.GestionMedicaWSClient();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //aqui se ingresa toda la data que se ingreso en el form, en la tabla del paciente
            if (txtApellido.Text == "" || txtDNI.Text == "" || txtEmail.Text == "" || txtNombre.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GestionMedicaWS.paciente paciente = new GestionMedicaWS.paciente();
                paciente.DNI = txtDNI.Text;
                paciente.nombre = txtNombre.Text;
                paciente.apellido = txtApellido.Text;
                paciente.email = txtEmail.Text;
                paciente.username = txtUsername.Text;
                paciente.tipoUsuario = 'P';
                /*POR DEFECTO, LA CONTRASEÑA ES password*/
                paciente.password = "password";
                if (rbSeguroSI.Checked)
                {
                    paciente.seguro = true;
                }
                else if (rbSeguroNo.Checked)
                {
                    paciente.seguro = false;
                }
                else
                {
                    MessageBox.Show("Debe marcar una opción", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                int resultado = daoGest.insertarPaciente(paciente);
                if (resultado == 1)
                {
                    MessageBox.Show("Se ha registrado con exito \n  La contraseña del médico es password", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al momento de ingresar un dato", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
    }
}

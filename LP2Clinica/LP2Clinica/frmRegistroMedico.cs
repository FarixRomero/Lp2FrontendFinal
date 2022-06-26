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
    public partial class frmRegistroMedico : Form
    {
        private RRHHWS.medico _medico=null;
        private RRHHWS.RRHHWSClient daoRRHH;
        
        public frmRegistroMedico(RRHHWS.medico medico)
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();
            cbEspecialidad.DataSource = daoRRHH.listarTodosEspecialidades();
            cbEspecialidad.ValueMember = "id_especialidad";
            cbEspecialidad.DisplayMember = "nombre";
            _medico = medico;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                frmRegistro NuevoRegistro = new frmRegistro();
                NuevoRegistro.Show();
                this.Close();
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtContraseña.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Debe llenar todos los datos", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _medico.email = txtEmail.Text;
                _medico.username = txtUsername.Text;
                _medico.password = txtContraseña.Text;
                _medico.especialidad = (RRHHWS.especialidad)cbEspecialidad.SelectedItem;
                _medico.tipoUsuario = 'M';
                RRHHWS.administrador administrador = new RRHHWS.administrador();
                administrador.id_administrador = int.Parse(txtIDAdmin.Text);
                _medico.administrador = administrador;
                int resultado = 0;
                resultado = daoRRHH.insertarMedico(_medico);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha creado la cuenta correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin logeo = new frmLogin();
                    logeo.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cuenta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
    }
}

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
    public partial class frmRegistrarNuevoMedico : Form
    {
        private RRHHWS.medico _medico;
        private RRHHWS.RRHHWSClient daoRRHH;
        private RRHHWS.administrador _administradorEncargado=null;

        public frmRegistrarNuevoMedico(RRHHWS.administrador administrador)
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();
            _administradorEncargado = administrador;
            cbEspecialidad.DataSource = daoRRHH.listarTodosEspecialidades();
            //cbEspecialidad.ValueMember = "id_especialidad";
            txtIDAdmin.Text = _administradorEncargado.id_administrador.ToString();
            cbEspecialidad.DisplayMember="nombre";
        }
        private void limpiarEspacios()
        {
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtUsername.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                limpiarEspacios();
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtApellido.Text == "" || txtDNI.Text== "" || txtEmail.Text=="" || txtNombre.Text=="" || txtUsername.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje de advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                RRHHWS.medico medico = new RRHHWS.medico();
                medico.DNI = txtDNI.Text;
                medico.nombre = txtNombre.Text;
                medico.apellido = txtApellido.Text;
                medico.email = txtEmail.Text;
                medico.username = txtUsername.Text;
                medico.tipoUsuario = 'M';
                /*POR DEFECTO, LA CONTRASEÑA ES password*/
                medico.password = "password";
                _administradorEncargado.id_administrador = int.Parse(txtIDAdmin.Text);
                medico.especialidad = (RRHHWS.especialidad)cbEspecialidad.SelectedItem;
                medico.administrador = _administradorEncargado;

                int resultado = daoRRHH.insertarMedico(medico);
                if (resultado == 1)
                {
                    MessageBox.Show("Se ha registrado con exito \n  La contraseña del médico es password", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al momento de ingresar un dato","Mensaje de error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                this.Close();
            }
            
        }
    }
}

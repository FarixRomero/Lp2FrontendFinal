/******************************************************************************
                    EQUIPO LOS JAVOS - LENGUAJE DE PROGRAMACIÓN 2
*******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Clinica
{
    public partial class frmLogin : Form
    {
        private RRHHWS.RRHHWSClient daoRRHH;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public frmLogin()
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();
            daoGestionMedica=new GestionMedicaWS.GestionMedicaWSClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            RRHHWS.usuario u = new RRHHWS.usuario();
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            if (txtUsername.Text == "" && txtPassword.Text == "" || txtUsername.Text=="" || txtPassword.Text=="")
            {
                MessageBox.Show("Debe ingresar información válida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                RRHHWS.usuario usuario = new RRHHWS.usuario();
                usuario = daoRRHH.verificarCuentaUsuario(u);

                if (usuario.tipoUsuario == 'P')
                {
                    GestionMedicaWS.paciente paciente = daoGestionMedica.buscarPacientePorIdCuentaUsuario(usuario.id_usuario);
                    PrincipalCliente menuCliente = new PrincipalCliente(paciente);
                    this.Hide();
                    menuCliente.Show();
                    this.Close();
                }
                else if (usuario.tipoUsuario == 'A')
                {
                    RRHHWS.administrador administrador = daoRRHH.buscarAdministradorPorIdCuentaUsuario(usuario.id_usuario);
                    PrincipalAdministrador menuAdministrador = new PrincipalAdministrador(administrador);
                    this.Hide();
                    menuAdministrador.Show();
                    this.Close();
                }
                else if (usuario.tipoUsuario == 'M')
                {
                    RRHHWS.medico medico = daoRRHH.buscarMedicoPorIdCuentaUsuario(usuario.id_usuario);
                    PrincipalMedico menuMedico = new PrincipalMedico(medico);
                    this.Hide();
                    menuMedico.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son correctos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }

                //this.Close();
            }
        }

        private void lblCambiarPassword_Click(object sender, EventArgs e)
        {
            // Provisionalmente pondremos esta pantalla de "modificarContraseña" 
            frmModificarContraseña formModificarContraseña = new frmModificarContraseña();
            formModificarContraseña.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro NuevoRegistro = new frmRegistro();
            NuevoRegistro.Show();
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}

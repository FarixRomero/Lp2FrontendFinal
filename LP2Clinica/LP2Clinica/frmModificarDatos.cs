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
    public partial class frmModificarDatos : Form
    {
        Object Principal = null;
        Form Anterior=null;
        private tipoInicio _TInicio;
        private RRHHWS.usuario usuario;
        private RRHHWS.RRHHWSClient daoRRHH;
        public frmModificarDatos()
        {
            InitializeComponent();
        }
        public frmModificarDatos(RRHHWS.usuario usuario)
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();
            this.usuario = usuario;
        }
        public void SetAnterior(Form paginaAnterior)
        {
           Anterior = paginaAnterior;
        }
        public void SetPrincipal(Object paginaPrincipal)
        {
            Principal = paginaPrincipal;
        }
        public void SetTypeInicio(tipoInicio tipo) { 
            _TInicio = tipo;
        }
        private void btnModificarContra_Click(object sender, EventArgs e)
        {
            frmModificarContraseña actualizarContraseña = new frmModificarContraseña();
            actualizarContraseña.ShowDialog();
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (Anterior != null)
                {
                    switch (_TInicio)
                    {
                        case tipoInicio.Cliente:
                            PrincipalCliente auxiliar = (PrincipalCliente)Principal;
                            frmMostrarPerfil ant = (frmMostrarPerfil)Anterior;
                            ant.SetPrincipal(auxiliar);
                            auxiliar.abrirFormulario(ant);
                            break;
                        case tipoInicio.Administrador:
                            PrincipalAdministrador auxiliarClinica = (PrincipalAdministrador)Principal;
                            frmMostrarPerfil antclinica = (frmMostrarPerfil)Anterior;
                            antclinica.SetPrincipal(auxiliarClinica);
                            auxiliarClinica.abrirFormulario(antclinica);
                            break;
                        case tipoInicio.Medico:
                            PrincipalMedico auxiliarmedico = (PrincipalMedico)Principal;
                            frmMostrarPerfil antmedico = (frmMostrarPerfil)Anterior;
                            antmedico.SetPrincipal(auxiliarmedico);
                            auxiliarmedico.abrirFormulario(antmedico);
                            break;
                    }

                }
                else this.Close();
            }
            
        }
        public void limpiarcomponentes() {
            txtContraseña.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
             // AQUI DEBO BUSCAR LA CUENTA DEL USUARIO PARA PODER COMPARAR LAS CONTRASEÑAS
            RRHHWS.usuario aux = new RRHHWS.usuario();
            aux.username = this.usuario.username;
            aux.password = txtContraseña.Text;
            RRHHWS.usuario confirmacion= daoRRHH.verificarCuentaUsuario(aux);
            if (confirmacion.tipoUsuario =='P'|| confirmacion.tipoUsuario == 'A' || confirmacion.tipoUsuario == 'M')
            {
                if(txtEmail.Text!="") this.usuario.email = txtEmail.Text;
                if (txtUsername.Text != "") this.usuario.username = txtUsername.Text;
                int resultado = 0;
                resultado = daoRRHH.modificarUsuario(this.usuario);
                MessageBox.Show("Se ha modificado los datos correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Debe ingresar su contraseña para configurar sus datos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            limpiarcomponentes();
        }
    }
}

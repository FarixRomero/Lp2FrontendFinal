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
    public partial class PrincipalCliente : Form
    {
        Form formularioActivo = null;
        private bool CerrandoSesion = false;
        private GestionMedicaWS.paciente paciente;
        private GestionMedicaWS.GestionMedicaWSClient daoPaciente;
        public PrincipalCliente()
        {
            InitializeComponent();
            this.Size = new Size(1163, 706);
        }
        public PrincipalCliente(GestionMedicaWS.paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            daoPaciente = new GestionMedicaWS.GestionMedicaWSClient();
            this.Size = new Size(1163, 706);
        }
        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            
            formularioMostrar.Show();
        }


        private void PrincipalCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!CerrandoSesion) Application.ExitThread();
        }

        private void btnModificarCuenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmModificarDatos());
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            frmMostrarPerfilDoctores mostrardoctores = new frmMostrarPerfilDoctores();
            mostrardoctores.SetPrincipal(this);
            abrirFormulario(mostrardoctores);
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            RRHHWS.usuario usuario = new RRHHWS.usuario();
             
            paciente= daoPaciente.buscarPacientePorIdCuentaUsuario(paciente.id_usuario);
            usuario.id_usuario = paciente.id_usuario;
            usuario.nombre = paciente.nombre;
            usuario.apellido = paciente.apellido;
            usuario.DNI = paciente.DNI; 
            usuario.username = paciente.username;
            usuario.email = paciente.email;
            usuario.foto = paciente.foto; 
            usuario.password= paciente.password;
            frmMostrarPerfil mostrarperfil = new frmMostrarPerfil(usuario);
            mostrarperfil.SetPrincipal(this);
            mostrarperfil.SetTypeInicio(tipoInicio.Cliente);
            abrirFormulario(mostrarperfil);
        }

        private void btnReservarCita_Click(object sender, EventArgs e)
        {
            frmRegistrarCitaMedica nuevacita = new frmRegistrarCitaMedica(paciente);
            nuevacita.SetPrincipal(this);
            abrirFormulario(nuevacita);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas salir de tu sesión?",
                "Cerrando Sesion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                CerrandoSesion = true;
                frmInicio comienzo = new frmInicio();
                comienzo.Show();
                comienzo.SetTerminarPrograma(true);
                this.Close();
            }
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            frmCalificaryComentar calificar = new frmCalificaryComentar();
            calificar.SetPrincipal(this);
            abrirFormulario(calificar);
        }

        private void PrincipalCliente_SizeChanged(object sender, EventArgs e)
        {
            panelContenedor.Size = new Size(this.Width, this.Height);
            Menú.Size = new Size(this.Width, this.Height);

        }


        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            ImprimirDiagnostico formImprimirDiagnostico = new ImprimirDiagnostico();
            formImprimirDiagnostico.SetPrincipal(this);
            abrirFormulario(formImprimirDiagnostico);
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            FrmBandejadeEntrada bandeja = new FrmBandejadeEntrada(null, paciente); 
            abrirFormulario(bandeja);
                
        }
    }

}
    


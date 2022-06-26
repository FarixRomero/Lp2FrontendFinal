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
    public partial class PrincipalAdministrador : Form
    {
        Form formularioActivo = null;
        private bool CerrandoSesion = false;
        private RRHHWS.RRHHWSClient daoRRHH;
        private RRHHWS.administrador _administrador;

        public PrincipalAdministrador(RRHHWS.administrador admin)
        {
            InitializeComponent();
            _administrador = admin;
            daoRRHH = new RRHHWS.RRHHWSClient();

        }
        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelvisualizar.Controls.Add(formularioMostrar);
            formularioMostrar.Show();
        }
        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            frmMostrarPerfil mostrarperfil = new frmMostrarPerfil(_administrador);
            mostrarperfil.SetPrincipal(this);
            mostrarperfil.SetTypeInicio(tipoInicio.Administrador);
            abrirFormulario(mostrarperfil);
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

        private void PrincipalClinica_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!CerrandoSesion) Application.ExitThread();
        }

        private void btnAdministrarCitas_Click(object sender, EventArgs e)
        {
            frmGestionarCitasMedicas gestionarcitas= new frmGestionarCitasMedicas();
            gestionarcitas.Administrador = _administrador;
            gestionarcitas.SetPrincipal(this);
            abrirFormulario(gestionarcitas);
        }


        private void btnAdministrarPacientes_Click(object sender, EventArgs e)
        {
            frmGestionarListaPacientes gestionLista= new frmGestionarListaPacientes();
            gestionLista.SetPrincipal(this);
            abrirFormulario(gestionLista);
        }




        private void btnAdministrarMedicos_Click(object sender, EventArgs e)
        {
            //cAMBIO
            frmGestionarMedicos gestionmedicos= new frmGestionarMedicos(_administrador);
            gestionmedicos.SetPrincipal(this);
            abrirFormulario(gestionmedicos);
        }

        private void btnAdministrarConsultorios_Click(object sender, EventArgs e)
        {
            frmGestionarConsultorio gestionconsultorio= new frmGestionarConsultorio();
            gestionconsultorio.SetPrincipal(this);
            abrirFormulario(gestionconsultorio);
        }

        private void btnAdministrarEspecialidades_Click(object sender, EventArgs e)
        {
            frmGestionarEspecialidad gestionarEspecialidad=new frmGestionarEspecialidad();  
            gestionarEspecialidad.SetPrincipal(this);
            abrirFormulario(gestionarEspecialidad);
        }

        private void btnAdministrarHorariosMedicos_Click(object sender, EventArgs e)
        {
            frmGestionarHorariosMedicos gestionarHorariosMedicos= new frmGestionarHorariosMedicos();
            gestionarHorariosMedicos.SetPrincipal(this);    
            abrirFormulario(gestionarHorariosMedicos);
        }

        private void btnAdministrarMedicamentos_Click(object sender, EventArgs e)
        {
            frmGestionarMedicamentos gestionarMedicamentos=new frmGestionarMedicamentos();   
            gestionarMedicamentos.SetPrincipal(this);
            abrirFormulario(gestionarMedicamentos);
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            frmGestionarUsuarios gestionarUsuarios=new frmGestionarUsuarios(_administrador);
            //gestionarUsuarios.Administrador = _administrador;
            gestionarUsuarios.SetPrincipal(this);
            abrirFormulario(gestionarUsuarios);
        }

        private void btnMostrarDemanda_Click(object sender, EventArgs e)
        {
            frmMostrarDemanda demandaHorarios = new frmMostrarDemanda();
            demandaHorarios.SetPrincipal(this);
            abrirFormulario(demandaHorarios);
        }

        private void PrincipalAdministrador_SizeChanged(object sender, EventArgs e)
        {
            panelvisualizar.Size = new Size(this.Width, this.Height);
            Menú.Size = new Size(this.Width, this.Height);
        }
    }
}

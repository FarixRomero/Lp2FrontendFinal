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
    public partial class PrincipalMedico : Form
    {
        Form formularioActivo = null;
        private bool CerrandoSesion = false;
        private RRHHWS.medico medico;
        public PrincipalMedico()
        {
            InitializeComponent();
        }
        public PrincipalMedico(RRHHWS.medico medico)
        {
            InitializeComponent();
            this.medico = medico;
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
        private void btnBuscarDiagnostico_Click(object sender, EventArgs e)
        {
            frmBuscarDiagnostico busquedadiagnostico = new frmBuscarDiagnostico();
            abrirFormulario(busquedadiagnostico);
        }

      

        private void btnVerCitas_Click(object sender, EventArgs e)
        {

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

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            frmMostrarPerfil mostrarperfil = new frmMostrarPerfil(medico);
            mostrarperfil.SetPrincipal(this);
            mostrarperfil.SetTypeInicio(tipoInicio.Medico);
            abrirFormulario(mostrarperfil);
        }

        private void btnGenerarDiagnostico_Click(object sender, EventArgs e)
        {
            frmGenerarDiagnostico nuevodiagnostico = new frmGenerarDiagnostico();
            nuevodiagnostico.SetPrincipal(this);
            abrirFormulario(nuevodiagnostico);
        }

        private void PrincipalMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!CerrandoSesion) Application.ExitThread();
        }

        private void btnRegistroRecetaMedica_Click(object sender, EventArgs e)
        {
            frmRegistroRecetaMedica recetaMedica = new frmRegistroRecetaMedica();
            abrirFormulario(recetaMedica);
        }
    }
}

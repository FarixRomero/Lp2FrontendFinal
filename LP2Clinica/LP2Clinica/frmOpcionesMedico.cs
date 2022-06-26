using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Clinica
{
    public partial class frmOpcionesMedico : Form
    {
        PrincipalCliente Principal= null;
        Form Anterior = null;
        private RRHHWS.medico _medico;
        public frmOpcionesMedico()
        {
            InitializeComponent();
        }
        public frmOpcionesMedico(RRHHWS.medico medico)
        {
            InitializeComponent();
            _medico = medico;
            lblNombreCompleto.Text = medico.nombre + " " + medico.apellido;
            lblEspecialidad.Text = medico.especialidad.nombre;
            lblDNI.Text = medico.DNI;
            
            if (medico.foto.Length != 0) {
                MemoryStream ms = new MemoryStream(medico.foto);
                pbFoto.Image = new Bitmap(ms);// mostrará la foto
            }
        }
        public void SetPrincipal(PrincipalCliente paginaContenedora)
        {
            Principal = paginaContenedora;
        }
        public void SetAnterior(Form paginaAnterior)
        {
            Anterior = paginaAnterior;
        }
        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            PrincipalCliente auxiliar = Principal;
            frmRegistrarCitaMedica registrarcita= new frmRegistrarCitaMedica();
            //aqui se debe pasar los datos del medico seleccionado
            registrarcita.SetPrincipal(auxiliar);
            auxiliar.abrirFormulario(registrarcita);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (Anterior != null)
                {
                    PrincipalCliente auxiliar =  Principal;
                    frmMostrarPerfilDoctores ant = (frmMostrarPerfilDoctores)Anterior;
                    ant.SetPrincipal(auxiliar);
                    auxiliar.abrirFormulario(ant);
                }
                else this.Close();
            }
        }
    }
}

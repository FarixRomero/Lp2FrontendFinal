/******************************************************************************
                    EQUIPO LOS JAVOS - LENGUAJE DE PROGRAMACIÓN 2
*******************************************************************************/
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
    public partial class frmRegistro : Form
    {
        private Estado estado;
        private String ruta="";
        private bool terminarPrograma=false;
        private RRHHWS.usuario usuario;
        public frmRegistro()
        {
            InitializeComponent();
            dtpFechaNacimiento.Value = DateTime.Now;
            usuario = new RRHHWS.usuario();


        }

        public void SetTerminarPrograma(bool siono)
        {
            terminarPrograma = siono;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            SetTerminarPrograma(false);
            if (rbAdministrador.Checked || rbMedico.Checked )
            {   
                
                frmCodigoDeVerificacionRegistro verificarcodigo = new frmCodigoDeVerificacionRegistro();
                verificarcodigo.ShowDialog();

                if (rbAdministrador.Checked && verificarcodigo.pasarsiguiente) {
                    RRHHWS.administrador administrador = new RRHHWS.administrador();
                    administrador.DNI=txtDNI.Text;
                    administrador.nombre = txtNombre.Text;
                    administrador.apellido = txtApellido.Text;
                    administrador.fecha_nacimiento = dtpFechaNacimiento.Value;
                    administrador.fecha_nacimientoSpecified = true;
                    administrador.foto = usuario.foto;
                    frmRegistroAdministrador formRegistroAdministrador = new frmRegistroAdministrador(administrador);
                    formRegistroAdministrador.Show();
                    this.Close(); 
                }
                else if (rbMedico.Checked && verificarcodigo.pasarsiguiente)
                {
                    RRHHWS.medico medico = new RRHHWS.medico();
                    medico.DNI = txtDNI.Text;
                    medico.nombre = txtNombre.Text;
                    medico.apellido = txtApellido.Text;
                    medico.fecha_nacimiento = dtpFechaNacimiento.Value;
                    medico.fecha_nacimientoSpecified = true;
                    medico.foto= usuario.foto;
                    frmRegistroMedico formRegistroMedico = new frmRegistroMedico(medico);
                    formRegistroMedico.Show();
                    this.Close(); 
                }
                
            }
            else if (rbPaciente.Checked)
            {
                GestionMedicaWS.paciente paciente=new GestionMedicaWS.paciente();
                paciente.DNI = txtDNI.Text;
                paciente.nombre = txtNombre.Text;  
                paciente.apellido= txtApellido.Text;
                paciente.fecha_nacimiento= dtpFechaNacimiento.Value;
                paciente.fecha_nacimientoSpecified= true;
                paciente.foto= usuario.foto; 
                frmRegistroPaciente formRegistroPaciente = new frmRegistroPaciente(paciente);
                formRegistroPaciente.Show();

                this.Close(); 

            }
            else {
                MessageBox.Show("Señale el tipo de usuario", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            SetTerminarPrograma(false);
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                frmInicio comienzo = new frmInicio();
                comienzo.Show();
                comienzo.SetTerminarPrograma(true);
                this.Close();
            }
            
        }

        private void frmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (terminarPrograma)
            {
                Application.ExitThread();
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(ruta); // cargar la foto en la pantalla
                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    usuario.foto = br.ReadBytes((int)fs.Length); // convertir la foto en bits 
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}

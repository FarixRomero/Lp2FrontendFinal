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
    public partial class frmMostrarPerfil : Form
    {
        Object Principal = null;
        private tipoInicio _TInicio;
        private RRHHWS.usuario _usuario;

        private RRHHWS.RRHHWSClient daoRRHH;
        private String ruta = "";
        public frmMostrarPerfil()
        {
            InitializeComponent(); 

        }
        public frmMostrarPerfil(RRHHWS.usuario usuario)
        {
            InitializeComponent();
            this._usuario = usuario ;
            if (usuario.foto.Length != 0)
            {
                MemoryStream ms = new MemoryStream(usuario.foto);
                pbFoto.Image = new Bitmap(ms);// mostrará la foto
            }
            lblNombreCompleto.Text = usuario.nombre + " " + usuario.apellido;
            lblDNI.Text = usuario.DNI;
            lblEmail.Text = usuario.email;
            lblUserName.Text = usuario.username;
            daoRRHH = new RRHHWS.RRHHWSClient();
        }
        public void SetTypeInicio(tipoInicio tipo)
        {
            _TInicio = tipo;
        }
        public void SetPrincipal(Object paginaContenedora)
        {
            Principal = paginaContenedora;
        }
        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            // MODIFICANDO DATOS
            frmModificarDatos modificarDatos = new frmModificarDatos(_usuario);

            if (_TInicio == tipoInicio.Cliente)
            {
                PrincipalCliente auxiliar = (PrincipalCliente)Principal;
                modificarDatos.SetPrincipal(auxiliar);
                frmMostrarPerfil anterior = new frmMostrarPerfil(_usuario);
                anterior.SetTypeInicio(tipoInicio.Cliente);
                modificarDatos.SetAnterior(anterior);
                modificarDatos.SetTypeInicio(tipoInicio.Cliente);
                auxiliar.abrirFormulario(modificarDatos);

            }
            else if (_TInicio == tipoInicio.Administrador)
            {
                PrincipalAdministrador auxiliarclinica = (PrincipalAdministrador)Principal;
                modificarDatos.SetPrincipal(auxiliarclinica); //modificar con objetc
                frmMostrarPerfil anterior = new frmMostrarPerfil(_usuario);
                anterior.SetTypeInicio(tipoInicio.Administrador);
                modificarDatos.SetAnterior(anterior);
                modificarDatos.SetTypeInicio(tipoInicio.Administrador);
                auxiliarclinica.abrirFormulario(modificarDatos);

            }
            else if (_TInicio == tipoInicio.Medico)
            {
                PrincipalMedico auxiliar = (PrincipalMedico)Principal;
                modificarDatos.SetPrincipal(auxiliar); //modificar con objetc
                frmMostrarPerfil anterior = new frmMostrarPerfil(_usuario);
                anterior.SetTypeInicio(tipoInicio.Medico);
                modificarDatos.SetAnterior(anterior);
                modificarDatos.SetTypeInicio(tipoInicio.Medico);
                auxiliar.abrirFormulario(modificarDatos);

            }
        }

        private void btnModificarContra_Click(object sender, EventArgs e)
        {
            frmModificarContraseña actualizarContraseña = new frmModificarContraseña();
            actualizarContraseña.ShowDialog();

        }


        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    
                    ruta = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _usuario.foto = br.ReadBytes((int)fs.Length);
                     
                    fs.Close();
                    // aqui debo llamar al procedure de modificar ususuario y pasarle exactamente la misma data
                    int resultado = 0; 
                    resultado = daoRRHH.modificarUsuario(_usuario);
                    
                    if (resultado != 0) {
                        MessageBox.Show("Se ha modificado la foto correctamente  "+_usuario.username , "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
    }
}

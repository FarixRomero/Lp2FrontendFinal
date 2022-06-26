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
    public partial class frmIngresarNuevaContraseña : Form
    {
        private bool _contraseñavalida=false;
        private RRHHWS.RRHHWSClient daoRRHH;

        public frmIngresarNuevaContraseña()
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();

        }
        public bool Contraseñavalida { get => _contraseñavalida; set => _contraseñavalida = value; }
        public bool verificaringreso(string correo)
        {
            _contraseñavalida = false;
            if (txtContraseñaNueva.Text !="" && txtContraseñaConfirmada.Text !="")
            { //aqui debe validarse el ingreso de la contraseña
                RRHHWS.usuario user= new RRHHWS.usuario();
                user.email = correo;
                user.password = txtContraseñaNueva.Text;
                if(daoRRHH.modificarPassword(user)==1)
                _contraseñavalida= true;
            }
            else  _contraseñavalida = false;
            return _contraseñavalida;
        }
    }
}

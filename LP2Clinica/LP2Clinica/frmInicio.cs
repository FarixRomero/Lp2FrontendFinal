/******************************************************************************
                    EQUIPO LOS JAVOS - LENGUAJE DE PROGRAMACIÓN 2
*******************************************************************************/
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
    public partial class frmInicio : Form
    {
        private bool terminarPrograma= false;
        public frmInicio()
        {
            InitializeComponent();
        }
        public void SetTerminarPrograma(bool siono) { 
            terminarPrograma = siono;
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro formRegistro = new frmRegistro();
            formRegistro.SetTerminarPrograma(true);
            formRegistro.Show();
            SetTerminarPrograma(false);
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            SetTerminarPrograma(false);
            this.Close();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (terminarPrograma)
            {
                Application.ExitThread();
            }
        }
    }
}

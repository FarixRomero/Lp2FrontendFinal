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
    public partial class frmCalificaryComentar : Form
    {
        private PrincipalCliente Principal = null;
        private RRHHWS.medico _medicoSeleccionado;
        private RRHHWS.RRHHWSClient daoRRHH;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        private GestionMedicaWS.medico _medicoGestion;
        public frmCalificaryComentar()
        {
            InitializeComponent();
            daoRRHH = new RRHHWS.RRHHWSClient();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            _medicoSeleccionado = new RRHHWS.medico();
        }
        public void SetPrincipal(PrincipalCliente principal)
        {
            Principal = principal;
        }
        public void limpiarcomponentes()
        {
            txtCodigoCita.Text = " ";
            txtComentario.Text = " ";
            rbPuntaje1.Checked = false;
            rbPuntaje2.Checked = false;
            rbPuntaje3.Checked = false;
            rbPuntaje4.Checked = false;
            rbPuntaje5.Checked = false;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCita.Text == "")
            {
                MessageBox.Show("Debe ingresar el código de su cita", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double puntuacion = 0;
                //Ingreso de la calificacion
                if (rbPuntaje1.Checked == true) puntuacion = 1;
                else if (rbPuntaje2.Checked == true) puntuacion = 2;
                else if (rbPuntaje3.Checked == true) puntuacion = 3;
                else if (rbPuntaje4.Checked == true) puntuacion = 4;
                else puntuacion = 5;

                _medicoGestion.cant_pacientes = _medicoGestion.cant_pacientes + 1;
                _medicoGestion.calificacion = (_medicoGestion.calificacion*_medicoGestion.cant_pacientes + puntuacion) / _medicoGestion.cant_pacientes;

                
                int resultado = daoGestionMedica.modificarMedico(_medicoGestion);
                if (resultado == 1)
                {
                    //Se ingresa el comentario
                    GestionMedicaWS.comentario comentario = new GestionMedicaWS.comentario();
                    comentario.descripcion = txtComentario.Text;
                    comentario.medico = _medicoGestion;
                    comentario.fecha_comentario = DateTime.Today;
                    comentario.fecha_comentarioSpecified = true;
                    resultado = daoGestionMedica.insertarComentario(comentario);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Se ha registrado la calificacion y el comentario correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarcomponentes();
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpiarcomponentes();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarcomponentes();
                }

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el comentario?",
               "Mensaje de Confirmación", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Principal.Show();
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCodigoCita.Text);
            //_medicoSeleccionado = daoRRHH.buscarMedicoPorIdCuentaUsuario(id);
            _medicoGestion = daoGestionMedica.buscarMedicoPorIdCuentaUsuario(210);
            lblNombreCompletoResultado.Text = _medicoSeleccionado.nombre + " " + _medicoSeleccionado.apellido;
            //lblEspecialidadResultado.Text = _medicoSeleccionado.especialidad.nombre;
        }
    }
}

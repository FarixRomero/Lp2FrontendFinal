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
    public partial class FrmBandejadeEntrada : Form
    {

        private RRHHWS.medico _medico = null;
        private GestionMedicaWS.paciente _paciente = null;
        GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        RRHHWS.RRHHWSClient daoRRHHWS;
        private int activar = 0;
        public FrmBandejadeEntrada()
        {
            InitializeComponent();
        }
        public FrmBandejadeEntrada(RRHHWS.medico medico, GestionMedicaWS.paciente paciente)
        {
            InitializeComponent();
            dgvBandeja.AutoGenerateColumns = false;
            daoRRHHWS = new RRHHWS.RRHHWSClient();
            RRHHWS.usuario[] bandeja = null;// aqui debo listar los usuarios con conversa antendido;
            if (paciente != null)
            {
                _paciente = paciente;
                // aqui debo listar los usuarios con conversa antendido;

            }

            if (medico != null)
            {
                _medico = medico;
                // aqui debo listar los usuarios con conversa antendido;
                bandeja = daoRRHHWS.listarBandejaDeMedico(_medico.id_medico);

            }
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();

            if (bandeja != null)
            {
                dgvBandeja.DataSource = new BindingList<RRHHWS.usuario>(bandeja.ToList());
                dgvBandeja.CurrentCell = null;
            }
        }


        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            // aqui se carga en la tabla de chats un nuevo mensaje 
            if (txtMensaje.Text != "")
            {
                GestionMedicaWS.chat nuevomensaje = new GestionMedicaWS.chat();
                nuevomensaje.comentario = txtMensaje.Text;
                if (_medico != null)
                {
                    nuevomensaje.emisor = _medico.id_usuario;
                    GestionMedicaWS.paciente contacto = new GestionMedicaWS.paciente();
                    RRHHWS.usuario aux = new RRHHWS.usuario();
                    aux = (RRHHWS.usuario)dgvBandeja.CurrentRow.DataBoundItem;
                    contacto = daoGestionMedica.buscarPacientePorIdCuentaUsuario(aux.id_usuario);
                    nuevomensaje.paciente = new GestionMedicaWS.paciente();
                    nuevomensaje.paciente.id_paciente = contacto.id_paciente;
                    nuevomensaje.paciente.foto = contacto.foto;
                    nuevomensaje.paciente.nombre = contacto.nombre;
                    nuevomensaje.paciente.apellido = contacto.apellido;
                    nuevomensaje.paciente.username = contacto.username;

                    nuevomensaje.medico = new GestionMedicaWS.medico();
                    nuevomensaje.medico.foto = _medico.foto;
                    nuevomensaje.medico.id_medico = _medico.id_medico;
                    nuevomensaje.medico.nombre = _medico.nombre;
                    nuevomensaje.medico.apellido = _medico.apellido;
                    nuevomensaje.medico.username = _medico.username;

                }
                if (_paciente != null)
                {
                    nuevomensaje.emisor = _paciente.id_usuario;
                    // aqui debo asignar el contacto al usuario seleccionado del grid 
                    GestionMedicaWS.medico contacto = new GestionMedicaWS.medico();
                    RRHHWS.usuario aux = new RRHHWS.usuario();
                    aux = (RRHHWS.usuario)dgvBandeja.CurrentRow.DataBoundItem;
                    contacto = daoGestionMedica.buscarMedicoPorIdCuentaUsuario(aux.id_usuario);

                    GestionMedicaWS.medico contacto_ = new GestionMedicaWS.medico();
                    nuevomensaje.medico.id_medico = contacto_.id_medico;
                    nuevomensaje.medico.foto = contacto_.foto;
                    nuevomensaje.medico.nombre = contacto_.nombre;
                    nuevomensaje.medico.apellido = contacto_.apellido;
                    nuevomensaje.medico.username = contacto_.username;

                    nuevomensaje.paciente.foto = _paciente.foto;
                    nuevomensaje.paciente.id_paciente = _paciente.id_paciente;
                    nuevomensaje.paciente.nombre = _paciente.nombre;
                    nuevomensaje.paciente.apellido = _paciente.apellido;
                    nuevomensaje.paciente.username = _paciente.username;

                }
                nuevomensaje.fecha = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                PanelChatFlow.Controls.Add(new Label()
                {
                    Text = nuevomensaje.comentario + " \n  \t" + "Enviado el " + nuevomensaje.fecha + " \n",
                    AutoSize = true,
                    BackColor = Color.WhiteSmoke
                });

                daoGestionMedica.insertarChat(nuevomensaje);

            }
        }

        private void dgvBandeja_SelectionChanged(object sender, EventArgs e)
        {
            if (activar != 0)
            {
                int idUsuario = -1;
                GestionMedicaWS.chat[] mensajes = null;
                if (_medico != null)
                {
                    GestionMedicaWS.paciente contacto = new GestionMedicaWS.paciente();
                    RRHHWS.usuario aux = new RRHHWS.usuario();
                    aux = (RRHHWS.usuario)dgvBandeja.CurrentRow.DataBoundItem;
                    contacto = daoGestionMedica.buscarPacientePorIdCuentaUsuario(aux.id_usuario);
                    mensajes = daoGestionMedica.listarChats(_medico.id_medico, contacto.id_paciente);
                    idUsuario = _medico.id_usuario;
                }
                if (_paciente != null)
                {
                    GestionMedicaWS.medico contacto = new GestionMedicaWS.medico();
                    RRHHWS.usuario aux = new RRHHWS.usuario();
                    aux = (RRHHWS.usuario)dgvBandeja.CurrentRow.DataBoundItem;
                    contacto = daoGestionMedica.buscarMedicoPorIdCuentaUsuario(aux.id_usuario);
                    mensajes = daoGestionMedica.listarChats(contacto.id_medico, _paciente.id_paciente);
                    idUsuario = _paciente.id_usuario;
                }
                if (mensajes != null)
                {
                    foreach (GestionMedicaWS.chat mensaje in mensajes)
                    {
                        if (mensaje.emisor == idUsuario)
                        {
                            PanelChatFlow.Controls.Add(new Label()
                            {
                                Text = mensaje.comentario + " \n  \t" + "Enviado el " + mensaje.fecha + " \n",
                                AutoSize = true,
                                BackColor = Color.WhiteSmoke
                            });
                        }
                        else
                        {
                            PanelChatFlow.Controls.Add(new Label()
                            {
                                Text = mensaje.comentario + "  \n \t" + "Enviado el " + mensaje.fecha + " \n",
                                AutoSize = true,
                                BackColor = Color.PaleTurquoise
                            });
                        }
                    }
                }
                PanelChatFlow.FlowDirection = FlowDirection.TopDown;


            }
            activar = 1;
        }

        private void dgvBandeja_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RRHHWS.usuario bandeja = (RRHHWS.usuario)dgvBandeja.Rows[e.RowIndex].DataBoundItem;
            if (bandeja != null)
            {
                //dgvBandeja.Rows[e.RowIndex].Cells[0].Value = bandeja.foto;
                //dgvBandeja.Rows[e.RowIndex].Cells[1].Value = bandeja.nombre + " " + bandeja.apellido;
                dgvBandeja.Rows[e.RowIndex].Cells[0].Value = bandeja.nombre + " " + bandeja.apellido;

                activar = 0;
            }
        }

        private void dgvBandeja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

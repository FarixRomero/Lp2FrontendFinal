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
    public partial class frmRegistrarCitaMedica : Form
    {
        private PrincipalCliente Principal = null;
        private RRHHWS.RRHHWSClient daoRRHH;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;

        private RRHHWS.especialidad _especialidadSeleccionada;
        private RRHHWS.medico _medSelc;
        private GestionMedicaWS.citaMedica _citaMed;
        private GestionMedicaWS.paciente paciente;


        private BindingList<DateTime> dateTimes;
        public frmRegistrarCitaMedica(GestionMedicaWS.paciente paciente = null)
        {
            InitializeComponent();
            this.paciente = paciente;
            daoRRHH = new RRHHWS.RRHHWSClient();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            cbEspecialidad.DataSource = daoRRHH.listarTodosEspecialidades();
            cbEspecialidad.ValueMember = "id_especialidad";
            cbEspecialidad.DisplayMember = "nombre";

            cbDias.Items.Add("Lunes");
            cbDias.Items.Add("Martes");
            cbDias.Items.Add("Miercoles");
            cbDias.Items.Add("Jueves");
            cbDias.Items.Add("Viernes");
            cbDias.Items.Add("Sabado");
            //Test


            _citaMed = new GestionMedicaWS.citaMedica();
            dgvMedicos.AutoGenerateColumns = false;
            dgvHora.AutoGenerateColumns = false;

        }
        public static BindingList<DateTime> GetAllDayOfWeekPerMonth(int month, int year, DayOfWeek dayOfWeek)
        {
            var date =  DateTime.Today;

            if (date.DayOfWeek != dayOfWeek)
            {
                int daysUntilDayOfWeek = ((int)dayOfWeek - (int)date.DayOfWeek + 7) % 7;
                date = date.AddDays(daysUntilDayOfWeek);
            }

            BindingList<DateTime> days = new BindingList<DateTime>();

            while (date.Month == month)
            {
                days.Add(date);
                date = date.AddDays(7);
            }

            return days;
        }

        public void SetPrincipal(PrincipalCliente principal) {
            Principal = principal; 
        }
        public void limpiarcomponentes() {
            txtSeleccionar.Text = " ";
            /*Aqui se limpia todo los datos */
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ((dgvMedicos.SelectedRows.Count !=1 ||  dgvFechas.SelectedRows.Count !=1 || dgvHora.SelectedRows.Count != 1))
            {
                MessageBox.Show("Debe seleccionar todos los datos", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                _citaMed.horario = (GestionMedicaWS.horario)dgvHora.CurrentRow.DataBoundItem;
                _citaMed.fecha = (DateTime)dgvFechas.CurrentRow.DataBoundItem;
                _citaMed.fechaSpecified = true;
                _citaMed.paciente = paciente;
                _citaMed.estado = "RESERVADO";
                _citaMed.consultorio=daoGestionMedica.listarConsultorios()[0];
                
                int resultado = 0;  
                resultado = daoGestionMedica.insertarCitaMedica(_citaMed);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha creado el horario correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la cuenta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

        }

        limpiarcomponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que deseas dejar incompleto el registro de cita?",
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
            _especialidadSeleccionada = (RRHHWS.especialidad)cbEspecialidad.SelectedItem;
            RRHHWS.medico[] medico = daoRRHH.buscarMedicoPorNombreYIdEspecialidad(_especialidadSeleccionada.id_especialidad, txtSeleccionar.Text);
            if (medico != null)
                dgvMedicos.DataSource = new BindingList<RRHHWS.medico>(medico.ToList());
            else
                dgvMedicos.DataSource = new BindingList<RRHHWS.medico>();

        }

        private void dgvMedicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RRHHWS.medico med = (RRHHWS.medico)dgvMedicos.Rows[e.RowIndex].DataBoundItem;
            if (med != null)
            {
                dgvMedicos.Rows[e.RowIndex].Cells[0].Value = med.id_medico;
                dgvMedicos.Rows[e.RowIndex].Cells[1].Value = med.nombre + " " + med.apellido;

            }
        }
        
        //Seleccionar
        private void button1_Click(object sender, EventArgs e)
        {
            if ((dgvMedicos.SelectedRows.Count != 1 || cbDias.SelectedIndex==-1))
            {
                MessageBox.Show("Debe seleccionar Medico y Día", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String dia = cbDias.Items[cbDias.SelectedIndex].ToString();
                _medSelc = (RRHHWS.medico)dgvMedicos.CurrentRow.DataBoundItem;
                GestionMedicaWS.horario[] horarios = daoGestionMedica.listarHorariosXMedicoYDia(_medSelc.id_medico, dia);
                if (horarios != null)
                    dgvHora.DataSource = new BindingList<GestionMedicaWS.horario>(horarios.ToList());
                else
                    dgvHora.DataSource = new BindingList<GestionMedicaWS.horario>();

                DayOfWeek day = DayOfWeek.Monday;
                if (dia == "Lunes") day = DayOfWeek.Monday;
                else if (dia == "Martes") day = DayOfWeek.Tuesday;
                else if (dia == "Miercoles") day = DayOfWeek.Wednesday;
                else if (dia == "Jueves") day = DayOfWeek.Thursday;
                else if (dia == "Viernes") day = DayOfWeek.Friday;
                else if (dia == "Sabado") day = DayOfWeek.Saturday;


                dateTimes = GetAllDayOfWeekPerMonth(Int32.Parse(DateTime.Now.Month.ToString()), 2022, day);
                dgvFechas.DataSource = dateTimes;

            }
       

        }

        private void dgvHora_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.horario horario = (GestionMedicaWS.horario)dgvHora.Rows[e.RowIndex].DataBoundItem;
            if (horario != null)
            {
                dgvHora.Rows[e.RowIndex].Cells[0].Value = horario.horasHorario.hora_inicio;
                dgvHora.Rows[e.RowIndex].Cells[1].Value = horario.horasHorario.hora_fin;

            }

        }

        private void dgvFechas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //DateTime horario = (DateTime)dgvFechas.Rows[e.RowIndex].DataBoundItem;
            //if (horario != null)
            //{
            //    dgvFechas.Rows[e.RowIndex].Cells[0].Value = horario.Date.ToString();
            //}
        }
    }
}

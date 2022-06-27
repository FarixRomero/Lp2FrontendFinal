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
        private String diaSeleccionado;

        private BindingList<String> dateTimes;
        private BindingList<GestionMedicaWS.horario> horariosXDia;

        public frmRegistrarCitaMedica(GestionMedicaWS.paciente paciente = null)
        {
            InitializeComponent();
            this.paciente = paciente;
            daoRRHH = new RRHHWS.RRHHWSClient();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            cbEspecialidad.DataSource = daoRRHH.listarTodosEspecialidades();
            cbEspecialidad.ValueMember = "id_especialidad";
            cbEspecialidad.DisplayMember = "nombre";

  
            //Test


            _citaMed = new GestionMedicaWS.citaMedica();
            dgvMedicos.AutoGenerateColumns = false;
            dgvHora.AutoGenerateColumns = false;
            //dgvFechas.AutoGenerateColumns = false;


        }
        public static BindingList<String> GetAllDayOfWeekPerMonth(int month, int year, DayOfWeek dayOfWeek)
        {
            var date =  DateTime.Today;

            if (date.DayOfWeek != dayOfWeek)
            {
                int daysUntilDayOfWeek = ((int)dayOfWeek - (int)date.DayOfWeek + 7) % 7;
                date = date.AddDays(daysUntilDayOfWeek);
            }

            BindingList<String> days = new BindingList<String>();

            while (date.Month < month+2)
            {
                days.Add(date.ToString("dd/MM/yyyy"));
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
            if ((dgvMedicos.SelectedRows.Count !=1 ||  dgvHora.SelectedRows.Count != 1 ))
            {
                MessageBox.Show("Debe seleccionar todos los datos", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                _citaMed.horario = (GestionMedicaWS.horario)dgvHora.CurrentRow.DataBoundItem;
                _citaMed.fecha = DateTime.ParseExact((String)cbFecha.SelectedItem, "dd/MM/yyyy", null);
                _citaMed.fechaSpecified = true;
                _citaMed.paciente = paciente;
                _citaMed.estado = "RESERVADO";
                _citaMed.consultorio=daoGestionMedica.listarConsultorios()[0];
                
                int resultado = 0;  
                resultado = daoGestionMedica.insertarCitaMedica(_citaMed);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha creado la cita correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvFechas.DataSource = null;
                    dgvHora.DataSource = null;
                    horariosXDia = new BindingList<GestionMedicaWS.horario>();
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
            if ((dgvMedicos.SelectedRows.Count != 1))
            {
                MessageBox.Show("Debe seleccionar Medico", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                cbDias.Items.Clear();
                string[] diasMed = daoRRHH.listarDiasxIdMedico(((RRHHWS.medico)dgvMedicos.CurrentRow.DataBoundItem).id_medico);
                if (diasMed != null)
                {
                    foreach (string horario in diasMed)
                    {
                        cbDias.Items.Add(horario);

                    }
                }
                txtMedSel.Text = "Médico seleccionado";

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

        //private void dgvFechas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dgvFechas.Rows[e.RowIndex].DataBoundItem != null)
        //    {
        //        DateTime horario = (DateTime)dgvFechas.Rows[e.RowIndex].DataBoundItem;
        //        if (horario != null)
        //        {
        //            string date_str = horario.ToString("dd/MM/yyyy");
        //            dgvFechas.Rows[e.RowIndex].Cells[0].Value = date_str;
        //        }
        //    }
           
        //}

        

        private void btnSelectDia_Click(object sender, EventArgs e)
        {
            if ((dgvMedicos.SelectedRows.Count != 1 || cbDias.SelectedIndex == -1))
            {
                MessageBox.Show("Debe seleccionar Medico y Día", "Mensaje de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else { 
                 diaSeleccionado = cbDias.Items[cbDias.SelectedIndex].ToString();

                _medSelc = (RRHHWS.medico)dgvMedicos.CurrentRow.DataBoundItem;
             

                DayOfWeek day = DayOfWeek.Monday;
                if (diaSeleccionado == "Lunes") day = DayOfWeek.Monday;
                else if (diaSeleccionado == "Martes") day = DayOfWeek.Tuesday;
                else if (diaSeleccionado == "Miercoles") day = DayOfWeek.Wednesday;
                else if (diaSeleccionado == "Jueves") day = DayOfWeek.Thursday;
                else if (diaSeleccionado == "Viernes") day = DayOfWeek.Friday;
                else if (diaSeleccionado == "Sabado") day = DayOfWeek.Saturday;
                dateTimes = GetAllDayOfWeekPerMonth(Int32.Parse(DateTime.Now.Month.ToString()), 2022, day);
                //dgvFechas.DataSource = dateTimes;
            }
        }

        private void btnSelecFecha_Click(object sender, EventArgs e)
        {
            //GestionMedicaWS.horario[] horarios = daoGestionMedica.listarHorariosXMedicoYFecha(_medSelc.id_medico, diaSeleccionado, ((DateTime)dgvFechas.CurrentRow.DataBoundItem).ToString("yyyy-MM-dd"));
            //if (horarios != null)
            //    dgvHora.DataSource = new BindingList<GestionMedicaWS.horario>(horarios.ToList());
            //else
            //    dgvHora.DataSource = new BindingList<GestionMedicaWS.horario>();
        }

        private void cbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            diaSeleccionado = cbDias.Items[cbDias.SelectedIndex].ToString();

            _medSelc = (RRHHWS.medico)dgvMedicos.CurrentRow.DataBoundItem;


            DayOfWeek day = DayOfWeek.Monday;
            if (diaSeleccionado == "Lunes") day = DayOfWeek.Monday;
            else if (diaSeleccionado == "Martes") day = DayOfWeek.Tuesday;
            else if (diaSeleccionado == "Miercoles") day = DayOfWeek.Wednesday;
            else if (diaSeleccionado == "Jueves") day = DayOfWeek.Thursday;
            else if (diaSeleccionado == "Viernes") day = DayOfWeek.Friday;
            else if (diaSeleccionado == "Sabado") day = DayOfWeek.Saturday;
            dateTimes = GetAllDayOfWeekPerMonth(Int32.Parse(DateTime.Now.Month.ToString()), 2022, day);

            //dgvFechas.DataSource = dateTimes;
            cbFecha.DataSource = dateTimes;

        }

        private void cbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fechaSeleccionadaFormato = DateTime.ParseExact((String)cbFecha.SelectedItem, "dd/MM/yyyy", null).ToString("yyyy-MM-dd");
            GestionMedicaWS.horario[] horarios = daoGestionMedica.listarHorariosXMedicoYFecha(_medSelc.id_medico, diaSeleccionado, fechaSeleccionadaFormato);
            if (horarios != null)
                horariosXDia = new BindingList<GestionMedicaWS.horario>(horarios.ToList());
            else
                horariosXDia = new BindingList<GestionMedicaWS.horario>();
            dgvHora.DataSource = horariosXDia;
            //DateTime.ParseExact((String)cbFecha.SelectedItem, "dd/MM/yyyy", null);
        }
    }
}

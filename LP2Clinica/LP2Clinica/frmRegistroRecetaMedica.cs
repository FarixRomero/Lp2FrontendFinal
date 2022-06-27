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
    public partial class frmRegistroRecetaMedica : Form
    {
        private Estado _estado;
        private GestionMedicaWS.recetaMedica _recetaMedica;
        private GestionMedicaWS.medicamento _medicamento;
        private BindingList<GestionMedicaWS.lineaRecetaMedica> _lineasRecetaMedica;
        private GestionMedicaWS.GestionMedicaWSClient daoGestionMedica;
        public frmRegistroRecetaMedica()
        {
            InitializeComponent();
            daoGestionMedica = new GestionMedicaWS.GestionMedicaWSClient();
            dgvReceta.AutoGenerateColumns = false;
            this._estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }
        public void limpiarComponentes()
        {
            txtID.Text = "";
            txtResultado.Text = "";
            txtProducto.Text = "";
            txtCodigoProducto.Text = "";
            txtCantidad.Text = "";
            txtCodigoReceta.Text = "";
            this._recetaMedica = new GestionMedicaWS.recetaMedica();
            this._lineasRecetaMedica = new BindingList<GestionMedicaWS.lineaRecetaMedica>();
            dgvReceta.DataSource = this._lineasRecetaMedica;
        }
        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    btnBuscar.Enabled = true;
                    btnBuscarDiagnostico.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnResta.Enabled = false;
                    btnSuma.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnRegistrar.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtResultado.Enabled = false;
                    txtCodigoProducto.Enabled = false;
                    txtID.Enabled = false;
                    txtProducto.Enabled = false;
                    txtCodigoReceta.Enabled = false;
                    dgvReceta.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnBuscarDiagnostico.Enabled = true;
                    btnBuscarProducto.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnResta.Enabled = true;
                    btnSuma.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnRegistrar.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtResultado.Enabled = true;
                    txtResultado.ReadOnly = true;
                    txtCodigoProducto.Enabled = true;
                    txtCodigoReceta.Enabled = true;
                    txtID.Enabled = true;
                    txtID.ReadOnly = true;
                    txtProducto.Enabled = true;
                    dgvReceta.Enabled = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnRegistrar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscarProducto.Enabled = false;
                    btnSuma.Enabled = false;
                    btnResta.Enabled = false;
                    btnBuscarDiagnostico.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtCodigoReceta.Enabled = false;
                    txtID.Enabled = true;
                    txtID.ReadOnly = true;
                    txtResultado.Enabled = true;
                    txtResultado.ReadOnly = true;
                    txtCodigoProducto.Enabled = false;
                    txtProducto.Enabled = false;
                    dgvReceta.Enabled = false;
                    break;

            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarMedicamento formBusqMedicamento = new frmBuscarMedicamento();
            if (formBusqMedicamento.ShowDialog() == DialogResult.OK)
            {
                _medicamento = formBusqMedicamento.MedicamentoSeleccionado;
                txtCodigoProducto.Text = _medicamento.codigo;
                txtProducto.Text = _medicamento.nombre;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this._estado = Estado.Inicial;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this._estado = Estado.Nuevo;
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if(dgvReceta.CurrentRow != null)
            {
                GestionMedicaWS.lineaRecetaMedica lin = (GestionMedicaWS.lineaRecetaMedica)dgvReceta.CurrentRow.DataBoundItem;
                this._lineasRecetaMedica.Remove(lin);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una linea de receta médica", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad.Text == "" || Int32.Parse(txtCantidad.Text) == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach(GestionMedicaWS.lineaRecetaMedica linea in this._lineasRecetaMedica)
            {
                if(linea.medicamento.id_medicamento.Equals(_medicamento.id_medicamento))
                {
                    linea.cantidad=linea.cantidad + Int32.Parse(txtCantidad.Text);
                    dgvReceta.DataSource = _lineasRecetaMedica;
                    dgvReceta.Refresh();
                    _medicamento = null;
                    txtCantidad.Text = "";
                    txtCodigoProducto.Text = "";
                    txtProducto.Text = "";
                    return;
                }
            }
            GestionMedicaWS.lineaRecetaMedica lin = new GestionMedicaWS.lineaRecetaMedica();
            lin.medicamento=_medicamento;
            lin.cantidad = Int32.Parse(txtCantidad.Text);
            _lineasRecetaMedica.Add(lin);
            _medicamento = null;
            txtCantidad.Text = "";
            txtCodigoProducto.Text = "";
            txtProducto.Text = "";
        }

        private void btnBuscarDiagnostico_Click(object sender, EventArgs e)
        {
            frmBuscarDiagnostico2 formBusqDiagnostico2=new frmBuscarDiagnostico2();
            if (formBusqDiagnostico2.ShowDialog() == DialogResult.OK)
            {
                _recetaMedica.diagnostico = new GestionMedicaWS.diagnostico();
                _recetaMedica.diagnostico= formBusqDiagnostico2.DiagnosticoSeleccionado;
                txtID.Text = _recetaMedica.diagnostico.id_diagnostico.ToString();
                txtResultado.Text = _recetaMedica.diagnostico.resultado;
            }
        }

        private void dgvReceta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestionMedicaWS.lineaRecetaMedica lineas =(GestionMedicaWS.lineaRecetaMedica)dgvReceta.Rows[e.RowIndex].DataBoundItem;
            dgvReceta.Rows[e.RowIndex].Cells[0].Value = lineas.medicamento.codigo;
            dgvReceta.Rows[e.RowIndex].Cells[1].Value = lineas.medicamento.nombre;
            dgvReceta.Rows[e.RowIndex].Cells[2].Value = lineas.cantidad;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("No ha buscado el diagnostico", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this._lineasRecetaMedica.Count == 0)
            {
                MessageBox.Show("No se han agregado medicamentos a la receta medica", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _recetaMedica.codReceta = txtCodigoReceta.Text;
            _recetaMedica.lineasRecetaMedica = this._lineasRecetaMedica.ToArray();
            if (_estado == Estado.Nuevo)
            {
                int resultado = daoGestionMedica.insertarRecetaMedica(_recetaMedica);
                if (resultado != 0)
                {
                    establecerEstadoComponentes();
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarComponentes();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarRecetaMedica formBusqReceta = new frmBuscarRecetaMedica();
            if (formBusqReceta.ShowDialog() == DialogResult.OK)
            {
                _recetaMedica = formBusqReceta.RecetaSeleccionado;
                txtID.Text=_recetaMedica.diagnostico.id_diagnostico.ToString();
                txtResultado.Text = _recetaMedica.diagnostico.resultado;
                txtCodigoReceta.Text = _recetaMedica.codReceta;
                if (_recetaMedica.lineasRecetaMedica != null)
                {
                    _lineasRecetaMedica = new BindingList<GestionMedicaWS.lineaRecetaMedica>(this._recetaMedica.lineasRecetaMedica.ToList());
                    dgvReceta.DataSource = _lineasRecetaMedica;
                }
                _estado = Estado.Buscar;
                establecerEstadoComponentes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta receta médica?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                foreach (GestionMedicaWS.lineaRecetaMedica linea in _recetaMedica.lineasRecetaMedica)
                {
                    int resultado2 = daoGestionMedica.eliminarLineaRecetaMedica(linea);
                }
                int resultado = daoGestionMedica.eliminarRecetaMedica(_recetaMedica);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._estado = Estado.Inicial;
                    establecerEstadoComponentes();
                    limpiarComponentes();
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

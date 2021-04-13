using System;
using System.Windows.Forms;
using ExamenPractico2.Clases;
using ExamenPractico2.Logica;

namespace ExamenPractico2
{
    public partial class FormRegistroPacientes : Form
    {
        private String cedula;

        public FormRegistroPacientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistraPaciente_Click(object sender, EventArgs e)
        {
            LogicaPacientes loginPacientes = new LogicaPacientes();
            Paciente paciente = new Paciente();

            paciente.Cedula = txtCedula.Text.ToLower();
            paciente.Nombre = txtNombre.Text.ToLower();
            paciente.Edad = txtEdad.Text.ToLower();
            paciente.Riesgo = comboBoxGrupoRiesgo.Text.ToLower();

            loginPacientes.RegistrarPacientes(paciente);

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            BindingSource bindingSource = new LogicaPacientes().MostrarListaPacientes();

            dataGridViewPacientes.DataSource = bindingSource;
            dataGridViewPacientes.ClearSelection();
        }

        private void FormRegistroPacientes_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cedula != "")
            {
                new LogicaPacientes().EliminarEstudiante(cedula);
            }
            else
                MessageBox.Show("Primero debe selecionar un dato de la tabla", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ActualizarTabla();
        }

        private void dataGridViewPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceRow;

            if (dataGridViewPacientes.SelectedCells.Count > 0)
            {
                indiceRow = dataGridViewPacientes.SelectedCells[0].RowIndex;
                cedula = dataGridViewPacientes.Rows[indiceRow].Cells[0].Value.ToString();
            }
        }
    }
}

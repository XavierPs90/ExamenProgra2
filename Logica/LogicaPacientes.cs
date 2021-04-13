using ExamenPractico2.Clases;
using ExamenPractico2.Datos;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExamenPractico2.Logica
{
    class LogicaPacientes
    {
        Conexion conexion = new Conexion();

        public void RegistrarPacientes(Paciente paciente) 
        {
            String instruccionSecundaria, instruccionPrincipal, fecha;
            NpgsqlDataReader datosObtenidos;

            fecha = DateTime.Now.ToString();
            instruccionSecundaria = "select * from pacientes where cedula = '" + paciente.Cedula + "'";
            instruccionPrincipal = "insert into pacientes values ('" + paciente.Cedula + "', '" + paciente.Nombre + "', '" + paciente.Edad + "', '" + paciente.Riesgo + "', '" + fecha + "')";

            if (paciente.Cedula != "" && paciente.Nombre != "" && paciente.Edad != "" && paciente.Riesgo != "")
            {
                conexion.Conectar();
                datosObtenidos = conexion.Leer(instruccionSecundaria);

                if (datosObtenidos.Read())
                        MessageBox.Show("El paciente ya existe", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    conexion.Desconectar();
                    conexion.Conectar();

                    if (conexion.EjecutarInstruccion(instruccionPrincipal))
                    {
                        MessageBox.Show("El paciente se ha creado correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                    conexion.Desconectar();
            }
            else
                MessageBox.Show("Se debe rellenar todos los espacios en blanco", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public BindingSource MostrarListaPacientes()
        {
            BindingSource regresa = new BindingSource();
            DataTable dataTable;
            String instruccion = "select * from pacientes";

            conexion.Conectar();
            dataTable = conexion.ObtenerDataTable(instruccion);
            conexion.Desconectar();
            regresa.DataSource = dataTable;

            return regresa;
        }

        public void EliminarEstudiante(String cedula)
        {
            String instruccion = "delete from pacientes where cedula = '" + cedula + "'";

            conexion.Conectar();

            if (conexion.EjecutarInstruccion(instruccion))
                MessageBox.Show("Los datos se eliminaron correctamente", "Ventana de información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexion.Desconectar();
        }
    }
}

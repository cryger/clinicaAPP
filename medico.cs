using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaAPP
{
    public partial class medico : Form
    {
        public medico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            string nombre = txtIdentificacion.Text;
            string especialidad = cbEspecialidad.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            Database db = new Database();
            db.OpenConnection();

            string query = "INSERT INTO Medicos (id_medico, Nombre, Especialidad, Telefono, correo) VALUES (@identificacion,@nombre, @especialidad, @telefono, @correo)";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@identificacion", nombre);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@especialidad", especialidad);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@correo", correo);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Médico agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar médico: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void CargarDatosMedicos()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_medico, Nombre, especialidad,Telefono,Correo FROM medicos";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridViewMedicos.DataSource = dataTable;

                dataGridViewMedicos.AutoResizeColumns();
                dataGridViewMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar medicos: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT * FROM Medicos";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar el DataTable al DataGridView
                dataGridViewMedicos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar médicos: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dataGridViewMedicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un paciente para eliminar.");
                return;
            }

            // Obtenemos el ID del paciente desde la fila seleccionada
            int identificacion = Convert.ToInt32(dataGridViewMedicos.SelectedRows[0].Cells["id_medico"].Value);

            // Confirmamos que el usuario realmente desea eliminar al paciente
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este paciente?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Database db = new Database();
                db.OpenConnection();

                string query = "DELETE FROM Medicos WHERE id_medico = @identificacion";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@identificacion", identificacion);

                try
                {
                    // Ejecutamos la consulta de eliminación
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medico eliminado exitosamente.");

                        // Refrescamos el DataGridView para reflejar los cambios
                        CargarDatosMedicos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el paciente a eliminar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar paciente: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void dataGridViewMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridViewMedicos.Rows[e.RowIndex];

                // Asignamos los valores de la fila seleccionada a los campos correspondientes del formulario

                txtIdentificacion.Text = row.Cells["id_medico"].Value.ToString(); // ID del Medico
                txtNombre.Text = row.Cells["Nombre"].Value.ToString(); // Nombre


                cbEspecialidad.Text = row.Cells["especialidad"].Value.ToString(); // Sexo
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString(); // Teléfono
                txtCorreo.Text = row.Cells["Correo"].Value.ToString(); // Correo electrónico
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validamos que los campos requeridos estén completos antes de intentar actualizar
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("Por favor selecciona un médico.");
                return;
            }

            // Recolectar los datos del formulario
            string identificacion = txtIdentificacion.Text;
            string nombre = txtNombre.Text;
            string especialidad = cbEspecialidad.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            Database db = new Database();
            db.OpenConnection();

            // Consulta SQL para actualizar el médico
            string query = "UPDATE Medicos SET Nombre = @nombre, Especialidad = @especialidad, " +
                           "Telefono = @telefono, Correo = @correo WHERE id_medico = @identificacion";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@especialidad", especialidad); // Agregar especialidad
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@identificacion", identificacion);

            try
            {
                // Ejecutamos la consulta
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Médico actualizado exitosamente.");
                    // Recargar los datos del DataGridView para reflejar los cambios
                    CargarDatosMedicos(); // Asegúrate de tener esta función para recargar datos
                }
                else
                {
                    MessageBox.Show("No se encontró el médico.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar médico: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}

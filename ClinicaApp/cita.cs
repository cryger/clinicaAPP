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
    public partial class cita : Form
    {
        public cita()
        {
            InitializeComponent();
            cargarInformacionPacientes();
            cargarInformacionMedicos();
        }
        private void cargarInformacionPacientes()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_paciente FROM pacientes"; // Consulta para obtener id_citas de tratamientos
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                // Limpiar el ComboBox antes de llenarlo
                cbIdPaciente.Items.Clear();

                while (reader.Read())
                {
                    // Agregar cada nombre al ComboBox
                    cbIdPaciente.Items.Add(reader["id_paciente"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id_paciente de paciente: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void cargarInformacionMedicos()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_medico FROM medicos"; // Consulta para obtener id_citas de tratamientos
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                // Limpiar el ComboBox antes de llenarlo
                cbIdMedico.Items.Clear();

                while (reader.Read())
                {
                    // Agregar cada nombre al ComboBox
                    cbIdMedico.Items.Add(reader["id_medico"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id_medico de Medicos: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
        private void cargarInformacionCitas()
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT id_cita FROM citas"; // Consulta para obtener id_citas de tratamientos
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                // Limpiar el ComboBox antes de llenarlo
                cbIdMedico.Items.Clear();

                while (reader.Read())
                {
                    // Agregar cada nombre al ComboBox
                    cbIdMedico.Items.Add(reader["id_cita"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar id_cita de Citas: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCita = Int32.Parse(txtIdCita.Text);
            DateTime fecha = dtpFechaCita.Value;
            int pacienteID = int.Parse(cbIdPaciente.Text);
            int medicoID = int.Parse(cbIdMedico.Text);
            string motivo = txtMotivo.Text;

            Database db = new Database();
            db.OpenConnection();

            string query = "INSERT INTO Citas (id_cita, Fecha_Cita, id_paciente, id_medico, motivo) VALUES (@idCita,@fecha, @pacienteID, @medicoID, @motivo)";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@idCita", idCita);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@pacienteID", pacienteID);
            cmd.Parameters.AddWithValue("@medicoID", medicoID);
            cmd.Parameters.AddWithValue("@motivo", motivo);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cita agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cita: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.OpenConnection();

            string query = "SELECT * FROM citas";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar el DataTable al DataGridView
                dataGridViewCitas.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar citas: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void dataGridViewCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridViewCitas.Rows[e.RowIndex];

                // Asignamos los valores de la fila seleccionada a los campos correspondientes del formulario

                txtIdCita.Text = row.Cells["id_cita"].Value.ToString(); // ID cita

                txtMotivo.Text = row.Cells["motivo"].Value.ToString(); // Descripcion

                if (row.Cells["Fecha_Cita"].Value != DBNull.Value)
                {
                    DateTime fechaCita = Convert.ToDateTime(row.Cells["Fecha_Cita"].Value);
                    dtpFechaCita.Value = fechaCita; // Campo tipo DateTimePicker
                }

                cbIdMedico.Text = row.Cells["id_medico"].Value.ToString(); // medico
                cbIdPaciente.Text = row.Cells["id_paciente"].Value.ToString(); // Paciente

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dataGridViewCitas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un paciente para eliminar.");
                return;
            }

            // Obtenemos el ID de la cita desde la fila seleccionada
            int identificacion = Convert.ToInt32(dataGridViewCitas.SelectedRows[0].Cells["id_cita"].Value);

            // Confirmamos que el usuario realmente desea eliminar la cita
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este paciente?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Database db = new Database();
                db.OpenConnection();

                string query = "DELETE FROM citas WHERE id_cita = @idCita";

                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@idCita", identificacion);

                try
                {
                    // Ejecutamos la consulta de eliminación
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medico eliminado exitosamente.");

                        // Refrescamos el DataGridView para reflejar los cambios
                        cargarInformacionCitas();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idCita = int.Parse(txtIdCita.Text);
            int idPaciente = Int32.Parse(cbIdPaciente.Text);
            int idMedico = Int32.Parse(cbIdMedico.Text);

            string motivo = txtMotivo.Text;


            Database db = new Database();
            db.OpenConnection();

            string query = "UPDATE citas SET id_cita = @idCita, id_paciente = @idPaciente, id_medico = @idMedico, motivo = @motivo WHERE id_cita = @idCita";

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@idCita", idCita);
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
            cmd.Parameters.AddWithValue("@idMedico", idMedico);
            cmd.Parameters.AddWithValue("@motivo", motivo);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("cita actualizada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cita: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal menu = new Principal();
            menu.Show();
        }
    }
}
